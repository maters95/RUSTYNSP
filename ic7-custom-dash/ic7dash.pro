# qmake project — the build system the Boot2Qt / Yocto Qt 5.9 SDK uses.
# Desktop:  qmake && make            (simulator feed, no SocketCAN)
# Dash/ARM: source the SDK env, then  qmake && make   (SocketCAN auto-on)
# CMakeLists.txt builds the same sources; use whichever your kit prefers.

QT += quick qml positioning location network multimedia
CONFIG += c++17
TARGET = ic7dash
TEMPLATE = app

SOURCES += \
    src/main.cpp \
    src/cansource.cpp \
    src/emtrondecoder.cpp \
    src/channelmodel.cpp \
    src/laptimer.cpp \
    src/tileserver.cpp

HEADERS += \
    src/cansource.h \
    src/emtrondecoder.h \
    src/channelmodel.h \
    src/laptimer.h \
    src/tileserver.h

RESOURCES += qml.qrc

# SocketCAN exists only on Linux (the dash). Desktop builds use the simulator.
linux:!android: DEFINES += HAVE_SOCKETCAN
