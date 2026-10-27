#pragma once
#include <QQmlPropertyMap>
#include <QString>

// Live engine channels, exposed to QML as a dynamic map.
// From QML:  channels.ENGINE_SPEED, channels.COOLANT_TEMP, ...
// Any channel the decoder writes becomes a readable QML property that
// updates bindings automatically. Unknown channels simply appear as they
// are first written, so you never have to declare them twice.
class ChannelModel : public QQmlPropertyMap
{
    Q_OBJECT
public:
    explicit ChannelModel(QObject *parent = nullptr);

    // Called by the decoder. Emits valueChanged so QML bindings refresh.
    void set(const QString &name, double value);

    Q_INVOKABLE double get(const QString &name) const;
};
