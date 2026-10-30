; Excerpts from the decrypted v2.36 nic-7 application used by HalAlarmPopup's per-screen rules.
; Regenerate with scripts/disassemble-nsp-app.py; see ALERTS-TEST.md.

; decrypted ELF sha256 d86bde81820b8b7b5efcfc7466aa994cabeacac6c6bcd725536393ab48687248
; ui_module::UIScreen::set_visibility(bool) @ 0x117f20, 16 bytes
00117f20  ldr     r0, [r0, #0x10]
00117f24  cmp     r0, #0
00117f28  bxeq    lr
00117f2c  b       #0x252cc                     QQuickItem::setVisible(bool)
; ui_module::UIMain::handle_screen_change() @ 0x116a14, 232 bytes
00116a14  ldr     r3, [pc, #0xd0]
00116a18  ldr     r1, [pc, #0xd0]
00116a1c  push    {r4, r5, r6, r7, r8, lr}
00116a20  add     r3, pc, r3
00116a24  ldr     r2, [pc, #0xc8]
00116a28  ldr     r1, [r3, r1]
00116a2c  ldr     r2, [r3, r2]
00116a30  ldrb    r1, [r1]
00116a34  add     r2, r2, #0x5000
00116a38  ldr     r6, [r2, #0x7e4]
00116a3c  cmp     r1, #0
00116a40  bne     #0x116ad0
00116a44  ldr     ip, [pc, #0xac]
00116a48  ldr     r8, [r3, ip]
00116a4c  ldrsb   r3, [r8]
00116a50  cmp     r6, r3
00116a54  beq     #0x116ad0
00116a58  cmp     r6, #5
00116a5c  movgt   r6, r1
00116a60  strgt   r1, [r2, #0x7e4]
00116a64  add     r5, r0, r6, lsl #2
00116a68  ldr     r3, [r5, #0x14]
00116a6c  cmp     r3, #0
00116a70  beq     #0x116ad0
00116a74  mov     r4, r0
00116a78  mov     r0, r3
00116a7c  bl      #0x118dec                    ui_module::UIScreen::has_loaded()
00116a80  subs    r7, r0, #0
00116a84  beq     #0x116adc
00116a88  ldrsb   r7, [r8]
00116a8c  add     r4, r4, #0x14
00116a90  mov     r5, #0
00116a94  strb    r6, [r8]
00116a98  subs    r7, r7, r6
00116a9c  movne   r7, #1
00116aa0  ldr     r0, [r4], #4
00116aa4  cmp     r0, #0
00116aa8  beq     #0x116abc
00116aac  sub     r1, r6, r5
00116ab0  clz     r1, r1
00116ab4  lsr     r1, r1, #5
00116ab8  bl      #0x117f20                    ui_module::UIScreen::set_visibility(bool)
00116abc  add     r5, r5, #1
00116ac0  cmp     r5, #5
00116ac4  bne     #0x116aa0
00116ac8  mov     r0, r7
00116acc  pop     {r4, r5, r6, r7, r8, pc}
00116ad0  mov     r7, #0
00116ad4  mov     r0, r7
00116ad8  pop     {r4, r5, r6, r7, r8, pc}
00116adc  ldr     r0, [r5, #0x14]
00116ae0  bl      #0x118804                    ui_module::UIScreen::reload_all_components()
00116ae4  mov     r0, r7
00116ae8  pop     {r4, r5, r6, r7, r8, pc}
00116aec  andeq   r8, fp, r4, asr pc
00116af0  andeq   r0, r0, ip, lsr ip
00116af4  andeq   r1, r0, ip, lsr r1
00116af8  andeq   r1, r0, r0, lsr #1

; UIMain constructor: screen-creation loop (five screens, stride 0xab08), then Alarm_Module
; ui_module::UIMain::UIMain(QObject*) @ 0x116f98, 3404 bytes
00117834  ldr     r3, [sp, #0x60]
00117838  mov     r4, #0
0011783c  ldr     sb, [sp, #0x80]
00117840  movw    fp, #0xab08
00117844  add     r6, r3, #0x9700
00117848  add     r6, r6, #0x40
0011784c  mov     r0, #0x24c
00117850  bl      #0x25674                     operator new(unsigned int)
00117854  ldrsb   ip, [r8]
00117858  sxtb    r3, r4
0011785c  ldr     r2, [r5, #0x10]
00117860  mov     r1, r6
00117864  str     r4, [sp]
00117868  mov     r7, r0
0011786c  subs    r3, ip, r3
00117870  movne   r3, #1
00117874  bl      #0x118840                    ui_module::UIScreen::UIScreen(data_manager::settings::SETTING_REGULAR_STRUCT::DASH_STRUCT::SCREEN_STRUCT volatile*, QQuickView*, bool, unsigned int)
00117878  str     r7, [sb], #4
0011787c  mov     r0, r7
00117880  ldrsb   r1, [r8]
00117884  sub     r1, r1, r4
00117888  clz     r1, r1
0011788c  lsr     r1, r1, #5
00117890  bl      #0x117f20                    ui_module::UIScreen::set_visibility(bool)
00117894  add     r4, r4, #1
00117898  add     r6, r6, fp
0011789c  cmp     r4, #5
001178a0  bne     #0x11784c
001178a4  ldr     r0, [r5, #0x10]
001178a8  bl      #0x25e90                     QQuickView::engine() const
001178ac  mov     r6, r0
001178b0  movw    r0, #0x8e4
001178b4  bl      #0x25674                     operator new(unsigned int)
001178b8  mov     r2, r6
001178bc  ldr     r1, [r5, #0x10]
001178c0  mov     r4, r0
001178c4  bl      #0xf4604                     alarm_module::Alarm_Module::Alarm_Module(QQuickView*, QQmlEngine*)

; Root parenting in the UIScreen and Alarm_Module constructors (calls only)
; decrypted ELF sha256 d86bde81820b8b7b5efcfc7466aa994cabeacac6c6bcd725536393ab48687248
; ui_module::UIScreen::UIScreen(data_manager::settings::SETTING_REGULAR_STRUCT::DASH_STRUCT::SCREEN_STRUCT volatile*, QQuickView*, bool, unsigned int) @ 0x118840, 1452 bytes
001188e4  bl      #0x254e8                     QQuickItem::QQuickItem(QQuickItem*)
001188f0  bl      #0x254d0                     QQuickView::rootObject() const
001188fc  bl      #0x26304                     QQuickItem::setParentItem(QQuickItem*)
00118960  bl      #0x25740                     QQuickItem::setSize(QSizeF const&)
; alarm_module::Alarm_Module::Alarm_Module(QQuickView*, QQmlEngine*) @ 0xf4604, 2408 bytes
000f49bc  bl      #0x26274                     QQmlComponent::QQmlComponent(QQmlEngine*, QUrl const&, QObject*)
000f4a04  bl      #0x254d0                     QQuickView::rootObject() const
000f4a10  bl      #0x26304                     QQuickItem::setParentItem(QQuickItem*)

; UIScreen::reload_component passes the screen container ([this+0x10], the item set_visibility
; toggles) as each UIComponent's QQuickItem parent, so gauges never sit between screens and the popup.
001185b4  ldr     r3, [r5, #0x10]
001185c8  bl      #0x10f504                    ui_module::UIComponent::UIComponent(data_manager::settings::SETTING_REGULAR_STRUCT::DASH_STRUCT::SCREEN_STRUCT volatile*, data_manager::settings::SETTING_REGULAR_STRUCT::DASH_STRUCT::SCREEN_STRUCT::COMP_STRUCT volatile*, QQuickItem*, QQmlEngine*, unsigned int, unsigned int)
