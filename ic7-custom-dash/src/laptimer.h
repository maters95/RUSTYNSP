#pragma once
#include <QObject>
#include <QElapsedTimer>
#include <QGeoCoordinate>
#include <QVector>

// GPS lap timing. Define a start/finish line as two coordinates (left & right
// posts). Each time the car's path crosses that segment, a lap is recorded.
// Feed it positions from QML's PositionSource (real GPS) or the simulator.
class LapTimer : public QObject
{
    Q_OBJECT
    Q_PROPERTY(int lapCount READ lapCount NOTIFY lapsChanged)
    Q_PROPERTY(double currentLapMs READ currentLapMs NOTIFY tick)
    Q_PROPERTY(double lastLapMs READ lastLapMs NOTIFY lapsChanged)
    Q_PROPERTY(double bestLapMs READ bestLapMs NOTIFY lapsChanged)
    Q_PROPERTY(bool armed READ armed NOTIFY armedChanged)
public:
    explicit LapTimer(QObject *parent = nullptr);

    int lapCount() const { return m_laps.size(); }
    double currentLapMs() const;
    double lastLapMs() const { return m_laps.isEmpty() ? 0.0 : m_laps.last(); }
    double bestLapMs() const { return m_best; }
    bool armed() const { return m_armed; }

public slots:
    // Set the finish line from two points (e.g. captured by driving across it).
    void setFinishLine(double lat1, double lon1, double lat2, double lon2);
    // Call on every GPS fix.
    void addFix(double lat, double lon);
    void reset();

signals:
    void lapsChanged();
    void tick();
    void armedChanged();
    void lapCompleted(double ms);

private:
    static bool segmentsCross(const QGeoCoordinate &a, const QGeoCoordinate &b,
                              const QGeoCoordinate &c, const QGeoCoordinate &d);

    QGeoCoordinate m_lineA, m_lineB;   // finish line posts
    bool m_haveLine = false;
    QGeoCoordinate m_prev;             // previous fix
    bool m_havePrev = false;
    bool m_armed = false;              // true once a line is set and timing can run
    QElapsedTimer m_lapClock;
    QVector<double> m_laps;
    double m_best = 0.0;
};
