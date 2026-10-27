#include "cansource.h"
#include <QtGlobal>
#include <QtMath>

// --- helper: little-endian u16 into two bytes ---
static void putU16LE(QByteArray &b, int at, quint16 v)
{
    b[at]   = char(v & 0xFF);
    b[at+1] = char((v >> 8) & 0xFF);
}

SimulatedCanSource::SimulatedCanSource(QObject *parent) : CanSource(parent)
{
    connect(&m_timer, &QTimer::timeout, this, &SimulatedCanSource::tick);
}

bool SimulatedCanSource::start()
{
    m_timer.start(20); // 50 Hz
    return true;
}

// Physical value -> raw u16, the inverse of the decoder (raw * scale + offset).
static quint16 enc(double phys, double scale, double offset)
{
    return quint16(qBound(0.0, qRound((phys - offset) / scale) * 1.0, 65535.0));
}

void SimulatedCanSource::tick()
{
    m_t += 0.02;
    // RPM sweeps 1000-7500, the rest follow it so the demo looks like a pull.
    const double load    = qMax(0.0, qSin(m_t * 0.6));
    const double rpm     = 4250 + 3250 * qSin(m_t * 0.6);
    const double speed   = qMax(0.0, (rpm - 1000) / 60.0);   // km/h
    const double coolant = qMin(88.0, 40.0 + m_t * 2.0);     // C
    const double oilTemp = qMin(100.0, 35.0 + m_t * 1.6);
    const double boost   = -10.0 + 25.0 * load;              // psi gauge
    const double lambda  = 1.0 - 0.2 * load + 0.02 * qSin(m_t * 3.0);

    // Layout matches resources/emtron_can.json (copied from NSP Generic CAN).
    auto frame = [this](quint32 id, quint16 a, quint16 b, quint16 c, quint16 d) {
        QByteArray f(8, '\0');
        putU16LE(f, 0, a); putU16LE(f, 2, b); putU16LE(f, 4, c); putU16LE(f, 6, d);
        emit frameReceived(id, f);
    };

    frame(0x3E8, enc(rpm, 1, 0), enc(boost, 0.0145038, -14.696),
                 enc(coolant, 0.1, -50), enc(32.0 + 8 * load, 0.1, -50));
    frame(0x3E9, enc(25 + 45 * load, 0.0145038, 0), enc(43.5, 0.0145038, 0),
                 enc(85.0, 0.1, 0), enc(lambda, 0.001, 0));
    frame(0x3EA, enc(oilTemp, 0.1, -50), enc(0, 1, 0),
                 enc(12 + 20 * load, 0.1, -100), enc(rpm > 5500 ? 1 : 0, 1, 0));
    frame(0x3EB, enc(speed, 0.1, 0), 0, 0, 0);
    frame(0x3F2, enc(10 + 90 * load, 0.1, -100), enc(1.5 * qSin(m_t), 0.01, -100),
                 enc(-0.8, 0.01, -100), enc(1.0 - 0.2 * load, 0.001, 0));
    frame(0x3F3, enc(12 + 20 * load, 0.1, -100), enc(15 + 70 * load, 0.1, 0),
                 enc(0, 1, 0), enc(0, 1, 0));
    frame(0x3F4, enc(10 + 30 * load, 0.1, -200), enc(10 + 30 * load, 0.1, -200), 0, 0);
}

#ifdef HAVE_SOCKETCAN
#include <QSocketNotifier>
#include <sys/socket.h>
#include <sys/ioctl.h>
#include <net/if.h>
#include <unistd.h>
#include <cstring>
#include <linux/can.h>
#include <linux/can/raw.h>

SocketCanSource::SocketCanSource(const QString &iface, QObject *parent)
    : CanSource(parent), m_iface(iface) {}

bool SocketCanSource::start()
{
    m_fd = ::socket(PF_CAN, SOCK_RAW, CAN_RAW);
    if (m_fd < 0) return false;

    struct ifreq ifr;
    std::memset(&ifr, 0, sizeof(ifr));
    std::strncpy(ifr.ifr_name, m_iface.toLocal8Bit().constData(), IFNAMSIZ - 1);
    if (::ioctl(m_fd, SIOCGIFINDEX, &ifr) < 0) { ::close(m_fd); m_fd = -1; return false; }

    struct sockaddr_can addr;
    std::memset(&addr, 0, sizeof(addr));
    addr.can_family = AF_CAN;
    addr.can_ifindex = ifr.ifr_ifindex;
    if (::bind(m_fd, reinterpret_cast<struct sockaddr *>(&addr), sizeof(addr)) < 0) {
        ::close(m_fd); m_fd = -1; return false;
    }

    auto *n = new QSocketNotifier(m_fd, QSocketNotifier::Read, this);
    connect(n, &QSocketNotifier::activated, this, &SocketCanSource::readReady);
    return true;
}

void SocketCanSource::readReady()
{
    struct can_frame frame;
    const int n = ::read(m_fd, &frame, sizeof(frame));
    if (n < int(sizeof(frame))) return;
    emit frameReceived(frame.can_id & CAN_EFF_MASK,
                       QByteArray(reinterpret_cast<char *>(frame.data), frame.can_dlc));
}
#endif
