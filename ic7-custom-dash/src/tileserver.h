#pragma once
#include <QObject>
#include <QTcpServer>
#include <QString>

// Tiny loopback HTTP server that serves map tiles from a local folder as
// /<z>/<x>/<y>.png. Lets QtLocation's osm plugin render REAL maps fully
// offline on the dash (no internet, no HTTPS/TLS) by pointing its custom host
// at http://127.0.0.1:<port>/. Serves only GET of .png under the base dir.
class TileServer : public QObject
{
    Q_OBJECT
public:
    explicit TileServer(const QString &baseDir, QObject *parent = nullptr);
    bool listen(quint16 preferredPort = 8089); // falls back to any free port
    quint16 port() const;
    QString baseUrl() const;                    // "http://127.0.0.1:<port>/"

private slots:
    void onNewConnection();

private:
    QString m_baseDir;
    QTcpServer m_server;
};
