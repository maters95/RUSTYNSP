#pragma once
#include <QObject>
#include <QByteArray>
#include <QTimer>
#include <cstdint>

// Abstract CAN feed. Emit frameReceived for each frame.
class CanSource : public QObject
{
    Q_OBJECT
public:
    using QObject::QObject;
    virtual bool start() = 0;
signals:
    void frameReceived(quint32 id, const QByteArray &data);
};

// Plausible fake data so the dash runs on a PC with no hardware.
// Produces an RPM sweep, matching speed, warming temps, wobbling AFR, etc.,
// on the Emtron frame IDs the EK9 screen uses (0x3E8-0x3EB).
class SimulatedCanSource : public CanSource
{
    Q_OBJECT
public:
    explicit SimulatedCanSource(QObject *parent = nullptr);
    bool start() override;
private:
    void tick();
    QTimer m_timer;
    double m_t = 0.0;
};

#ifdef HAVE_SOCKETCAN
// Real CAN on Linux (the dash, or a PC with a USB-CAN adapter):
//   sudo ip link set can0 type can bitrate 1000000 && sudo ip link set up can0
class SocketCanSource : public CanSource
{
    Q_OBJECT
public:
    explicit SocketCanSource(const QString &iface, QObject *parent = nullptr);
    bool start() override;
private:
    void readReady();
    QString m_iface;
    int m_fd = -1;
};
#endif
