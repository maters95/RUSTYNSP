#include <QGuiApplication>
#include <QQmlApplicationEngine>
#include <QQmlContext>
#include <QtQml>
#include <QFileInfo>
#include <QFile>
#include "channelmodel.h"
#include "emtrondecoder.h"
#include "cansource.h"
#include "laptimer.h"
#include "tileserver.h"
#include "nmeagpssource.h"

// Resolve the CAN map: next to the exe, or the bundled resource copy.
static QString canConfigPath()
{
    const QString local = QCoreApplication::applicationDirPath() + "/emtron_can.json";
    if (QFileInfo::exists(local))
        return local;
    return QStringLiteral(":/resources/emtron_can.json");
}

int main(int argc, char *argv[])
{
    QGuiApplication app(argc, argv);

    auto *channels = new ChannelModel(&app);
    auto *decoder  = new EmtronDecoder(channels, &app);
    decoder->loadConfig(canConfigPath());

    auto *lap = new LapTimer(&app);
    const bool simulatedGps = qgetenv("IC7_SIM_GPS") != "0";
    QByteArray gpsDevice = qgetenv("IC7_GPS_DEVICE");
    if (gpsDevice.isEmpty())
        gpsDevice = "/dev/ttyUSB0";
    auto *gps = new NmeaGpsSource(QString::fromLocal8Bit(gpsDevice), !simulatedGps, &app);

    // Serve bundled map tiles from <appdir>/tiles over loopback HTTP, so the
    // map works fully offline in the car. Empty URL => QML falls back to online.
    auto *tiles = new TileServer(QCoreApplication::applicationDirPath() + "/tiles", &app);
    const QString tileUrl = tiles->listen() ? tiles->baseUrl() : QString();
    const QString attributionPath =
        QCoreApplication::applicationDirPath() + "/tiles/ATTRIBUTION.txt";
    QFile attributionFile(attributionPath);
    QString mapAttribution = "Offline map attribution missing";
    if (attributionFile.open(QIODevice::ReadOnly | QIODevice::Text)) {
        const QString configuredAttribution =
            QString::fromUtf8(attributionFile.readAll()).trimmed();
        if (!configuredAttribution.isEmpty())
            mapAttribution = configuredAttribution;
        else
            qWarning() << "Map attribution file is empty:" << attributionPath;
    } else {
        qWarning() << "Map attribution file not found:" << attributionPath;
    }

    // Pick the CAN feed: IC7_CAN=can0 -> real SocketCAN, else simulator.
    // If the real bus can't be opened (interface not up, no adapter), fall back
    // to the simulator so the dash still comes up with a working UI instead of a
    // blank screen — the first on-dash test then works even before CAN is wired.
    CanSource *source = nullptr;
    const QByteArray iface = qgetenv("IC7_CAN");
#ifdef HAVE_SOCKETCAN
    if (!iface.isEmpty())
        source = new SocketCanSource(QString::fromLocal8Bit(iface), &app);
#endif
    if (!source)
        source = new SimulatedCanSource(&app);

    QObject::connect(source, &CanSource::frameReceived, decoder, &EmtronDecoder::onFrame);
    if (!source->start()) {
        qWarning() << "CAN source" << iface << "unavailable; using simulated feed";
        source->deleteLater();
        source = new SimulatedCanSource(&app);
        QObject::connect(source, &CanSource::frameReceived, decoder, &EmtronDecoder::onFrame);
        source->start();
    }

    QQmlApplicationEngine engine;
    engine.rootContext()->setContextProperty("channels", channels);
    engine.rootContext()->setContextProperty("lapTimer", lap);
    // IC7_SHOT=<dir>: save a PNG of each page, then quit (for testing).
    engine.rootContext()->setContextProperty("shotDir", QString::fromLocal8Bit(qgetenv("IC7_SHOT")));
    engine.rootContext()->setContextProperty("tileBaseUrl", tileUrl);
    engine.rootContext()->setContextProperty("tileCacheDir", QCoreApplication::applicationDirPath() + "/tilecache");
    engine.rootContext()->setContextProperty("mapAttribution", mapAttribution);
    engine.rootContext()->setContextProperty("simulatedGps", simulatedGps);
    engine.rootContext()->setContextProperty("gpsSource", gps);
    // Nav-screen background: IC7_BG = map (default) | gif | video.
    // bg.gif / bg.mp4 are read from next to the binary.
    QString bgMode = QString::fromLocal8Bit(qgetenv("IC7_BG")).toLower();
    if (bgMode != "gif" && bgMode != "video") bgMode = "map";
    engine.rootContext()->setContextProperty("bgMode", bgMode);
    // As a file:// URL so QML AnimatedImage/Video can load it.
    engine.rootContext()->setContextProperty("bgDir",
        QUrl::fromLocalFile(QCoreApplication::applicationDirPath()).toString());
    engine.load(QUrl(QStringLiteral("qrc:/qml/Main.qml")));
    if (engine.rootObjects().isEmpty())
        return -1;
    return app.exec();
}
