; MainLoopClass::start_thread() @ 0xda5f0, 612 bytes
000da604  add     r0, pc, r0                     -> 0x12939c "systemctl disable dropbear.socket"
000da608  bl      #0x26070                       system
000da614  add     r0, pc, r0                     -> 0x1293c0 "systemctl stop dropbear.socket"
000da618  bl      #0x26070                       system
000da620  add     r0, pc, r0                     -> 0x1293e0 "ifconfig eth0 down"
000da624  bl      #0x26070                       system
000da628  mov     r0, #0x18
000da62c  bl      #0x25674                       operator new(unsigned int)
000da634  bl      #0xda930                       MainLoopThread::MainLoopThread()
000da63c  mov     r1, #0x10
000da648  add     r0, pc, r0                     -> 0x1293f4 "Main Loop Thread"
000da64c  bl      #0x264cc                       QString::fromAscii_helper(char const*, int)
000da65c  bl      #0x2613c                       QObject::setObjectName(QString const&)
000da668  cmp     r3, #0
000da66c  beq     #0xda7b0
000da674  beq     #0xda6a0
000da688  cmp     r2, #0
000da68c  bne     #0xda67c
000da690  cmp     r3, #0
000da69c  beq     #0xda7b0
000da6a0  bl      #0x7bacc                       read_variant_id()
000da6a4  cmp     r0, #0xb
000da6a8  beq     #0xda6d4
000da6b0  bl      #0x25674                       operator new(unsigned int)
000da6bc  bl      #0x860e0                       UnixWifiModule::UnixWifiModule(unsigned char)
000da6d0  bl      #0x86cf4                       UnixWifiModule::init()
000da700  bl      #0x7baac                       read_product_id()
000da708  bl      #0x7bacc                       read_variant_id()
000da710  movw    r2, #0x150c
000da714  cmp     r3, r2
000da718  beq     #0xda7e4
000da71c  movw    r2, #0x1529
000da720  cmp     r3, r2
000da724  beq     #0xda7c0
000da728  movw    r2, #0x150b
000da72c  cmp     r3, r2
000da730  beq     #0xda78c
000da760  bl      #0x7d48c                       utilities::byte_swap_u32(unsigned int)
000da768  bl      #0x7b588                       on_time::OnTime::run()
000da76c  bl      #0x7ab78                       engine_runtime_info::EngineRuntimeInfo::init()
000da770  bl      #0x9e2b4                       modules::ecu::engine_params::engine_param_init()
000da774  bl      #0x8774c                       io::func::run()
000da780  bl      #0x2598c                       QThread::start(QThread::Priority)
000da78c  movw    r3, #0xd2dc
000da790  movw    r2, #0xf8f8
000da794  movw    r1, #0x3c3b
000da798  movw    ip, #0x337d
000da7ac  b       #0xda744
000da7bc  b       #0xda6a0
000da7c0  movw    r3, #0xe8d8
000da7c4  movw    r2, #0xe551
000da7c8  movw    r1, #0x93f6
000da7cc  movw    ip, #0xe27f
000da7e0  b       #0xda744
000da7e4  movw    r3, #0x5295
000da7e8  movw    r2, #0x5c1a
000da7ec  movw    r1, #0x9c0f
000da7f0  movw    ip, #0x39a5
000da804  b       #0xda744
000da810  bl      #0x255b4                       operator delete(void*, unsigned int)
000da814  bl      #0x25a1c                       __cxa_end_cleanup
000da81c  bl      #0x314b4                       QString::~QString()
000da820  bl      #0x25a1c                       __cxa_end_cleanup
000da828  mov     r1, #0x18
000da82c  bl      #0x255b4                       operator delete(void*, unsigned int)
000da830  bl      #0x25a1c                       __cxa_end_cleanup
; io::func::run() @ 0x8774c, 236 bytes
00087754  bl      #0x9c8c8                       brakes::BrakePedalManager::get_instance()
00087758  bl      #0x9d6ec                       ClutchManager::get_instance()
0008775c  bl      #0xad5c8                       odometer::Odometer::get_instance()
00087760  bl      #0x7333c                       can::can_protocol::run()
00087764  bl      #0x73c80                       DeviceStatusChecker::get_instance()
00087774  bl      #0x73f4c                       DeviceCommandChecker::run()
00087778  bl      #0x8e3e4                       modules::dash::tacho_input::TachoInput::init()
0008777c  bl      #0xaec50                       oil_pressure_switch::OilPressureSwitch::get_instance()
00087780  bl      #0xb3818                       vehicle_speed::VehicleSpeed::get_instance()
00087784  bl      #0xa6890                       io::functions::InputSwitchUpdater::run()
00087788  bl      #0x107efc                      ScreenManager::get_instance()
0008778c  bl      #0x9e56c                       fuel_level::FuelLevel::get_instance()
00087790  bl      #0xa17a8                       io::functions::GearDetection::init()
00087794  bl      #0xb57ac                       CAN_Viewer_Main::init()
00087798  bl      #0xa57d8                       io::functions::Humidity::run()
0008779c  bl      #0x7918c                       ElecLoadManager::get_instance()
000877a0  bl      #0xb0758                       transmission_oil_temperature_switch::TransmissionOilTemperatureSwitch::get_instance()
000877a4  bl      #0xa2f90                       io::functions::UserGenericOutput::run()
000877a8  bl      #0xa2384                       generic_channel::GenChan::run()
000877ac  bl      #0xa3b24                       GenericPIDController::init()
000877b0  bl      #0xa4738                       GenericSwitches::init()
000877b4  bl      #0xa48b8                       generic_timer::GenericTimer::run()
000877b8  bl      #0x9c588                       io::functions::BatteryLightUpdater::run()
000877bc  bl      #0x79438                       io::functions::IndicatorUpdater::run()
000877c0  bl      #0xafd44                       ShockTravel::init()
000877c4  bl      #0xaf994                       RideHeight::init()
000877c8  bl      #0x9d878                       DataLogInput::run()
000877cc  bl      #0xb1c04                       throttle::init()
000877d0  bl      #0xaee0c                       position_pots::PositionPot::init()
000877d4  bl      #0xab2e8                       modules::ecu::light_control::LightControl::init()
000877d8  bl      #0x9bb94                       io::functions::AirCon::get_instance()
000877dc  bl      #0x9c404                       io::functions::AirTemperature::run()
000877e0  bl      #0xabe2c                       io::functions::MassAirFlow::run()
000877e4  bl      #0x9f0ac                       io::functions::fuel_transfer::FuelTransfer::get_instance()
000877e8  bl      #0x875a0                       engine_state::EngineState::get_instance()
000877ec  bl      #0xb1b9c                       io::functions::ThermoFanFactory::get_instance()
000877f0  bl      #0xb3c24                       WindscreenWasher::init()
000877f4  bl      #0xb4d1c                       WindscreenWipers::init()
000877f8  bl      #0xa5b50                       io::functions::IntercoolerSystem::run()
000877fc  bl      #0xa3260                       GenericOpenLoopMotorControl::run()
00087800  bl      #0xb5604                       oil_level::OilLevel::get_instance()
00087804  bl      #0x781d0                       Speedo::init()
00087808  bl      #0x58fa8                       can::CanNetworkSync::get_instance()
0008780c  bl      #0x9e098                       ElectricWaterPump::init()
00087810  bl      #0x789c4                       HourServiceMeter::init()
00087814  bl      #0x76a50                       can::GenericCAN::get_instance()
00087818  bl      #0xadc74                       OutputTests::get_instance()
0008781c  bl      #0x7bacc                       read_variant_id()
00087820  cmp     r0, #0xb
00087824  popeq   {r4, pc}
0008782c  b       #0x7fc40                       modules::dash::camera_input::CameraInput::init()
; ConnectionHandle::start_communication() @ 0xebd78, 132 bytes
000ebd90  movw    r0, #0x8030
000ebd94  bl      #0x25674                       operator new(unsigned int)
000ebd9c  bl      #0x4b90c                       UsbComms::UsbComms()
000ebdb0  bl      #0x7bacc                       read_variant_id()
000ebdb4  cmp     r0, #0xb
000ebdb8  beq     #0xebdd4
000ebdbc  movw    r0, #0x8618
000ebdc0  bl      #0x25674                       operator new(unsigned int)
000ebdc8  bl      #0x4d744                       WifiComms::WifiComms()
000ebde0  movw    r1, #0x8030
000ebde4  bl      #0x255b4                       operator delete(void*, unsigned int)
000ebde8  bl      #0x25a1c                       __cxa_end_cleanup
000ebdf0  movw    r1, #0x8618
000ebdf4  bl      #0x255b4                       operator delete(void*, unsigned int)
000ebdf8  bl      #0x25a1c                       __cxa_end_cleanup
; io::dash_camera::get_chip_status() @ 0x32ccc, 960 bytes
00032cd8  bl      #0x50830                       hardware_id::read_hw_id()
00032ce4  cmp     r0, #0xac00
00032ce8  cmpne   r4, #0xa200
00032cf8  beq     #0x32d0c
00032d30  add     r3, pc, r3                     -> 0x11a8b8 "/dev/i2c-0"
00032d40  add     r2, pc, r2                     -> 0x11a768 "default"
00032d4c  cmp     r3, #4
00032d5c  mov     r7, #0x21
00032d80  movw    ip, #0x4001
00032dc4  bl      #0x25f98                       open
00032dd4  movw    r1, #0x702
00032dd8  bl      #0x264d8                       ioctl
00032ddc  cmp     r0, #0
00032de8  movw    r1, #0x707
00032df0  bl      #0x264d8                       ioctl
00032df4  cmp     r0, #0
00032e00  bl      #0x25650                       close
00032e10  cmp     r2, r5
00032e18  bne     #0x32d70
00032e1c  b       #0x32cfc
00032e24  bl      #0x25650                       close
00032e30  cmp     r2, r5
00032e3c  bne     #0x32d4c
00032e74  bl      #0x25f14                       QMessageLogger::critical() const
00032e80  mov     r2, #0x15
00032e88  add     r1, pc, r1                     -> 0x11a990 "can't open i2c device"
00032e8c  bl      #0x2646c                       QString::fromUtf8_helper(char const*, int)
00032e98  bl      #0x25410                       QTextStream::operator<<(QString const&)
00032ea4  cmp     r3, #0
00032ea8  beq     #0x32edc
00032eb0  beq     #0x32ee8
00032ec4  cmp     r2, #0
00032ec8  bne     #0x32eb8
00032ecc  cmp     r3, #0
00032ed4  bne     #0x32ee8
00032ef0  cmp     r3, #0
00032ef4  bne     #0x32fa0
00032f00  mov     r2, #0xa
00032f08  add     r1, pc, r1                     -> 0x11a8b8 "/dev/i2c-0"
00032f0c  bl      #0x2646c                       QString::fromUtf8_helper(char const*, int)
00032f18  bl      #0x25410                       QTextStream::operator<<(QString const&)
00032f24  cmp     r3, #0
00032f28  beq     #0x32f78
00032f30  beq     #0x32f58
00032f44  cmp     r2, #0
00032f48  bne     #0x32f38
00032f4c  cmp     r3, #0
00032f54  beq     #0x32f74
00032f60  cmp     r3, #0
00032f64  bne     #0x32f94
00032f70  b       #0x32e28
00032f8c  cmp     r3, #0
00032f90  beq     #0x32f68
00032f94  mov     r1, #0x20
00032f98  bl      #0x25ecc                       QTextStream::operator<<(char)
00032f9c  b       #0x32f68
00032fa4  mov     r1, #0x20
00032fa8  bl      #0x25ecc                       QTextStream::operator<<(char)
00032fb0  b       #0x32ef8
00032fbc  cmp     r2, #0
00032fc0  beq     #0x32ffc
00032fc8  beq     #0x32ff0
00032fdc  cmp     r1, #0
00032fe0  bne     #0x32fd0
00032fe4  cmp     r2, #0
00032fec  beq     #0x32ffc
00032ff8  bl      #0x25a1c                       __cxa_end_cleanup
0003300c  b       #0x32ff0
00033018  cmp     r2, #0
0003301c  beq     #0x3304c
00033024  beq     #0x32ff0
00033038  cmp     r1, #0
0003303c  bne     #0x3302c
00033040  cmp     r2, #0
00033048  bne     #0x32ff0
0003305c  b       #0x32ff0
00033060  b       #0x32ff0
; io::dash_camera::capture_camera_test_image() @ 0x3308c, 1544 bytes
00033094  bl      #0x50830                       hardware_id::read_hw_id()
000330a0  cmp     r0, #0xac00
000330a4  cmpne   r2, #0xa200
000330ac  beq     #0x330b8
000330c8  add     r0, pc, r0                     -> 0x11aaa0 "gst-launch-1.0 imxv4l2videosrc device=/dev/video1 ! imxg2dvideotransform ! videocrop left=6 right=2 bottom=4 top=4 ! imxipuvideosink sync=true force-aspect-rati"
000330d0  bl      #0x26070                       system
000330d8  bne     #0x33268
000330f4  add     r2, pc, r2                     -> 0x11a768 "default"
0003310c  bl      #0x259c8                       QMessageLogger::info() const
00033118  mov     r2, #0x20
00033120  add     r1, pc, r1                     -> 0x11a9a8 "Redirecting video chip to screen"
00033124  bl      #0x2646c                       QString::fromUtf8_helper(char const*, int)
00033130  bl      #0x25410                       QTextStream::operator<<(QString const&)
0003313c  cmp     r3, #0
00033140  beq     #0x334b0
00033148  beq     #0x33174
0003315c  cmp     r2, #0
00033160  bne     #0x33150
00033164  cmp     r3, #0
00033170  beq     #0x334b0
0003317c  cmp     r3, #0
00033180  bne     #0x334a4
0003318c  movw    r0, #0x1194
00033190  bl      #0x25efc                       QThread::msleep(unsigned long)
00033198  add     r0, pc, r0                     -> 0x11a9cc "cat /dev/fb0 > /tmp/camera_image.raw"
0003319c  bl      #0x26070                       system
000331a4  beq     #0x33328
000331c0  add     r3, pc, r3                     -> 0x11a768 "default"
000331d0  bl      #0x25f14                       QMessageLogger::critical() const
000331d8  mov     r2, #0x21
000331e4  add     r1, pc, r1                     -> 0x11aa1c "Error capturing camera test image"
000331e8  bl      #0x2646c                       QString::fromUtf8_helper(char const*, int)
000331f4  bl      #0x25410                       QTextStream::operator<<(QString const&)
00033200  cmp     r3, #0
00033204  beq     #0x33238
0003320c  beq     #0x33244
00033220  cmp     r2, #0
00033224  bne     #0x33214
00033228  cmp     r3, #0
00033234  bne     #0x33244
0003324c  cmp     r3, #0
00033250  bne     #0x33520
00033264  b       #0x330b0
00033280  add     r3, pc, r3                     -> 0x11a768 "default"
00033298  bl      #0x25f14                       QMessageLogger::critical() const
000332a4  mov     r2, #0x26
000332ac  add     r1, pc, r1                     -> 0x11a9f4 "Error redirecting video chip to screen"
000332b0  bl      #0x2646c                       QString::fromUtf8_helper(char const*, int)
000332bc  bl      #0x25410                       QTextStream::operator<<(QString const&)
000332c8  cmp     r3, #0
000332cc  beq     #0x334c0
000332d4  beq     #0x33300
000332e8  cmp     r2, #0
000332ec  bne     #0x332dc
000332f0  cmp     r3, #0
000332fc  beq     #0x334c0
00033308  cmp     r3, #0
0003330c  bne     #0x33514
00033328  bl      #0x320d0                       io::dash_camera::convert_RGB565_to_BMP()
00033340  add     r3, pc, r3                     -> 0x11a768 "default"
00033350  bl      #0x259c8                       QMessageLogger::info() const
00033358  mov     r2, #0x1a
00033364  add     r1, pc, r1                     -> 0x11aa40 "Captured camera test image"
00033368  bl      #0x2646c                       QString::fromUtf8_helper(char const*, int)
00033374  bl      #0x25410                       QTextStream::operator<<(QString const&)
00033380  cmp     r3, #0
00033384  beq     #0x333b8
0003338c  beq     #0x333c4
000333a0  cmp     r2, #0
000333a4  bne     #0x33394
000333a8  cmp     r3, #0
000333b4  bne     #0x333c4
000333cc  cmp     r3, #0
000333d0  bne     #0x3352c
000333e8  add     r0, pc, r0                     -> 0x11aa5c "pkill -e gst-launch-1.0"
000333ec  bl      #0x26070                       system
000333f0  cmp     r0, #0
000333f4  beq     #0x330b0
00033410  add     r3, pc, r3                     -> 0x11a768 "default"
00033420  bl      #0x257b8                       QMessageLogger::warning() const
00033428  mov     r2, #0x2b
00033434  add     r1, pc, r1                     -> 0x11aa74 "Failed to terminate process: gst-launch-1.0"
00033438  bl      #0x2646c                       QString::fromUtf8_helper(char const*, int)
00033444  bl      #0x25410                       QTextStream::operator<<(QString const&)
00033450  cmp     r3, #0
00033454  beq     #0x33544
0003345c  beq     #0x33488
00033470  cmp     r2, #0
00033474  bne     #0x33464
00033478  cmp     r3, #0
00033484  beq     #0x33544
00033490  cmp     r3, #0
00033494  bne     #0x33538
000334a0  b       #0x330b0
000334a4  mov     r1, #0x20
000334a8  bl      #0x25ecc                       QTextStream::operator<<(char)
000334ac  b       #0x33184
000334bc  b       #0x33174
000334cc  b       #0x33300
00033514  mov     r1, #0x20
00033518  bl      #0x25ecc                       QTextStream::operator<<(char)
0003351c  b       #0x33310
00033520  mov     r1, #0x20
00033524  bl      #0x25ecc                       QTextStream::operator<<(char)
00033528  b       #0x33254
0003352c  mov     r1, #0x20
00033530  bl      #0x25ecc                       QTextStream::operator<<(char)
00033534  b       #0x333d4
00033538  mov     r1, #0x20
0003353c  bl      #0x25ecc                       QTextStream::operator<<(char)
00033540  b       #0x33498
00033550  b       #0x33488
0003355c  cmp     r2, #0
00033560  beq     #0x3359c
00033568  beq     #0x33590
0003357c  cmp     r1, #0
00033580  bne     #0x33570
00033584  cmp     r2, #0
0003358c  beq     #0x3359c
00033598  bl      #0x25a1c                       __cxa_end_cleanup
000335ac  b       #0x33590
000335b0  b       #0x33590
000335b4  b       #0x33590
000335c0  cmp     r2, #0
000335c4  beq     #0x3359c
000335cc  beq     #0x33590
000335e0  cmp     r1, #0
000335e4  beq     #0x33584
000335e8  b       #0x335d4
000335f4  cmp     r2, #0
000335f8  beq     #0x3359c
00033600  beq     #0x33590
00033614  cmp     r1, #0
00033618  beq     #0x33584
0003361c  b       #0x33608
00033620  b       #0x33590
0003362c  cmp     r2, #0
00033630  beq     #0x3359c
00033638  beq     #0x33590
0003364c  cmp     r1, #0
00033650  beq     #0x33584
00033654  b       #0x33640
00033658  b       #0x33590
00033664  cmp     r2, #0
00033668  beq     #0x3359c
00033670  beq     #0x33590
00033684  cmp     r1, #0
00033688  beq     #0x33584
0003368c  b       #0x33678
00033690  b       #0x33590
; io::internal::ALS::read_hardware() @ 0x3f1f4, 188 bytes
0003f1fc  bl      #0x7bacc                       read_variant_id()
0003f200  cmp     r0, #0xb
0003f208  beq     #0x3f264
0003f210  mov     r5, #0x80000013
0003f21c  cmp     r3, #0
0003f220  beq     #0x3f254
0003f234  bl      #0x3b478                       io::internal::calibrated_in_read(io::PinDesc)
0003f240  cmp     r2, #0x80000000
0003f244  cmpne   r0, r5
0003f24c  cmp     r3, r4
0003f270  cmp     r2, #0
0003f27c  cmp     r2, #0
0003f288  cmp     r2, #0
0003f294  cmp     r3, #0
0003f29c  b       #0x3f20c
; io::ambient_light_io::ProcessAmbientLight::reset_als(unsigned char) @ 0x319e0, 256 bytes
000319f4  bl      #0x26004                       QMutex::lock()
000319fc  cmp     r6, #1
00031a10  mov     r0, #0x52
00031a3c  beq     #0x31aa4
00031a44  add     r0, pc, r0                     -> 0x11a8c4 "/dev/i2c-2"
00031a4c  bl      #0x25f98                       open
00031a58  mov     r2, #0x52
00031a5c  movw    r1, #0x703
00031a60  bl      #0x264d8                       ioctl
00031a64  cmp     r0, #0
00031a6c  beq     #0x31ab0
00031a74  bl      #0x25650                       close
00031a7c  mov     r0, #0xa
00031a80  bl      #0x25efc                       QThread::msleep(unsigned long)
00031a88  bl      #0x2562c                       QMutex::unlock()
00031aa0  b       #0x31a7c
00031aa8  add     r0, pc, r0                     -> 0x11a8b8 "/dev/i2c-0"
00031aac  b       #0x31a48
00031ab4  movw    r1, #0x707
00031abc  bl      #0x264d8                       ioctl
00031ac8  b       #0x31a70
00031ad0  bl      #0x2562c                       QMutex::unlock()
00031ad4  bl      #0x25a1c                       __cxa_end_cleanup
; ui_module::UIMain::handle_take_screenshot() @ 0x115f80, 4 bytes
; ui_module::UIScreen::take_screenshot() @ 0x1190f8, 4 bytes
