#include "channelmodel.h"

ChannelModel::ChannelModel(QObject *parent) : QQmlPropertyMap(parent) {}

void ChannelModel::set(const QString &name, double value)
{
    // insert() both creates the key on first use and emits valueChanged,
    // which is what drives QML bindings.
    insert(name, value);
}

double ChannelModel::get(const QString &name) const
{
    return value(name).toDouble();
}
