#pragma once

#include <QObject>
#include <QSerialPort>

class NmeaGpsSource : public QObject
{
    Q_OBJECT

public:
    explicit NmeaGpsSource(const QString &devicePath, bool active, QObject *parent = nullptr);

    static bool parseSentence(const QByteArray &sentence, double *latitude, double *longitude);

signals:
    void fixReceived(double latitude, double longitude);

private slots:
    void readAvailable();
    void handleSerialError(QSerialPort::SerialPortError error);

private:
    void processLine(const QByteArray &line);

    QSerialPort m_serial;
    QByteArray m_buffer;
    bool m_reportedFirstFix = false;
};
