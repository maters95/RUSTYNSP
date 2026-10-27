#include "tileserver.h"
#include <QTcpSocket>
#include <QHostAddress>
#include <QFile>
#include <QFileInfo>
#include <QDir>
#include <QRegularExpression>

TileServer::TileServer(const QString &baseDir, QObject *parent)
    : QObject(parent), m_baseDir(QDir(baseDir).absolutePath())
{
    connect(&m_server, &QTcpServer::newConnection, this, &TileServer::onNewConnection);
}

bool TileServer::listen(quint16 preferredPort)
{
    if (m_server.listen(QHostAddress::LocalHost, preferredPort))
        return true;
    return m_server.listen(QHostAddress::LocalHost, 0); // any free port
}

quint16 TileServer::port() const { return m_server.serverPort(); }

QString TileServer::baseUrl() const
{
    return QStringLiteral("http://127.0.0.1:%1/").arg(m_server.serverPort());
}

void TileServer::onNewConnection()
{
    while (QTcpSocket *sock = m_server.nextPendingConnection()) {
        connect(sock, &QTcpSocket::readyRead, sock, [sock, this]() {
            const QByteArray req = sock->readAll();
            const int sp1 = req.indexOf(' ');
            const int sp2 = req.indexOf(' ', sp1 + 1);
            if (sp1 < 0 || sp2 < 0) { sock->close(); return; }
            const QByteArray method = req.left(sp1);
            QString path = QString::fromLatin1(req.mid(sp1 + 1, sp2 - sp1 - 1));

            auto send = [sock](int code, const QByteArray &type, const QByteArray &body) {
                QByteArray h = "HTTP/1.0 " + QByteArray::number(code) + " \r\n";
                h += "Content-Type: " + type + "\r\n";
                h += "Content-Length: " + QByteArray::number(body.size()) + "\r\n";
                h += "Connection: close\r\n\r\n";
                sock->write(h);
                sock->write(body);
                sock->flush();
                sock->disconnectFromHost();
            };

            // Only GET of /<z>/<x>/<y>.png, and never escape the base dir.
            static const QRegularExpression re("^/\\d+/\\d+/\\d+\\.png$");
            if (method != "GET" || !re.match(path).hasMatch()) {
                send(404, "text/plain", "no");
                return;
            }
            const QString full = QDir(m_baseDir).filePath(path.mid(1));
            QFile f(full);
            // IC7_TILE_LOG=1: log each tile request (used by the QEMU smoke test).
            static const bool logTiles = qEnvironmentVariableIsSet("IC7_TILE_LOG");
            if (!f.exists() || !f.open(QIODevice::ReadOnly)) {
                if (logTiles) qInfo("tileserver: 404 %s", qPrintable(path));
                send(404, "image/png", QByteArray());
                return;
            }
            if (logTiles) qInfo("tileserver: 200 %s", qPrintable(path));
            send(200, "image/png", f.readAll());
        });
        connect(sock, &QTcpSocket::disconnected, sock, &QObject::deleteLater);
    }
}
