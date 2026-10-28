#include "nmeagpssource.h"

#include <QDebug>
#include <QtMath>

namespace {

bool coordinate(const QByteArray &value, const QByteArray &hemisphere, bool latitude,
                double *result)
{
    if (value.isEmpty() || hemisphere.size() != 1)
        return false;

    bool ok = false;
    const double degreesAndMinutes = value.toDouble(&ok);
    if (!ok || !qIsFinite(degreesAndMinutes) || degreesAndMinutes < 0.0)
        return false;

    const double degrees = qFloor(degreesAndMinutes / 100.0);
    const double minutes = degreesAndMinutes - degrees * 100.0;
    const double maximum = latitude ? 90.0 : 180.0;
    if (minutes >= 60.0 || degrees > maximum ||
        (degrees == maximum && minutes != 0.0))
        return false;

    const char direction = hemisphere.at(0);
    if ((latitude && direction != 'N' && direction != 'S') ||
        (!latitude && direction != 'E' && direction != 'W'))
        return false;

    const double sign = direction == 'S' || direction == 'W' ? -1.0 : 1.0;
    *result = sign * (degrees + minutes / 60.0);
    return true;
}

bool parseCoordinates(const QList<QByteArray> &fields, int latitudeIndex,
                      int latitudeHemisphereIndex, int longitudeIndex,
                      int longitudeHemisphereIndex, double *latitude,
                      double *longitude)
{
    return fields.size() > longitudeHemisphereIndex &&
           coordinate(fields.at(latitudeIndex), fields.at(latitudeHemisphereIndex),
                      true, latitude) &&
           coordinate(fields.at(longitudeIndex), fields.at(longitudeHemisphereIndex),
                      false, longitude);
}

} // namespace

NmeaGpsSource::NmeaGpsSource(const QString &devicePath, bool active, QObject *parent)
    : QObject(parent)
{
    if (!active)
        return;

    m_serial.setPortName(devicePath);
    m_serial.setBaudRate(QSerialPort::Baud9600);
    m_serial.setDataBits(QSerialPort::Data8);
    m_serial.setParity(QSerialPort::NoParity);
    m_serial.setStopBits(QSerialPort::OneStop);
    m_serial.setFlowControl(QSerialPort::NoFlowControl);

    connect(&m_serial, &QSerialPort::readyRead, this, &NmeaGpsSource::readAvailable);
    connect(&m_serial, &QSerialPort::errorOccurred, this, &NmeaGpsSource::handleSerialError);

    if (!m_serial.open(QIODevice::ReadOnly)) {
        qWarning() << "GPS: cannot open NMEA serial device" << devicePath
                   << ":" << m_serial.errorString();
        return;
    }

    qInfo() << "GPS: listening for NMEA on" << devicePath << "at 9600 baud";
}

bool NmeaGpsSource::parseSentence(const QByteArray &sentence, double *latitude,
                                  double *longitude)
{
    if (!latitude || !longitude)
        return false;

    const QByteArray line = sentence.trimmed();
    const int checksumSeparator = line.indexOf('*');
    if (line.size() < 7 || line.at(0) != '$' ||
        checksumSeparator < 2 || checksumSeparator + 3 != line.size())
        return false;

    bool checksumOk = false;
    const int expectedChecksum = line.mid(checksumSeparator + 1, 2).toInt(&checksumOk, 16);
    if (!checksumOk)
        return false;

    int actualChecksum = 0;
    for (int i = 1; i < checksumSeparator; ++i)
        actualChecksum ^= static_cast<unsigned char>(line.at(i));
    if (actualChecksum != expectedChecksum)
        return false;

    const QList<QByteArray> fields = line.left(checksumSeparator).mid(1).split(',');
    if (fields.isEmpty())
        return false;

    const QByteArray type = fields.at(0);
    if (type.endsWith("GGA")) {
        bool fixOk = false;
        const int quality = fields.value(6).toInt(&fixOk);
        return fixOk && quality > 0 &&
               parseCoordinates(fields, 2, 3, 4, 5, latitude, longitude);
    }

    if (type.endsWith("RMC"))
        return fields.value(2) == "A" &&
               parseCoordinates(fields, 3, 4, 5, 6, latitude, longitude);

    return false;
}

void NmeaGpsSource::readAvailable()
{
    m_buffer.append(m_serial.readAll());
    if (m_buffer.size() > 1024) {
        const int newestSentence = m_buffer.lastIndexOf('$');
        m_buffer = newestSentence >= 0 ? m_buffer.mid(newestSentence) : QByteArray();
    }

    int newline = -1;
    while ((newline = m_buffer.indexOf('\n')) >= 0) {
        const QByteArray line = m_buffer.left(newline);
        m_buffer.remove(0, newline + 1);
        processLine(line);
    }
}

void NmeaGpsSource::processLine(const QByteArray &line)
{
    double latitude = 0.0;
    double longitude = 0.0;
    if (parseSentence(line, &latitude, &longitude)) {
        if (!m_reportedFirstFix) {
            qInfo().noquote() << "GPS: first valid NMEA fix"
                              << QString::number(latitude, 'f', 6)
                              << QString::number(longitude, 'f', 6);
            m_reportedFirstFix = true;
        }
        emit fixReceived(latitude, longitude);
    }
}

void NmeaGpsSource::handleSerialError(QSerialPort::SerialPortError error)
{
    if (error == QSerialPort::NoError || error == QSerialPort::TimeoutError)
        return;

    qWarning() << "GPS: NMEA serial error:" << m_serial.errorString();
}
