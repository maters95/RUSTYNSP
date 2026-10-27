#pragma once
#include <QObject>
#include <QByteArray>
#include <QHash>
#include <QVector>
#include <QString>
#include <cstdint>

class ChannelModel;

// Table-driven CAN decoder. The frame/signal layout lives in a JSON file
// (resources/emtron_can.json) so you can correct byte offsets and scaling
// WITHOUT recompiling. That matters because the exact Emtron transmit layout
// is defined in your ECU's CAN config (Emtune) and should be confirmed there.
class EmtronDecoder : public QObject
{
    Q_OBJECT
public:
    explicit EmtronDecoder(ChannelModel *channels, QObject *parent = nullptr);

    // Returns false if the JSON could not be parsed.
    bool loadConfig(const QString &path);

public slots:
    // Wire this to CanSource::frameReceived.
    void onFrame(quint32 id, const QByteArray &data);

private:
    struct Signal {
        QString name;
        int startBit = 0;      // bit offset from byte 0, bit 0 = LSB of byte 0
        int length = 16;       // bits
        bool littleEndian = true;
        bool isSigned = false;
        double scale = 1.0;
        double offset = 0.0;
    };
    struct Frame {
        quint32 id = 0;
        QVector<Signal> signals_;
    };

    double extract(const QByteArray &data, const Signal &s) const;

    ChannelModel *m_channels;
    QHash<quint32, Frame> m_frames;
};
