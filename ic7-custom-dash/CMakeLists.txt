cmake_minimum_required(VERSION 3.16)
project(ic7dash VERSION 0.1 LANGUAGES CXX)

set(CMAKE_CXX_STANDARD 17)
set(CMAKE_CXX_STANDARD_REQUIRED ON)
set(CMAKE_AUTOMOC ON)
set(CMAKE_AUTORCC ON)

# Qt5 (matches the dash's Qt 5.9 era) or Qt6 on a modern dev box.
find_package(QT NAMES Qt6 Qt5 REQUIRED COMPONENTS Core Gui Qml Quick Positioning Location Network Multimedia)
find_package(Qt${QT_VERSION_MAJOR} REQUIRED COMPONENTS Core Gui Qml Quick Positioning Location Network Multimedia)

# SocketCAN is Linux-only; on Windows/macOS we build with the simulated source only.
if(UNIX AND NOT APPLE)
    add_definitions(-DHAVE_SOCKETCAN)
endif()

add_executable(ic7dash
    src/main.cpp
    src/cansource.cpp
    src/emtrondecoder.cpp
    src/channelmodel.cpp
    src/laptimer.cpp
    src/tileserver.cpp
    qml.qrc
)

target_link_libraries(ic7dash PRIVATE
    Qt${QT_VERSION_MAJOR}::Core
    Qt${QT_VERSION_MAJOR}::Gui
    Qt${QT_VERSION_MAJOR}::Qml
    Qt${QT_VERSION_MAJOR}::Quick
    Qt${QT_VERSION_MAJOR}::Positioning
    Qt${QT_VERSION_MAJOR}::Location
    Qt${QT_VERSION_MAJOR}::Network
    Qt${QT_VERSION_MAJOR}::Multimedia
)
