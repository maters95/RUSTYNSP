; alarm_module::Alarm_Module::draw_alarms() @ 0xf2b94, 6032 bytes
000f2bd8  add     r4, pc, r4                     -> 0x12a838 " { "text":""
000f2bdc  add     r5, pc, r5                     -> 0x12a844 "								"
000f2c88  bl      #0x25d88                       strncmp
000f2c9c  bl      #0x25434                       strnlen
000f2cac  bl      #0x25818                       strlen
000f2d4c  bl      #0xf2364                       alarm_module::Alarm_Module::compute_color_string(unsigned int)
000f2d60  add     r1, pc, r1                     -> 0x12a850 "", "bc": ""
000f2e0c  bl      #0x25d10                       QString::number(int, int)
000f2e20  add     r1, pc, r1                     -> 0x12a85c "", "height": ""
000f2ee0  add     r1, pc, r1                     -> 0x12a86c "", "img": ""
000f2f98  bl      #0xf2364                       alarm_module::Alarm_Module::compute_color_string(unsigned int)
000f2fac  add     r1, pc, r1                     -> 0x12a878 "", "fc": ""
000f3008  add     r1, pc, r1                     -> 0x12a884 "" }"
000f312c  bl      #0x31908                       QList<QString>::append(QString const&)
000f31b8  bl      #0xf2924                       alarm_module::LedManager::update_leds(int, unsigned char, bool)
000f32bc  bl      #0x25680                       strncpy
000f32c8  bl      #0x25434                       strnlen
000f32d8  bl      #0x25818                       strlen
000f33b8  bl      #0x25cc8                       QListData::detach(int)
000f3590  bl      #0x253c8                       QListData::dispose(QListData::Data*)
000f35e4  add     r3, pc, r3                     -> 0x12a838 " { "text":""
000f35f0  add     r3, pc, r3                     -> 0x12a850 "", "bc": ""
000f36a0  add     r1, pc, r1                     -> 0x12a878 "", "fc": ""
000f370c  bl      #0x25500                       QString::number(unsigned int, int)
000f3720  add     r1, pc, r1                     -> 0x12a85c "", "height": ""
000f37cc  add     r1, pc, r1                     -> 0x12a86c "", "img": ""
000f3824  add     r1, pc, r1                     -> 0x12a884 "" }"
000f395c  bl      #0xf2924                       alarm_module::LedManager::update_leds(int, unsigned char, bool)
000f3a60  bl      #0x26400                       QMapNodeBase::nextNode() const
000f3dac  bl      #0x253e0                       QVariant::QVariant(QString const&)
000f3e3c  add     ip, pc, ip                     -> 0x12a890 "QVariant"
000f3ef8  add     r1, pc, r1                     -> 0x12a89c "reInitAlarmScreen"
000f3efc  bl      #0x2589c                       QMetaObject::invokeMethod(QObject*, char const*, Qt::ConnectionType, QGenericReturnArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument)
000f3f08  mov     r1, #0x63
000f3f14  bl      #0x26454                       QVariant::QVariant(int)
000f3f28  bl      #0x252f0                       QObject::setProperty(char const*, QVariant const&)
000f4094  bl      #0x253c8                       QListData::dispose(QListData::Data*)
000f40e4  vldr    d16, [pc, #0x22c]
000f40f4  add     r3, pc, r3                     -> 0x11a768 "default"
000f4108  bl      #0x25f14                       QMessageLogger::critical() const
000f411c  add     r1, pc, r1                     -> 0x12a804 "alarms could not update, the parent display is null"
000f41b0  bl      #0x25a1c                       __cxa_end_cleanup
000f41e0  bl      #0x25a1c                       __cxa_end_cleanup
000f41fc  bl      #0x6aa00                       alarm_module::InternalAlarm::~InternalAlarm()
; alarm_module::Alarm_Module::Alarm_Module(QQuickView*, QQmlEngine*) @ 0xf4604, 2408 bytes
000f463c  bl      #0x7b178                       utilities::LongPress::LongPress(unsigned short, bool)
000f46ec  add     r0, pc, r0                     -> 0x12a8b4 "/opt/applications/dtn/resources/qml_components_data/qml"
000f4738  add     r1, pc, r1                     -> 0x12a8ec "/user_components/HalAlarmPopup.qml"
000f47b0  bl      #0x26064                       QString::compare_helper(QChar const*, int, char const*, int, Qt::CaseSensitivity)
000f47c4  vldr    d16, [pc, #0x17c]
000f47d4  add     r3, pc, r3                     -> 0x11a768 "default"
000f47e8  bl      #0x25f14                       QMessageLogger::critical() const
000f4800  add     r1, pc, r1                     -> 0x12a910 "Could not find qml file for alarms in path"
000f4984  bl      #0x25ae8                       QFile::exists(QString const&)
000f49a0  bl      #0x263b8                       QUrl::QUrl(QString const&, QUrl::ParsingMode)
000f49a8  bl      #0x25674                       operator new(unsigned int)
000f49bc  bl      #0x26274                       QQmlComponent::QQmlComponent(QQmlEngine*, QUrl const&, QObject*)
000f49ec  bl      #0x25d70                       QMetaObject::cast(QObject*) const
000f49f8  bl      #0x25290                       QQmlEngine::setObjectOwnership(QObject*, QQmlEngine::ObjectOwnership)
000f4a04  bl      #0x254d0                       QQuickView::rootObject() const
000f4a10  bl      #0x26304                       QQuickItem::setParentItem(QQuickItem*)
000f4a3c  bl      #0x7bacc                       read_variant_id()
000f4a50  bl      #0x26454                       QVariant::QVariant(int)
000f4ab0  add     ip, pc, ip                     -> 0x12a890 "QVariant"
000f4b6c  add     r1, pc, r1                     -> 0x12a97c "setDashVariant"
000f4b70  bl      #0x2589c                       QMetaObject::invokeMethod(QObject*, char const*, Qt::ConnectionType, QGenericReturnArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument)
000f4b80  bl      #0xf2178                       alarm_module::Alarm_Module::check_for_setting_changes()
000f4c60  vldr    d16, [pc, #0x2f0]
000f4c70  add     r3, pc, r3                     -> 0x11a768 "default"
000f4c84  bl      #0x25f14                       QMessageLogger::critical() const
000f4c9c  add     r1, pc, r1                     -> 0x12a93c "Failed to create qml object of type alarm"
000f4d10  vldr    d16, [pc, #0x240]
000f4d20  add     r3, pc, r3                     -> 0x11a768 "default"
000f4d30  bl      #0x25f14                       QMessageLogger::critical() const
000f4d48  add     r1, pc, r1                     -> 0x12a968 "Error string is:"
000f4db4  bl      #0x2571c                       QQmlComponent::errorString() const
000f4ed8  bl      #0x25a1c                       __cxa_end_cleanup
000f4ee0  bl      #0xf8000                       QMapData<unsigned int, alarm_module::InternalAlarm>::destroy()
000f4f50  bl      #0x255b4                       operator delete(void*, unsigned int)
; ui_module::UIMain::UIMain(QObject*) @ 0x116f98, 3404 bytes
00116fc4  bl      #0x262f8                       QObject::QObject(QObject*)
00117000  bl      #0x25674                       operator new(unsigned int)
00117008  vldr    d16, [pc, #0x3e0]
00117018  bl      #0x25674                       operator new(unsigned int)
00117020  vldr    d16, [pc, #0x3d0]
00117030  bl      #0x25674                       operator new(unsigned int)
00117038  vldr    d16, [pc, #0x3c0]
001170dc  add     r0, pc, r0                     -> 0x12a8b4 "/opt/applications/dtn/resources/qml_components_data/qml"
001170f0  bl      #0x509d0                       ident_load_serial_num()
00117104  vldr    d16, [pc, #0x2fc]
00117114  add     r3, pc, r3                     -> 0x11a768 "default"
00117124  bl      #0x25f14                       QMessageLogger::critical() const
0011713c  add     r1, pc, r1                     -> 0x12a7c8 "No Serial Number found"
001171a8  bl      #0x518b4                       read_processor_uid()
001171ac  bl      #0x7bacc                       read_variant_id()
001171b8  bl      #0x259d4                       QQuickWindow::setDefaultAlphaBuffer(bool)
001171c0  bl      #0x25674                       operator new(unsigned int)
001171cc  bl      #0x25764                       QQuickView::QQuickView(QWindow*)
00117218  add     r1, pc, r1                     -> 0x12e56c "/factory_screens/main.qml"
00117280  bl      #0x263b8                       QUrl::QUrl(QString const&, QUrl::ParsingMode)
0011728c  bl      #0x260ac                       QQuickView::setSource(QUrl const&)
001172f0  add     r3, pc, r3                     -> 0x12e540 "#00000000"
00117308  bl      #0x260e8                       QColor::setNamedColor(QLatin1String)
00117314  bl      #0x25b3c                       QQuickWindow::setColor(QColor const&)
00117340  vldr    d16, [pc, #0xc0]
00117350  add     r3, pc, r3                     -> 0x11a768 "default"
00117368  bl      #0x25f14                       QMessageLogger::critical() const
00117380  add     r1, pc, r1                     -> 0x12e494 "Could not get variant id and set screen size, defaulting to ic7 size"
00117468  bl      #0xfaf88                       peak_handler_init()
00117474  bl      #0x25854                       QWindow::setMinimumSize(QSize const&)
00117480  bl      #0x25560                       QWindow::setWidth(int)
0011748c  bl      #0x25e6c                       QWindow::setHeight(int)
001174bc  bl      #0x254d0                       QQuickView::rootObject() const
001174d8  bl      #0x26454                       QVariant::QVariant(int)
001174e8  bl      #0x26454                       QVariant::QVariant(int)
00117570  add     ip, pc, ip                     -> 0x12a890 "QVariant"
00117650  add     r1, pc, r1                     -> 0x12e588 "setScreenSize"
00117654  bl      #0x2589c                       QMetaObject::invokeMethod(QObject*, char const*, Qt::ConnectionType, QGenericReturnArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument)
00117678  bl      #0x261d8                       QVariant::QVariant(unsigned int)
00117680  bl      #0x254d0                       QQuickView::rootObject() const
001176c8  add     lr, pc, lr                     -> 0x12a890 "QVariant"
0011779c  add     r1, pc, r1                     -> 0x12a97c "setDashVariant"
001177a0  bl      #0x2589c                       QMetaObject::invokeMethod(QObject*, char const*, Qt::ConnectionType, QGenericReturnArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument, QGenericArgument)
001177b0  bl      #0x25368                       QWindow::show()
00117850  bl      #0x25674                       operator new(unsigned int)
00117874  bl      #0x118840                      ui_module::UIScreen::UIScreen(data_manager::settings::SETTING_REGULAR_STRUCT::DASH_STRUCT::SCREEN_STRUCT volatile*, QQuickView*, bool, unsigned int)
00117890  bl      #0x117f20                      ui_module::UIScreen::set_visibility(bool)
001178a8  bl      #0x25e90                       QQuickView::engine() const
001178b4  bl      #0x25674                       operator new(unsigned int)
001178c4  bl      #0xf4604                       alarm_module::Alarm_Module::Alarm_Module(QQuickView*, QQmlEngine*)
001178dc  add     r0, pc, r0                     -> 0x12e540 "#00000000"
001178ec  bl      #0x50830                       hardware_id::read_hw_id()
00117908  add     r1, pc, r1                     -> 0x12e598 "#08001000"
00117994  bl      #0x115cbc                      ui_module::UIMain::set_fg_tint_colour(QString)
001179dc  bl      #0x116afc                      ui_module::UIMain::update()
00117c10  bl      #0x25a1c                       __cxa_end_cleanup
00117c1c  bl      #0x255b4                       operator delete(void*, unsigned int)
00117c34  bl      #0x255b4                       operator delete(void*, unsigned int)
00117cc0  bl      #0x255b4                       operator delete(void*, unsigned int)
; ui_module::UIScreen::UIScreen(data_manager::settings::SETTING_REGULAR_STRUCT::DASH_STRUCT::SCREEN_STRUCT volatile*, QQuickView*, bool, unsigned int) @ 0x118840, 1452 bytes
00118864  bl      #0x262f8                       QObject::QObject(QObject*)
00118888  bl      #0x259e0                       memset
001188a0  add     r0, pc, r0                     -> 0x12e614 "./screen_thumbnails"
001188d8  bl      #0x25674                       operator new(unsigned int)
001188e4  bl      #0x254e8                       QQuickItem::QQuickItem(QQuickItem*)
001188f0  bl      #0x254d0                       QQuickView::rootObject() const
001188fc  bl      #0x26304                       QQuickItem::setParentItem(QQuickItem*)
0011890c  bl      #0x26478                       QWindow::geometry() const
0011892c  bl      #0x26478                       QWindow::geometry() const
00118960  bl      #0x25740                       QQuickItem::setSize(QSizeF const&)
00118970  bl      #0x25308                       QDir::QDir(QString const&)
00118978  bl      #0x25878                       QDir::exists() const
001189a0  bl      #0x25308                       QDir::QDir(QString const&)
001189ac  bl      #0x25770                       QDir::mkdir(QString const&) const
00118a3c  add     r1, pc, r1                     -> 0x12e628 "/screen"
00118aa4  bl      #0x25500                       QString::number(unsigned int, int)
00118b30  add     r1, pc, r1                     -> 0x12e630 ".png"
00118b90  bl      #0x25c14                       QString::operator=(QString const&)
00118ce8  bl      #0x118804                      ui_module::UIScreen::reload_all_components()
00118d5c  bl      #0x25a1c                       __cxa_end_cleanup
00118db4  bl      #0x255b4                       operator delete(void*, unsigned int)
