#include "emtrondecoder.h"
#include "channelmodel.h"
#include <QFile>
#include <QJsonDocument>
#include <QJsonObject>
#include <QJsonArray>
#include <QDebug>

EmtronDecoder::EmtronDecoder(ChannelModel *channels, QObject *parent)
    : QObject(parent), m_channels(channels) {}

bool EmtronDecoder::loadConfig(const QString &path)
{
    QFile f(path);
    if (!f.open(QIODevice::ReadOnly)) {
        qWarning() << "EmtronDecoder: cannot open" << path;
        return false;
    }
    QJsonParseError err;
    const auto doc = QJsonDocument::fromJson(f.readAll(), &err);
    if (err.error != QJsonParseError::NoError) {
        qWarning() << "EmtronDecoder: JSON error" << err.errorString();
        return false;
    }

    m_frames.clear();
    for (const auto &fv : doc.object().value("frames").toArray()) {
        const auto fo = fv.toObject();
        Frame frame;
        // id accepts "0x3EB" or decimal.
        const QString ids = fo.value("id").toString();
        bool ok = false;
        frame.id = ids.startsWith("0x") ? ids.mid(2).toUInt(&ok, 16) : ids.toUInt(&ok, 10);
        if (!ok) { qWarning() << "bad frame id" << ids; continue; }

        for (const auto &sv : fo.value("signals").toArray()) {
            const auto so = sv.toObject();
            Signal s;
            s.name = so.value("name").toString();
            s.startBit = so.value("startBit").toInt(0);
            s.length = so.value("length").toInt(16);
            s.littleEndian = so.value("endian").toString("little") != "big";
            s.isSigned = so.value("signed").toBool(false);
            s.scale = so.value("scale").toDouble(1.0);
            s.offset = so.value("offset").toDouble(0.0);
            frame.signals_.append(s);
        }
        m_frames.insert(frame.id, frame);
    }
    qInfo() << "EmtronDecoder: loaded" << m_frames.size() << "frames";
    return true;
}

double EmtronDecoder::extract(const QByteArray &data, const Signal &s) const
{
    // Assemble raw bits. CAN payloads are <= 8 bytes.
    quint64 raw = 0;
    for (int i = 0; i < s.length; ++i) {
        int bit = s.startBit + i;
        int byteIndex = bit / 8;
        int bitInByte = bit % 8;
        if (byteIndex >= data.size()) break;
        quint64 b = (static_cast<quint8>(data[byteIndex]) >> bitInByte) & 0x1ULL;
        if (s.littleEndian)
            raw |= (b << i);                      // LSB-first within the signal
        else
            raw |= (b << (s.length - 1 - i));     // MSB-first (big-endian)
    }

    double value;
    if (s.isSigned && s.length < 64) {
        const quint64 signBit = 1ULL << (s.length - 1);
        if (raw & signBit)
            value = static_cast<double>(static_cast<qint64>(raw) - (1LL << s.length));
        else
            value = static_cast<double>(raw);
    } else {
        value = static_cast<double>(raw);
    }
    return value * s.scale + s.offset;
}

void EmtronDecoder::onFrame(quint32 id, const QByteArray &data)
{
    auto it = m_frames.find(id);
    if (it == m_frames.end())
        return;
    for (const auto &s : it->signals_)
        m_channels->set(s.name, extract(data, s));
}
