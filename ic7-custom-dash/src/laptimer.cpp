#include "laptimer.h"

LapTimer::LapTimer(QObject *parent) : QObject(parent) {}

double LapTimer::currentLapMs() const
{
    return m_lapClock.isValid() ? double(m_lapClock.elapsed()) : 0.0;
}

void LapTimer::setFinishLine(double lat1, double lon1, double lat2, double lon2)
{
    m_lineA = QGeoCoordinate(lat1, lon1);
    m_lineB = QGeoCoordinate(lat2, lon2);
    m_haveLine = true;
    m_armed = true;
    emit armedChanged();
}

void LapTimer::reset()
{
    m_laps.clear();
    m_best = 0.0;
    m_lapClock.invalidate();
    m_havePrev = false;
    emit lapsChanged();
    emit tick();
}

// Standard 2D segment-intersection test using signed orientation.
// Projecting lat/lon flat is fine for a finish line a few metres long.
bool LapTimer::segmentsCross(const QGeoCoordinate &a, const QGeoCoordinate &b,
                             const QGeoCoordinate &c, const QGeoCoordinate &d)
{
    auto cross = [](const QGeoCoordinate &p, const QGeoCoordinate &q, const QGeoCoordinate &r) {
        // z-component of (q-p) x (r-p), using lon as x and lat as y
        return (q.longitude() - p.longitude()) * (r.latitude() - p.latitude())
             - (q.latitude()  - p.latitude())  * (r.longitude() - p.longitude());
    };
    const double d1 = cross(c, d, a);
    const double d2 = cross(c, d, b);
    const double d3 = cross(a, b, c);
    const double d4 = cross(a, b, d);
    return ((d1 > 0) != (d2 > 0)) && ((d3 > 0) != (d4 > 0));
}

void LapTimer::addFix(double lat, double lon)
{
    const QGeoCoordinate cur(lat, lon);
    if (!m_havePrev) {
        m_prev = cur;
        m_havePrev = true;
        return;
    }

    if (m_haveLine && segmentsCross(m_prev, cur, m_lineA, m_lineB)) {
        if (m_lapClock.isValid()) {
            const double ms = double(m_lapClock.elapsed());
            m_laps.append(ms);
            if (m_best == 0.0 || ms < m_best)
                m_best = ms;
            emit lapCompleted(ms);
            emit lapsChanged();
        }
        m_lapClock.restart(); // start (or restart) timing from this crossing
    }

    m_prev = cur;
    emit tick(); // let QML refresh the running lap time
}
