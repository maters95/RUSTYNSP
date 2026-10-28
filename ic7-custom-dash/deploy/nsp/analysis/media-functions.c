// QQmlComponent @ 0001e260

void __thiscall
QQmlComponent::QQmlComponent(QQmlComponent *this,QQmlEngine *param_1,QUrl *param_2,QObject *param_3)

{
  (*(code *)PTR_QQmlComponent_0015b7ec)(this);
  return;
}



// capture_camera_test_image @ 00024300

/* io::dash_camera::capture_camera_test_image() */

void io::dash_camera::capture_camera_test_image(void)

{
  bool bVar1;
  QTextStream *pQVar2;
  int iVar3;
  char *__command;
  undefined4 *puVar4;
  QTextStream *local_34;
  QArrayData *local_30;
  undefined4 local_2c;
  int local_28;
  int local_24;
  int local_20;
  int local_1c;
  
  iVar3 = hardware_id::read_hw_id();
  if (iVar3 != 0xac00) {
    return;
  }
  puVar4 = *(undefined4 **)(DAT_000247bc + 0x2431c + DAT_000247c0);
  __command = (char *)(DAT_000247c4 + 0x2433c);
  *puVar4 = 2;
  local_28 = system(__command);
  if (local_28 != 0) {
    local_2c = 2;
    local_1c = DAT_000247e8 + 0x245b8;
    local_28 = 0;
    local_24 = 0;
    local_20 = 0;
    QMessageLogger::critical();
    pQVar2 = local_34;
    QString::fromUtf8_helper((char *)&local_30,DAT_000247ec + 0x245e4);
    QTextStream::operator<<(pQVar2,(QString *)&local_30);
    if (*(int *)local_30 != 0) {
      if (*(int *)local_30 == -1) goto LAB_0002463c;
      DataMemoryBarrier(0xb);
      do {
        iVar3 = *(int *)local_30;
        bVar1 = (bool)hasExclusiveAccess(local_30);
      } while (!bVar1);
      *(int *)local_30 = iVar3 + -1;
      DataMemoryBarrier(0xb);
      if (iVar3 + -1 != 0) goto LAB_0002463c;
    }
    QArrayData::deallocate(local_30,2,4);
LAB_0002463c:
    if (local_34[0x14] != (QTextStream)0x0) {
      QTextStream::operator<<(local_34,' ');
    }
    QDebug::~QDebug((QDebug *)&local_34);
    *puVar4 = 4;
    return;
  }
  local_2c = 2;
  local_1c = DAT_000247c8 + 0x24368;
  local_24 = local_28;
  local_20 = local_28;
  QMessageLogger::info();
  pQVar2 = local_34;
  QString::fromUtf8_helper((char *)&local_30,DAT_000247cc + 0x24394);
  QTextStream::operator<<(pQVar2,(QString *)&local_30);
  if (*(int *)local_30 == 0) {
LAB_000243e0:
    QArrayData::deallocate(local_30,2,4);
  }
  else if (*(int *)local_30 != -1) {
    DataMemoryBarrier(0xb);
    do {
      iVar3 = *(int *)local_30;
      bVar1 = (bool)hasExclusiveAccess(local_30);
    } while (!bVar1);
    *(int *)local_30 = iVar3 + -1;
    DataMemoryBarrier(0xb);
    if (iVar3 + -1 == 0) goto LAB_000243e0;
  }
  if (local_34[0x14] != (QTextStream)0x0) {
    QTextStream::operator<<(local_34,' ');
  }
  QDebug::~QDebug((QDebug *)&local_34);
  QThread::msleep(0x1194);
  iVar3 = system((char *)(DAT_000247d0 + 0x24418));
  if (iVar3 != 0) {
    local_2c = 2;
    local_1c = DAT_000247f0 + 0x24680;
    local_28 = 0;
    local_24 = 0;
    local_20 = 0;
    QMessageLogger::critical();
    pQVar2 = local_34;
    QString::fromUtf8_helper((char *)&local_30,DAT_000247f4 + 0x246a8);
    QTextStream::operator<<(pQVar2,(QString *)&local_30);
    if (*(int *)local_30 != 0) {
      if (*(int *)local_30 == -1) goto LAB_000246f4;
      DataMemoryBarrier(0xb);
      do {
        iVar3 = *(int *)local_30;
        bVar1 = (bool)hasExclusiveAccess(local_30);
      } while (!bVar1);
      *(int *)local_30 = iVar3 + -1;
      DataMemoryBarrier(0xb);
      if (iVar3 + -1 != 0) goto LAB_000246f4;
    }
    QArrayData::deallocate(local_30,2,4);
LAB_000246f4:
    if (local_34[0x14] != (QTextStream)0x0) {
      QTextStream::operator<<(local_34,' ');
    }
    QDebug::~QDebug((QDebug *)&local_34);
    *puVar4 = 5;
    return;
  }
  convert_RGB565_to_BMP();
  local_1c = DAT_000247d4 + 0x24440;
  local_2c = 2;
  local_28 = iVar3;
  local_24 = iVar3;
  local_20 = iVar3;
  QMessageLogger::info();
  pQVar2 = local_34;
  QString::fromUtf8_helper((char *)&local_30,DAT_000247d8 + 0x24468);
  QTextStream::operator<<(pQVar2,(QString *)&local_30);
  if (*(int *)local_30 == 0) {
LAB_0002473c:
    QArrayData::deallocate(local_30,2,4);
  }
  else if (*(int *)local_30 != -1) {
    DataMemoryBarrier(0xb);
    do {
      iVar3 = *(int *)local_30;
      bVar1 = (bool)hasExclusiveAccess(local_30);
    } while (!bVar1);
    *(int *)local_30 = iVar3 + -1;
    DataMemoryBarrier(0xb);
    if (iVar3 + -1 == 0) goto LAB_0002473c;
  }
  if (local_34[0x14] != (QTextStream)0x0) {
    QTextStream::operator<<(local_34,' ');
  }
  QDebug::~QDebug((QDebug *)&local_34);
  iVar3 = DAT_000247dc;
  *puVar4 = 3;
  iVar3 = system((char *)(iVar3 + 0x244e0));
  if (iVar3 == 0) {
    return;
  }
  local_2c = 2;
  local_1c = DAT_000247e0 + 0x24508;
  local_28 = 0;
  local_24 = 0;
  local_20 = 0;
  QMessageLogger::warning();
  pQVar2 = local_34;
  QString::fromUtf8_helper((char *)&local_30,DAT_000247e4 + 0x24530);
  QTextStream::operator<<(pQVar2,(QString *)&local_30);
  if (*(int *)local_30 != 0) {
    if (*(int *)local_30 == -1) goto LAB_0002457c;
    DataMemoryBarrier(0xb);
    do {
      iVar3 = *(int *)local_30;
      bVar1 = (bool)hasExclusiveAccess(local_30);
    } while (!bVar1);
    *(int *)local_30 = iVar3 + -1;
    DataMemoryBarrier(0xb);
    if (iVar3 + -1 != 0) goto LAB_0002457c;
  }
  QArrayData::deallocate(local_30,2,4);
LAB_0002457c:
  if (local_34[0x14] != (QTextStream)0x0) {
    QTextStream::operator<<(local_34,' ');
  }
  QDebug::~QDebug((QDebug *)&local_34);
  return;
}



// read_camera_test_image @ 000247f8

/* io::dash_camera::read_camera_test_image(void*, unsigned int, unsigned int) */

undefined4 io::dash_camera::read_camera_test_image(void *param_1,uint param_2,uint param_3)

{
  bool bVar1;
  int iVar2;
  QTextStream *pQVar3;
  QArrayData *this;
  int iVar4;
  FILE *__stream;
  FILE *pFVar5;
  size_t sVar6;
  undefined4 uVar7;
  uint __n;
  QDebug *local_4c;
  QTextStream *local_48;
  QTextStream *local_44;
  QArrayData *local_40;
  QArrayData *local_3c;
  undefined4 local_38;
  undefined4 local_34;
  FILE *local_30;
  FILE *local_2c;
  FILE *local_28;
  int local_24;
  
  iVar2 = DAT_00024d8c;
  iVar4 = hardware_id::read_hw_id();
  if (iVar4 != 0xac00) {
    return 0;
  }
  if (0x1c203e < param_2 + param_3) {
    local_24 = DAT_00024dac + 0x24ac4;
    local_34 = 2;
    local_30 = (FILE *)0x0;
    local_2c = (FILE *)0x0;
    local_28 = (FILE *)0x0;
    QMessageLogger::warning();
    this = local_40;
    QString::fromUtf8_helper((char *)&local_3c,DAT_00024db0 + 0x24af8);
    QTextStream::operator<<((QTextStream *)this,(QString *)&local_3c);
    if (*(int *)local_3c == 0) {
LAB_00024b44:
      QArrayData::deallocate(local_3c,2,4);
    }
    else if (*(int *)local_3c != -1) {
      DataMemoryBarrier(0xb);
      do {
        iVar4 = *(int *)local_3c;
        bVar1 = (bool)hasExclusiveAccess(local_3c);
      } while (!bVar1);
      *(int *)local_3c = iVar4 + -1;
      DataMemoryBarrier(0xb);
      if (iVar4 + -1 == 0) goto LAB_00024b44;
    }
    if (*(QTextStream *)(local_40 + 0x14) != (QTextStream)0x0) {
      QTextStream::operator<<((QTextStream *)local_40,' ');
    }
    QDebug::~QDebug((QDebug *)&local_40);
  }
  if (param_2 < 8) {
    __n = 8 - param_2;
    local_3c = (QArrayData *)(data_manager::settings::settings_area + 0x5603e);
    local_38 = 0;
    memcpy(param_1,(void *)((int)&local_3c + param_2),__n);
    if (param_3 <= __n) {
      return 1;
    }
    param_1 = (void *)((int)param_1 + __n);
    param_3 = param_3 - __n;
  }
  else {
    param_2 = param_2 - 8;
    __n = 0;
  }
  __stream = fopen((char *)(DAT_00024d94 + 0x24868),(char *)(DAT_00024d90 + 0x24864));
  if (__stream == (FILE *)0x0) {
    local_24 = DAT_00024db4 + 0x24bb0;
    local_34 = 2;
    local_30 = __stream;
    local_2c = __stream;
    local_28 = __stream;
    QMessageLogger::warning();
    pQVar3 = local_48;
    QString::fromUtf8_helper((char *)&local_44,DAT_00024db8 + 0x24be0);
    QTextStream::operator<<(pQVar3,(QString *)&local_44);
    if (*(int *)local_44 == 0) {
LAB_00024ce4:
      QArrayData::deallocate((QArrayData *)local_44,2,4);
    }
    else if (*(int *)local_44 != -1) {
      DataMemoryBarrier(0xb);
      do {
        iVar4 = *(int *)local_44;
        bVar1 = (bool)hasExclusiveAccess(local_44);
      } while (!bVar1);
      *(int *)local_44 = iVar4 + -1;
      DataMemoryBarrier(0xb);
      if (iVar4 + -1 == 0) goto LAB_00024ce4;
    }
    if (local_48[0x14] != (QTextStream)0x0) {
      QTextStream::operator<<(local_48,' ');
    }
    pQVar3 = local_48;
    QString::fromUtf8_helper((char *)&local_40,DAT_00024dbc + 0x24c58);
    QTextStream::operator<<(pQVar3,(QString *)&local_40);
    if (*(int *)local_40 == 0) {
LAB_00024d0c:
      QArrayData::deallocate(local_40,2,4);
    }
    else if (*(int *)local_40 != -1) {
      DataMemoryBarrier(0xb);
      do {
        iVar4 = *(int *)local_40;
        bVar1 = (bool)hasExclusiveAccess(local_40);
      } while (!bVar1);
      *(int *)local_40 = iVar4 + -1;
      DataMemoryBarrier(0xb);
      if (iVar4 + -1 == 0) goto LAB_00024d0c;
    }
    if (local_48[0x14] != (QTextStream)0x0) {
      QTextStream::operator<<(local_48,' ');
    }
    uVar7 = 0;
    QDebug::~QDebug((QDebug *)&local_48);
    **(undefined4 **)(iVar2 + 0x24820 + DAT_00024da0) = 7;
    goto LAB_0002495c;
  }
  pFVar5 = (FILE *)fseek(__stream,param_2,0);
  if (pFVar5 == (FILE *)0x0) {
    sVar6 = fread(param_1,1,param_3,__stream);
    __n = __n + sVar6;
    if (param_3 != __n) {
      local_24 = DAT_00024da4 + 0x249c4;
      local_34 = 2;
      local_30 = pFVar5;
      local_2c = pFVar5;
      local_28 = pFVar5;
      QMessageLogger::warning();
      pQVar3 = local_44;
      QString::fromUtf8_helper((char *)&local_40,DAT_00024da8 + 0x249f4);
      QTextStream::operator<<(pQVar3,(QString *)&local_40);
      if (*(int *)local_40 == 0) {
LAB_00024cd4:
        QArrayData::deallocate(local_40,2,4);
      }
      else if (*(int *)local_40 != -1) {
        DataMemoryBarrier(0xb);
        do {
          iVar4 = *(int *)local_40;
          bVar1 = (bool)hasExclusiveAccess(local_40);
        } while (!bVar1);
        *(int *)local_40 = iVar4 + -1;
        DataMemoryBarrier(0xb);
        if (iVar4 + -1 == 0) goto LAB_00024cd4;
      }
      if (local_44[0x14] != (QTextStream)0x0) {
        QTextStream::operator<<(local_44,' ');
      }
      goto LAB_00024938;
    }
    uVar7 = 1;
  }
  else {
    local_24 = DAT_00024d98 + 0x248a8;
    local_34 = 2;
    local_30 = (FILE *)0x0;
    local_2c = (FILE *)0x0;
    local_28 = (FILE *)0x0;
    QMessageLogger::warning();
    pQVar3 = local_44;
    QString::fromUtf8_helper((char *)&local_40,DAT_00024d9c + 0x248dc);
    QTextStream::operator<<(pQVar3,(QString *)&local_40);
    if (*(int *)local_40 == 0) {
LAB_00024b74:
      QArrayData::deallocate(local_40,2,4);
    }
    else if (*(int *)local_40 != -1) {
      DataMemoryBarrier(0xb);
      do {
        iVar4 = *(int *)local_40;
        bVar1 = (bool)hasExclusiveAccess(local_40);
      } while (!bVar1);
      *(int *)local_40 = iVar4 + -1;
      DataMemoryBarrier(0xb);
      if (iVar4 + -1 == 0) goto LAB_00024b74;
    }
    if (local_44[0x14] != (QTextStream)0x0) {
      QTextStream::operator<<(local_44,' ');
    }
LAB_00024938:
    local_4c = (QDebug *)&local_44;
    uVar7 = 0;
    QDebug::~QDebug(local_4c);
    **(undefined4 **)(iVar2 + 0x24820 + DAT_00024da0) = 7;
  }
  fclose(__stream);
LAB_0002495c:
  if (__n < param_3) {
    utilities::speedset((uchar *)((int)param_1 + __n),'\0',param_3 - __n);
    return uVar7;
  }
  return uVar7;
}



// settings_component_change @ 0003fc44

/* data_manager::settings::settings_component_change(unsigned int, unsigned int) */

void __thiscall
data_manager::settings::settings_component_change(settings *this,uint param_1,uint param_2)

{
  bool bVar1;
  undefined1 *puVar2;
  settings *psVar3;
  settings *psVar4;
  settings *psVar5;
  settings *psVar6;
  undefined1 *puVar7;
  settings *psVar8;
  
  if ((settings *)0x3def0 < this + -0x9278) {
    return;
  }
  psVar8 = this + param_1;
  psVar5 = (settings *)0xf590;
  psVar6 = (settings *)0x9278;
  puVar7 = *(undefined1 **)(DAT_0003fd24 + 0x3fc64 + DAT_0003fd28);
  do {
    if ((((psVar6 < this) && (this < psVar5)) || ((psVar6 < psVar8 && (psVar8 < psVar5)))) &&
       (psVar3 = psVar5 + -0x6270, psVar3 < psVar5)) {
      puVar2 = puVar7;
      psVar4 = psVar5 + -0x6174;
      do {
        if (((psVar3 < this) && (this < psVar4)) || ((psVar3 < psVar8 && (psVar8 < psVar4)))) {
          *puVar2 = 1;
        }
        psVar3 = psVar3 + 0xfc;
        puVar2 = puVar2 + 1;
        bVar1 = psVar4 < psVar5;
        psVar4 = psVar4 + 0xfc;
      } while (bVar1);
    }
    psVar5 = psVar5 + 0x6318;
    psVar6 = psVar6 + 0x6318;
    puVar7 = puVar7 + 100;
  } while (psVar5 != (settings *)0x4d480);
  return;
}



// remedian @ 0005da24

/* remedian(remed*, int) */

void remedian(remed *param_1,int param_2)

{
  undefined4 uVar1;
  int iVar2;
  remed *prVar3;
  remed *prVar4;
  int iVar5;
  remed *prVar6;
  remed *prVar7;
  remed *local_30 [5];
  
  prVar7 = param_1 + (*(int *)(param_1 + 4) + 0x1e) * 4;
  local_30[1] = param_1 + (*(int *)(param_1 + 8) + 0x37) * 4;
  local_30[2] = param_1 + (*(int *)(param_1 + 0xc) + 0x50) * 4;
  iVar2 = *(int *)param_1 + 1;
  local_30[3] = param_1 + 0x1a4;
  *(int *)(param_1 + *(int *)param_1 * 4 + 0x14) = param_2;
  prVar6 = param_1 + 0x14;
  *(int *)param_1 = iVar2;
  prVar3 = param_1;
  iVar5 = 1;
  local_30[0] = prVar7;
  while( true ) {
    uVar1 = quick_select((int *)prVar6,iVar2);
    *(undefined4 *)prVar7 = uVar1;
    prVar6 = prVar6 + 100;
    prVar4 = prVar3 + 4;
    if (0x18 < *(int *)prVar3) {
      *(undefined4 *)prVar3 = 0;
      *(int *)prVar4 = *(int *)prVar4 + 1;
    }
    if (iVar5 == 4) break;
    iVar2 = *(int *)(param_1 + iVar5 * 4);
    prVar7 = local_30[iVar5];
    prVar3 = prVar4;
    iVar5 = iVar5 + 1;
  }
  return;
}



// dash_qmldata_space_read @ 0008d3ec

/* data_manager::dash_firmware_spaces::dash_qmldata_space_read(void*, unsigned int, unsigned int) */

void data_manager::dash_firmware_spaces::dash_qmldata_space_read
               (void *param_1,uint param_2,uint param_3)

{
  address_space_read(param_1,param_2,param_3,51200000,(char *)(DAT_0008d418 + 0x8d494));
  return;
}



// dash_qmldata_space_write @ 0008d41c

/* data_manager::dash_firmware_spaces::dash_qmldata_space_write(void*, unsigned int, unsigned int)
    */

void data_manager::dash_firmware_spaces::dash_qmldata_space_write
               (void *param_1,uint param_2,uint param_3)

{
  address_space_write(param_1,param_2,param_3,51200000,(char *)(DAT_0008d448 + 0x8d4c4));
  return;
}



// ~UIComponent @ 00090c4c

/* ui_module::UIComponent::~UIComponent() */

UIComponent * __thiscall ui_module::UIComponent::~UIComponent(UIComponent *this)

{
  bool bVar1;
  QArrayData *pQVar2;
  int iVar3;
  
  if ((*(int *)(this + 4) != 0) && (*(int *)(this + 0xc) != 0)) {
    QQuickItem::setVisible(SUB41(*(int *)(this + 4),0));
    if (*(int **)(this + 4) != (int *)0x0) {
      (**(code **)(**(int **)(this + 4) + 0x10))();
    }
    if (*(int **)(this + 0xc) != (int *)0x0) {
      (**(code **)(**(int **)(this + 0xc) + 0x10))();
    }
    *(undefined4 *)(this + 4) = 0;
    *(undefined4 *)(this + 0xc) = 0;
  }
  pQVar2 = *(QArrayData **)(this + 0x158);
  if (*(int *)pQVar2 == 0) {
LAB_00090e04:
    QArrayData::deallocate(pQVar2,2,4);
  }
  else if (*(int *)pQVar2 != -1) {
    DataMemoryBarrier(0xb);
    do {
      iVar3 = *(int *)pQVar2;
      bVar1 = (bool)hasExclusiveAccess(pQVar2);
    } while (!bVar1);
    *(int *)pQVar2 = iVar3 + -1;
    DataMemoryBarrier(0xb);
    if (iVar3 + -1 == 0) {
      pQVar2 = *(QArrayData **)(this + 0x158);
      goto LAB_00090e04;
    }
  }
  pQVar2 = *(QArrayData **)(this + 0x154);
  if (*(int *)pQVar2 == 0) {
LAB_00090db8:
    QArrayData::deallocate(pQVar2,2,4);
    pQVar2 = *(QArrayData **)(this + 0x150);
    iVar3 = *(int *)pQVar2;
    if (iVar3 != 0) goto LAB_00090d40;
LAB_00090dd4:
    QArrayData::deallocate(pQVar2,2,4);
    pQVar2 = *(QArrayData **)(this + 0x140);
    iVar3 = *(int *)pQVar2;
  }
  else {
    if (*(int *)pQVar2 != -1) {
      DataMemoryBarrier(0xb);
      do {
        iVar3 = *(int *)pQVar2;
        bVar1 = (bool)hasExclusiveAccess(pQVar2);
      } while (!bVar1);
      *(int *)pQVar2 = iVar3 + -1;
      DataMemoryBarrier(0xb);
      if (iVar3 + -1 == 0) {
        pQVar2 = *(QArrayData **)(this + 0x154);
        goto LAB_00090db8;
      }
    }
    pQVar2 = *(QArrayData **)(this + 0x150);
    iVar3 = *(int *)pQVar2;
    if (iVar3 == 0) goto LAB_00090dd4;
LAB_00090d40:
    if (iVar3 != -1) {
      DataMemoryBarrier(0xb);
      do {
        iVar3 = *(int *)pQVar2;
        bVar1 = (bool)hasExclusiveAccess(pQVar2);
      } while (!bVar1);
      *(int *)pQVar2 = iVar3 + -1;
      DataMemoryBarrier(0xb);
      if (iVar3 + -1 == 0) {
        pQVar2 = *(QArrayData **)(this + 0x150);
        goto LAB_00090dd4;
      }
    }
    pQVar2 = *(QArrayData **)(this + 0x140);
    iVar3 = *(int *)pQVar2;
  }
  if (iVar3 == 0) {
LAB_00090df0:
    QArrayData::deallocate(pQVar2,2,4);
    return this;
  }
  if (iVar3 != -1) {
    DataMemoryBarrier(0xb);
    do {
      iVar3 = *(int *)pQVar2;
      bVar1 = (bool)hasExclusiveAccess(pQVar2);
    } while (!bVar1);
    *(int *)pQVar2 = iVar3 + -1;
    DataMemoryBarrier(0xb);
    if (iVar3 + -1 == 0) {
      pQVar2 = *(QArrayData **)(this + 0x140);
      goto LAB_00090df0;
    }
  }
  return this;
}



// get_qml_file_from_gauge_type @ 00091364

/* ui_module::UIComponent::get_qml_file_from_gauge_type(unsigned short) */

undefined4 * ui_module::UIComponent::get_qml_file_from_gauge_type(ushort param_1)

{
  bool bVar1;
  undefined4 *puVar2;
  QArrayData *pQVar3;
  undefined4 uVar4;
  undefined4 in_r2;
  int iVar5;
  QArrayData *pQVar6;
  QArrayData *local_80;
  QArrayData *local_7c;
  QArrayData *local_78;
  QArrayData *local_74;
  QArrayData *local_70;
  QArrayData *local_6c;
  QArrayData *local_68;
  QArrayData *local_64;
  QArrayData *local_60;
  QArrayData *local_5c;
  QArrayData *local_58;
  QArrayData *local_54;
  QArrayData *local_50;
  QArrayData *local_4c;
  QArrayData *local_48;
  QArrayData *local_44;
  QArrayData *local_40;
  QArrayData *local_3c;
  QArrayData *local_38;
  QArrayData *local_34;
  QArrayData *local_30;
  QArrayData *local_2c;
  QArrayData *local_28;
  QArrayData *local_24;
  QArrayData *local_20;
  QArrayData *local_1c [2];
  
  puVar2 = (undefined4 *)(uint)param_1;
  pQVar6 = *(QArrayData **)(DAT_0009213c + 0x91380 + DAT_00092140);
  local_80 = pQVar6;
  local_7c = (QArrayData *)QString::fromAscii_helper((char *)(DAT_00092144 + 0x91394),0x37);
  switch(in_r2) {
  case 2:
    if (1 < *(int *)local_7c + 1U) {
      DataMemoryBarrier(0xb);
      do {
        bVar1 = (bool)hasExclusiveAccess(local_7c);
      } while (!bVar1);
      *(int *)local_7c = *(int *)local_7c + 1;
      DataMemoryBarrier(0xb);
    }
    local_78 = local_7c;
    QString::fromUtf8_helper((char *)&local_48,DAT_0009214c + 0x9151c);
    QString::append((QString *)&local_78);
    if (*(int *)local_48 == 0) {
LAB_00091ff4:
      QArrayData::deallocate(local_48,2,4);
    }
    else if (*(int *)local_48 != -1) {
      DataMemoryBarrier(0xb);
      do {
        iVar5 = *(int *)local_48;
        bVar1 = (bool)hasExclusiveAccess(local_48);
      } while (!bVar1);
      *(int *)local_48 = iVar5 + -1;
      DataMemoryBarrier(0xb);
      if (iVar5 + -1 == 0) goto LAB_00091ff4;
    }
    QString::operator=((QString *)&local_80,(QString *)&local_78);
    pQVar3 = local_78;
    if (*(int *)local_78 != 0) {
      if (*(int *)local_78 == -1) goto LAB_00091dec;
      DataMemoryBarrier(0xb);
      do {
        iVar5 = *(int *)local_78 + -1;
        bVar1 = (bool)hasExclusiveAccess(local_78);
      } while (!bVar1);
      *(int *)local_78 = iVar5;
      DataMemoryBarrier(0xb);
joined_r0x00091b2c:
      if (iVar5 != 0) goto LAB_00091dec;
    }
    break;
  case 3:
    if (1 < *(int *)local_7c + 1U) {
      DataMemoryBarrier(0xb);
      do {
        bVar1 = (bool)hasExclusiveAccess(local_7c);
      } while (!bVar1);
      *(int *)local_7c = *(int *)local_7c + 1;
      DataMemoryBarrier(0xb);
    }
    local_74 = local_7c;
    QString::fromUtf8_helper((char *)&local_44,DAT_00092150 + 0x91604);
    QString::append((QString *)&local_74);
    if (*(int *)local_44 == 0) {
LAB_00091fe4:
      QArrayData::deallocate(local_44,2,4);
    }
    else if (*(int *)local_44 != -1) {
      DataMemoryBarrier(0xb);
      do {
        iVar5 = *(int *)local_44;
        bVar1 = (bool)hasExclusiveAccess(local_44);
      } while (!bVar1);
      *(int *)local_44 = iVar5 + -1;
      DataMemoryBarrier(0xb);
      if (iVar5 + -1 == 0) goto LAB_00091fe4;
    }
    QString::operator=((QString *)&local_80,(QString *)&local_74);
    pQVar3 = local_74;
    if (*(int *)local_74 != 0) {
      if (*(int *)local_74 == -1) goto LAB_00091dec;
      DataMemoryBarrier(0xb);
      do {
        iVar5 = *(int *)local_74 + -1;
        bVar1 = (bool)hasExclusiveAccess(local_74);
      } while (!bVar1);
      *(int *)local_74 = iVar5;
      DataMemoryBarrier(0xb);
      goto joined_r0x00091b2c;
    }
    break;
  case 4:
    if (1 < *(int *)local_7c + 1U) {
      DataMemoryBarrier(0xb);
      do {
        bVar1 = (bool)hasExclusiveAccess(local_7c);
      } while (!bVar1);
      *(int *)local_7c = *(int *)local_7c + 1;
      DataMemoryBarrier(0xb);
    }
    local_70 = local_7c;
    QString::fromUtf8_helper((char *)&local_40,DAT_00092154 + 0x916ec);
    QString::append((QString *)&local_70);
    if (*(int *)local_40 == 0) {
LAB_00092034:
      QArrayData::deallocate(local_40,2,4);
    }
    else if (*(int *)local_40 != -1) {
      DataMemoryBarrier(0xb);
      do {
        iVar5 = *(int *)local_40;
        bVar1 = (bool)hasExclusiveAccess(local_40);
      } while (!bVar1);
      *(int *)local_40 = iVar5 + -1;
      DataMemoryBarrier(0xb);
      if (iVar5 + -1 == 0) goto LAB_00092034;
    }
    QString::operator=((QString *)&local_80,(QString *)&local_70);
    pQVar3 = local_70;
    if (*(int *)local_70 != 0) {
      if (*(int *)local_70 == -1) goto LAB_00091dec;
      DataMemoryBarrier(0xb);
      do {
        iVar5 = *(int *)local_70 + -1;
        bVar1 = (bool)hasExclusiveAccess(local_70);
      } while (!bVar1);
      *(int *)local_70 = iVar5;
      DataMemoryBarrier(0xb);
      goto joined_r0x00091b2c;
    }
    break;
  case 5:
    if (1 < *(int *)local_7c + 1U) {
      DataMemoryBarrier(0xb);
      do {
        bVar1 = (bool)hasExclusiveAccess(local_7c);
      } while (!bVar1);
      *(int *)local_7c = *(int *)local_7c + 1;
      DataMemoryBarrier(0xb);
    }
    local_50 = local_7c;
    QString::fromUtf8_helper((char *)&local_20,DAT_00092158 + 0x917d4);
    QString::append((QString *)&local_50);
    if (*(int *)local_20 == 0) {
LAB_00092004:
      QArrayData::deallocate(local_20,2,4);
    }
    else if (*(int *)local_20 != -1) {
      DataMemoryBarrier(0xb);
      do {
        iVar5 = *(int *)local_20;
        bVar1 = (bool)hasExclusiveAccess(local_20);
      } while (!bVar1);
      *(int *)local_20 = iVar5 + -1;
      DataMemoryBarrier(0xb);
      if (iVar5 + -1 == 0) goto LAB_00092004;
    }
    QString::operator=((QString *)&local_80,(QString *)&local_50);
    pQVar3 = local_50;
    if (*(int *)local_50 != 0) {
      if (*(int *)local_50 == -1) goto LAB_00091dec;
      DataMemoryBarrier(0xb);
      do {
        iVar5 = *(int *)local_50 + -1;
        bVar1 = (bool)hasExclusiveAccess(local_50);
      } while (!bVar1);
      *(int *)local_50 = iVar5;
      DataMemoryBarrier(0xb);
      goto joined_r0x00091b2c;
    }
    break;
  case 6:
  default:
switchD_000913a4_default:
    uVar4 = QString::fromAscii_helper((char *)(DAT_00092178 + 0x91f34),0);
    *puVar2 = uVar4;
    iVar5 = *(int *)local_7c;
    goto joined_r0x00091f44;
  case 7:
    if (1 < *(int *)local_7c + 1U) {
      DataMemoryBarrier(0xb);
      do {
        bVar1 = (bool)hasExclusiveAccess(local_7c);
      } while (!bVar1);
      *(int *)local_7c = *(int *)local_7c + 1;
      DataMemoryBarrier(0xb);
    }
    local_6c = local_7c;
    QString::fromUtf8_helper((char *)&local_3c,DAT_00092168 + 0x91b80);
    QString::append((QString *)&local_6c);
    if (*(int *)local_3c == 0) {
LAB_00092014:
      QArrayData::deallocate(local_3c,2,4);
    }
    else if (*(int *)local_3c != -1) {
      DataMemoryBarrier(0xb);
      do {
        iVar5 = *(int *)local_3c;
        bVar1 = (bool)hasExclusiveAccess(local_3c);
      } while (!bVar1);
      *(int *)local_3c = iVar5 + -1;
      DataMemoryBarrier(0xb);
      if (iVar5 + -1 == 0) goto LAB_00092014;
    }
    QString::operator=((QString *)&local_80,(QString *)&local_6c);
    pQVar3 = local_6c;
    if (*(int *)local_6c != 0) {
      if (*(int *)local_6c == -1) goto LAB_00091dec;
      DataMemoryBarrier(0xb);
      do {
        iVar5 = *(int *)local_6c + -1;
        bVar1 = (bool)hasExclusiveAccess(local_6c);
      } while (!bVar1);
      *(int *)local_6c = iVar5;
      DataMemoryBarrier(0xb);
      goto joined_r0x00091b2c;
    }
    break;
  case 8:
    goto switchD_000913a4_default;
  case 9:
    if (1 < *(int *)local_7c + 1U) {
      DataMemoryBarrier(0xb);
      do {
        bVar1 = (bool)hasExclusiveAccess(local_7c);
      } while (!bVar1);
      *(int *)local_7c = *(int *)local_7c + 1;
      DataMemoryBarrier(0xb);
    }
    local_68 = local_7c;
    QString::fromUtf8_helper((char *)&local_38,DAT_00092160 + 0x919a4);
    QString::append((QString *)&local_68);
    if (*(int *)local_38 == 0) {
LAB_00092064:
      QArrayData::deallocate(local_38,2,4);
    }
    else if (*(int *)local_38 != -1) {
      DataMemoryBarrier(0xb);
      do {
        iVar5 = *(int *)local_38;
        bVar1 = (bool)hasExclusiveAccess(local_38);
      } while (!bVar1);
      *(int *)local_38 = iVar5 + -1;
      DataMemoryBarrier(0xb);
      if (iVar5 + -1 == 0) goto LAB_00092064;
    }
    QString::operator=((QString *)&local_80,(QString *)&local_68);
    pQVar3 = local_68;
    if (*(int *)local_68 == 0) break;
    if (*(int *)local_68 != -1) {
      DataMemoryBarrier(0xb);
      do {
        iVar5 = *(int *)local_68;
        bVar1 = (bool)hasExclusiveAccess(local_68);
      } while (!bVar1);
      *(int *)local_68 = iVar5 + -1;
      DataMemoryBarrier(0xb);
      if (iVar5 + -1 == 0) break;
    }
    goto LAB_00091dec;
  case 10:
    if (1 < *(int *)local_7c + 1U) {
      DataMemoryBarrier(0xb);
      do {
        bVar1 = (bool)hasExclusiveAccess(local_7c);
      } while (!bVar1);
      *(int *)local_7c = *(int *)local_7c + 1;
      DataMemoryBarrier(0xb);
    }
    local_64 = local_7c;
    QString::fromUtf8_helper((char *)&local_34,DAT_00092170 + 0x91d50);
    QString::append((QString *)&local_64);
    if (*(int *)local_34 == 0) {
LAB_00092054:
      QArrayData::deallocate(local_34,2,4);
    }
    else if (*(int *)local_34 != -1) {
      DataMemoryBarrier(0xb);
      do {
        iVar5 = *(int *)local_34;
        bVar1 = (bool)hasExclusiveAccess(local_34);
      } while (!bVar1);
      *(int *)local_34 = iVar5 + -1;
      DataMemoryBarrier(0xb);
      if (iVar5 + -1 == 0) goto LAB_00092054;
    }
    QString::operator=((QString *)&local_80,(QString *)&local_64);
    pQVar3 = local_64;
    if (*(int *)local_64 != 0) {
      if (*(int *)local_64 != -1) {
        DataMemoryBarrier(0xb);
        do {
          iVar5 = *(int *)local_64;
          bVar1 = (bool)hasExclusiveAccess(local_64);
        } while (!bVar1);
        *(int *)local_64 = iVar5 + -1;
        DataMemoryBarrier(0xb);
        if (iVar5 + -1 == 0) break;
      }
      goto LAB_00091dec;
    }
    break;
  case 0xb:
    goto switchD_000913a4_default;
  case 0xc:
    goto switchD_000913a4_default;
  case 0xd:
    if (1 < *(int *)local_7c + 1U) {
      DataMemoryBarrier(0xb);
      do {
        bVar1 = (bool)hasExclusiveAccess(local_7c);
      } while (!bVar1);
      *(int *)local_7c = *(int *)local_7c + 1;
      DataMemoryBarrier(0xb);
    }
    local_60 = local_7c;
    QString::fromUtf8_helper((char *)&local_30,DAT_0009215c + 0x918bc);
    QString::append((QString *)&local_60);
    if (*(int *)local_30 == 0) {
LAB_00092024:
      QArrayData::deallocate(local_30,2,4);
    }
    else if (*(int *)local_30 != -1) {
      DataMemoryBarrier(0xb);
      do {
        iVar5 = *(int *)local_30;
        bVar1 = (bool)hasExclusiveAccess(local_30);
      } while (!bVar1);
      *(int *)local_30 = iVar5 + -1;
      DataMemoryBarrier(0xb);
      if (iVar5 + -1 == 0) goto LAB_00092024;
    }
    QString::operator=((QString *)&local_80,(QString *)&local_60);
    pQVar3 = local_60;
    if (*(int *)local_60 != 0) {
      if (*(int *)local_60 == -1) goto LAB_00091dec;
      DataMemoryBarrier(0xb);
      do {
        iVar5 = *(int *)local_60 + -1;
        bVar1 = (bool)hasExclusiveAccess(local_60);
      } while (!bVar1);
      *(int *)local_60 = iVar5;
      DataMemoryBarrier(0xb);
      goto joined_r0x00091b2c;
    }
    break;
  case 0xe:
    if (1 < *(int *)local_7c + 1U) {
      DataMemoryBarrier(0xb);
      do {
        bVar1 = (bool)hasExclusiveAccess(local_7c);
      } while (!bVar1);
      *(int *)local_7c = *(int *)local_7c + 1;
      DataMemoryBarrier(0xb);
    }
    local_5c = local_7c;
    QString::fromUtf8_helper((char *)&local_2c,DAT_0009216c + 0x91c68);
    QString::append((QString *)&local_5c);
    if (*(int *)local_2c == 0) {
LAB_00092074:
      QArrayData::deallocate(local_2c,2,4);
    }
    else if (*(int *)local_2c != -1) {
      DataMemoryBarrier(0xb);
      do {
        iVar5 = *(int *)local_2c;
        bVar1 = (bool)hasExclusiveAccess(local_2c);
      } while (!bVar1);
      *(int *)local_2c = iVar5 + -1;
      DataMemoryBarrier(0xb);
      if (iVar5 + -1 == 0) goto LAB_00092074;
    }
    QString::operator=((QString *)&local_80,(QString *)&local_5c);
    pQVar3 = local_5c;
    if (*(int *)local_5c != 0) {
      if (*(int *)local_5c == -1) goto LAB_00091dec;
      DataMemoryBarrier(0xb);
      do {
        iVar5 = *(int *)local_5c + -1;
        bVar1 = (bool)hasExclusiveAccess(local_5c);
      } while (!bVar1);
      *(int *)local_5c = iVar5;
      DataMemoryBarrier(0xb);
      goto joined_r0x00091b2c;
    }
    break;
  case 0xf:
    if (1 < *(int *)local_7c + 1U) {
      DataMemoryBarrier(0xb);
      do {
        bVar1 = (bool)hasExclusiveAccess(local_7c);
      } while (!bVar1);
      *(int *)local_7c = *(int *)local_7c + 1;
      DataMemoryBarrier(0xb);
    }
    local_58 = local_7c;
    QString::fromUtf8_helper((char *)&local_28,DAT_00092164 + 0x91a98);
    QString::append((QString *)&local_58);
    if (*(int *)local_28 == 0) {
LAB_00092044:
      QArrayData::deallocate(local_28,2,4);
    }
    else if (*(int *)local_28 != -1) {
      DataMemoryBarrier(0xb);
      do {
        iVar5 = *(int *)local_28;
        bVar1 = (bool)hasExclusiveAccess(local_28);
      } while (!bVar1);
      *(int *)local_28 = iVar5 + -1;
      DataMemoryBarrier(0xb);
      if (iVar5 + -1 == 0) goto LAB_00092044;
    }
    QString::operator=((QString *)&local_80,(QString *)&local_58);
    pQVar3 = local_58;
    if (*(int *)local_58 != 0) {
      if (*(int *)local_58 == -1) goto LAB_00091dec;
      DataMemoryBarrier(0xb);
      do {
        iVar5 = *(int *)local_58 + -1;
        bVar1 = (bool)hasExclusiveAccess(local_58);
      } while (!bVar1);
      *(int *)local_58 = iVar5;
      DataMemoryBarrier(0xb);
      goto joined_r0x00091b2c;
    }
    break;
  case 0x10:
    if (1 < *(int *)local_7c + 1U) {
      DataMemoryBarrier(0xb);
      do {
        bVar1 = (bool)hasExclusiveAccess(local_7c);
      } while (!bVar1);
      *(int *)local_7c = *(int *)local_7c + 1;
      DataMemoryBarrier(0xb);
    }
    local_54 = local_7c;
    QString::fromUtf8_helper((char *)&local_24,DAT_00092174 + 0x91e84);
    QString::append((QString *)&local_54);
    if (*(int *)local_24 == 0) {
LAB_00091fd4:
      QArrayData::deallocate(local_24,2,4);
    }
    else if (*(int *)local_24 != -1) {
      DataMemoryBarrier(0xb);
      do {
        iVar5 = *(int *)local_24;
        bVar1 = (bool)hasExclusiveAccess(local_24);
      } while (!bVar1);
      *(int *)local_24 = iVar5 + -1;
      DataMemoryBarrier(0xb);
      if (iVar5 + -1 == 0) goto LAB_00091fd4;
    }
    QString::operator=((QString *)&local_80,(QString *)&local_54);
    pQVar3 = local_54;
    if (*(int *)local_54 != 0) {
      if (*(int *)local_54 != -1) {
        DataMemoryBarrier(0xb);
        do {
          iVar5 = *(int *)local_54 + -1;
          bVar1 = (bool)hasExclusiveAccess(local_54);
        } while (!bVar1);
        *(int *)local_54 = iVar5;
        DataMemoryBarrier(0xb);
joined_r0x000914c8:
        if (iVar5 == 0) break;
      }
      goto LAB_00091dec;
    }
    break;
  case 0x11:
    if (1 < *(int *)local_7c + 1U) {
      DataMemoryBarrier(0xb);
      do {
        bVar1 = (bool)hasExclusiveAccess(local_7c);
      } while (!bVar1);
      *(int *)local_7c = *(int *)local_7c + 1;
      DataMemoryBarrier(0xb);
    }
    local_4c = local_7c;
    QString::fromUtf8_helper((char *)local_1c,DAT_00092148 + 0x91434);
    QString::append((QString *)&local_4c);
    if (*(int *)local_1c[0] == 0) {
LAB_00091fc4:
      QArrayData::deallocate(local_1c[0],2,4);
    }
    else if (*(int *)local_1c[0] != -1) {
      DataMemoryBarrier(0xb);
      do {
        iVar5 = *(int *)local_1c[0];
        bVar1 = (bool)hasExclusiveAccess(local_1c[0]);
      } while (!bVar1);
      *(int *)local_1c[0] = iVar5 + -1;
      DataMemoryBarrier(0xb);
      if (iVar5 + -1 == 0) goto LAB_00091fc4;
    }
    QString::operator=((QString *)&local_80,(QString *)&local_4c);
    pQVar3 = local_4c;
    if (*(int *)local_4c != 0) {
      if (*(int *)local_4c != -1) {
        DataMemoryBarrier(0xb);
        do {
          iVar5 = *(int *)local_4c + -1;
          bVar1 = (bool)hasExclusiveAccess(local_4c);
        } while (!bVar1);
        *(int *)local_4c = iVar5;
        DataMemoryBarrier(0xb);
        goto joined_r0x000914c8;
      }
      goto LAB_00091dec;
    }
  }
  QArrayData::deallocate(pQVar3,2,4);
LAB_00091dec:
  *puVar2 = local_80;
  iVar5 = *(int *)local_7c;
  local_80 = pQVar6;
joined_r0x00091f44:
  if (iVar5 == 0) {
LAB_00091e08:
    QArrayData::deallocate(local_7c,2,4);
    iVar5 = *(int *)local_80;
  }
  else {
    if (iVar5 != -1) {
      DataMemoryBarrier(0xb);
      do {
        iVar5 = *(int *)local_7c;
        bVar1 = (bool)hasExclusiveAccess(local_7c);
      } while (!bVar1);
      *(int *)local_7c = iVar5 + -1;
      DataMemoryBarrier(0xb);
      if (iVar5 + -1 == 0) goto LAB_00091e08;
    }
    iVar5 = *(int *)local_80;
  }
  if (iVar5 == 0) {
LAB_00091e24:
    QArrayData::deallocate(local_80,2,4);
    return puVar2;
  }
  if (iVar5 != -1) {
    DataMemoryBarrier(0xb);
    do {
      iVar5 = *(int *)local_80;
      bVar1 = (bool)hasExclusiveAccess(local_80);
    } while (!bVar1);
    *(int *)local_80 = iVar5 + -1;
    DataMemoryBarrier(0xb);
    if (iVar5 + -1 == 0) goto LAB_00091e24;
  }
  return puVar2;
}



// image_src_to_path @ 00092c14

/* ui_module::UIComponent::image_src_to_path(char*) */

char * ui_module::UIComponent::image_src_to_path(char *param_1)

{
  bool bVar1;
  int iVar2;
  size_t sVar3;
  undefined4 uVar4;
  int iVar5;
  int in_r1;
  char *in_r2;
  int iVar6;
  int iVar7;
  QArrayData *local_30;
  QArrayData *local_2c;
  QArrayData *local_28;
  QArrayData *local_24 [2];
  
  iVar7 = DAT_00092f38 + 0x92c30;
  if (in_r2 == (char *)0x0) {
    uVar4 = QString::fromAscii_helper((char *)(DAT_00092f4c + 0x92eec),0);
    *(undefined4 *)param_1 = uVar4;
    return param_1;
  }
  local_30 = *(QArrayData **)(in_r1 + 0x158);
  if (1 < *(int *)local_30 + 1U) {
    DataMemoryBarrier(0xb);
    do {
      bVar1 = (bool)hasExclusiveAccess(local_30);
    } while (!bVar1);
    *(int *)local_30 = *(int *)local_30 + 1;
    DataMemoryBarrier(0xb);
  }
  local_2c = (QArrayData *)QString::fromAscii_helper((char *)(get_bounds + DAT_00092f3c + 4),0x3b);
  sVar3 = strlen(in_r2);
  local_28 = (QArrayData *)QString::fromAscii_helper(in_r2,sVar3);
  if (*(int *)(local_28 + 4) == 0) {
    uVar4 = QString::fromAscii_helper((char *)(DAT_00092f40 + 0x92cbc),0);
LAB_00092cbc:
    *(undefined4 *)param_1 = uVar4;
    iVar7 = *(int *)local_28;
    if (iVar7 == 0) goto LAB_00092e64;
LAB_00092cd0:
    if (iVar7 != -1) {
      DataMemoryBarrier(0xb);
      do {
        iVar7 = *(int *)local_28;
        bVar1 = (bool)hasExclusiveAccess(local_28);
      } while (!bVar1);
      *(int *)local_28 = iVar7 + -1;
      DataMemoryBarrier(0xb);
      if (iVar7 + -1 == 0) goto LAB_00092e64;
    }
    iVar7 = *(int *)local_2c;
    if (iVar7 != 0) goto LAB_00092d10;
LAB_00092e80:
    QArrayData::deallocate(local_2c,2,4);
    iVar7 = *(int *)local_30;
  }
  else {
    QString::append((QString *)&local_30);
    QString::append((QString *)&local_2c);
    local_24[0] = local_2c;
    if (1 < *(int *)local_2c + 1U) {
      DataMemoryBarrier(0xb);
      do {
        bVar1 = (bool)hasExclusiveAccess(local_2c);
      } while (!bVar1);
      *(int *)local_2c = *(int *)local_2c + 1;
      DataMemoryBarrier(0xb);
    }
    iVar5 = unix_file::file_exists(local_24);
    if (*(int *)local_24[0] == 0) {
LAB_00092eb4:
      QArrayData::deallocate(local_24[0],2,4);
      iVar2 = DAT_00092f44;
    }
    else {
      iVar2 = DAT_00092f44;
      if (*(int *)local_24[0] != -1) {
        DataMemoryBarrier(0xb);
        do {
          iVar6 = *(int *)local_24[0];
          bVar1 = (bool)hasExclusiveAccess(local_24[0]);
        } while (!bVar1);
        *(int *)local_24[0] = iVar6 + -1;
        DataMemoryBarrier(0xb);
        iVar2 = DAT_00092f44;
        if (iVar6 + -1 == 0) goto LAB_00092eb4;
      }
    }
    DAT_00092f44 = iVar2;
    if (iVar5 == 0) {
      uVar4 = QString::fromAscii_helper((char *)(DAT_00092f48 + 0x92ed8),0);
      goto LAB_00092cbc;
    }
    *(QArrayData **)param_1 = local_30;
    local_30 = *(QArrayData **)(iVar7 + iVar2);
    iVar7 = *(int *)local_28;
    if (iVar7 != 0) goto LAB_00092cd0;
LAB_00092e64:
    QArrayData::deallocate(local_28,2,4);
    iVar7 = *(int *)local_2c;
    if (iVar7 == 0) goto LAB_00092e80;
LAB_00092d10:
    if (iVar7 != -1) {
      DataMemoryBarrier(0xb);
      do {
        iVar7 = *(int *)local_2c;
        bVar1 = (bool)hasExclusiveAccess(local_2c);
      } while (!bVar1);
      *(int *)local_2c = iVar7 + -1;
      DataMemoryBarrier(0xb);
      if (iVar7 + -1 == 0) goto LAB_00092e80;
    }
    iVar7 = *(int *)local_30;
  }
  if (iVar7 == 0) {
LAB_00092e9c:
    QArrayData::deallocate(local_30,2,4);
    return param_1;
  }
  if (iVar7 != -1) {
    DataMemoryBarrier(0xb);
    do {
      iVar7 = *(int *)local_30;
      bVar1 = (bool)hasExclusiveAccess(local_30);
    } while (!bVar1);
    *(int *)local_30 = iVar7 + -1;
    DataMemoryBarrier(0xb);
    if (iVar7 + -1 == 0) goto LAB_00092e9c;
  }
  return param_1;
}



// reload_component @ 00098730

/* ui_module::UIComponent::reload_component(QString) */

void __thiscall ui_module::UIComponent::reload_component(UIComponent *this,QString *param_2)

{
  QTextStream QVar1;
  bool bVar2;
  QArrayData *pQVar3;
  QTextStream *pQVar4;
  QQmlComponent *this_00;
  undefined4 uVar5;
  int iVar6;
  int *piVar7;
  QDebug *this_01;
  short sVar8;
  int iVar9;
  QArrayData *local_84;
  QArrayData *local_80;
  QTextStream *local_7c;
  QArrayData *local_78;
  QTextStream *local_74;
  QArrayData *local_70;
  QTextStream *local_6c;
  QArrayData *local_68;
  QTextStream *local_64;
  QArrayData *local_60;
  QArrayData *local_5c;
  QArrayData *local_58;
  QArrayData *local_54;
  QArrayData *local_50;
  QArrayData *local_4c;
  QArrayData *local_48;
  QArrayData *local_44;
  QArrayData *local_40;
  QArrayData *local_3c;
  QArrayData *local_38;
  undefined4 local_34;
  int *local_30;
  int *local_2c;
  int *local_28;
  int local_24;
  
  iVar9 = DAT_00099454 + 0x98758;
  local_84 = *(QArrayData **)(iVar9 + DAT_00099458);
  if (*(int *)(*(int *)param_2 + 4) == 0) {
    sVar8 = *(short *)(*(int *)(this + 0x40) + 0x7c);
    get_qml_file_from_gauge_type((ushort)&local_80);
    pQVar3 = local_84;
    local_84 = local_80;
    local_80 = pQVar3;
    if (*(int *)pQVar3 != 0) {
      if (*(int *)pQVar3 != -1) {
        DataMemoryBarrier(0xb);
        do {
          iVar6 = *(int *)pQVar3;
          bVar2 = (bool)hasExclusiveAccess(pQVar3);
        } while (!bVar2);
        *(int *)pQVar3 = iVar6 + -1;
        DataMemoryBarrier(0xb);
        if (iVar6 + -1 == 0) goto LAB_000987cc;
      }
      goto LAB_000988e8;
    }
LAB_000987cc:
    QArrayData::deallocate(pQVar3,2,4);
    if (*(int *)(local_84 + 4) != 0) goto LAB_000987ec;
LAB_000988f8:
    this_01 = (QDebug *)&local_7c;
    local_24 = DAT_00099460 + 0x98918;
    local_34 = 2;
    local_30 = (int *)0x0;
    local_2c = (int *)0x0;
    local_28 = (int *)0x0;
    QMessageLogger::critical();
    pQVar4 = local_7c;
    QString::fromUtf8_helper((char *)&local_5c,DAT_00099464 + 0x9894c);
    QTextStream::operator<<(pQVar4,(QString *)&local_5c);
    if (*(int *)local_5c == 0) {
LAB_00098dfc:
      QArrayData::deallocate(local_5c,2,4);
      QVar1 = local_7c[0x14];
    }
    else {
      if (*(int *)local_5c != -1) {
        DataMemoryBarrier(0xb);
        do {
          iVar9 = *(int *)local_5c;
          bVar2 = (bool)hasExclusiveAccess(local_5c);
        } while (!bVar2);
        *(int *)local_5c = iVar9 + -1;
        DataMemoryBarrier(0xb);
        if (iVar9 + -1 == 0) goto LAB_00098dfc;
      }
      QVar1 = local_7c[0x14];
    }
    if (QVar1 != (QTextStream)0x0) {
      QTextStream::operator<<(local_7c,' ');
    }
    QTextStream::operator<<(local_7c,sVar8);
    if (local_7c[0x14] != (QTextStream)0x0) {
      QTextStream::operator<<(local_7c,' ');
    }
    pQVar4 = local_7c;
    QString::fromUtf8_helper((char *)&local_58,DAT_00099468 + 0x989d8);
    QTextStream::operator<<(pQVar4,(QString *)&local_58);
    if (*(int *)local_58 == 0) {
LAB_00098e50:
      QArrayData::deallocate(local_58,2,4);
      QVar1 = local_7c[0x14];
    }
    else {
      if (*(int *)local_58 != -1) {
        DataMemoryBarrier(0xb);
        do {
          iVar9 = *(int *)local_58;
          bVar2 = (bool)hasExclusiveAccess(local_58);
        } while (!bVar2);
        *(int *)local_58 = iVar9 + -1;
        DataMemoryBarrier(0xb);
        if (iVar9 + -1 == 0) goto LAB_00098e50;
      }
      QVar1 = local_7c[0x14];
    }
    if (QVar1 != (QTextStream)0x0) {
      QTextStream::operator<<(local_7c,' ');
    }
    QDebug::putString(this_01,(uint)(local_84 + *(int *)(local_84 + 0xc)));
    if (local_7c[0x14] != (QTextStream)0x0) {
      QTextStream::operator<<(local_7c,' ');
    }
    pQVar4 = local_7c;
    QString::fromUtf8_helper((char *)&local_54,DAT_0009946c + 0x98a74);
    QTextStream::operator<<(pQVar4,(QString *)&local_54);
    if (*(int *)local_54 == 0) {
LAB_00098e28:
      QArrayData::deallocate(local_54,2,4);
      QVar1 = local_7c[0x14];
    }
    else {
      if (*(int *)local_54 != -1) {
        DataMemoryBarrier(0xb);
        do {
          iVar9 = *(int *)local_54;
          bVar2 = (bool)hasExclusiveAccess(local_54);
        } while (!bVar2);
        *(int *)local_54 = iVar9 + -1;
        DataMemoryBarrier(0xb);
        if (iVar9 + -1 == 0) goto LAB_00098e28;
      }
      QVar1 = local_7c[0x14];
    }
    if (QVar1 != (QTextStream)0x0) {
      QTextStream::operator<<(local_7c,' ');
    }
    QDir::currentPath();
    QDebug::putString(this_01,(uint)(local_78 + *(int *)(local_78 + 0xc)));
    if (local_7c[0x14] != (QTextStream)0x0) {
      QTextStream::operator<<(local_7c,' ');
    }
    local_70 = local_78;
    if (*(int *)local_78 == 0) {
LAB_00098dec:
      QArrayData::deallocate(local_70,2,4);
    }
    else if (*(int *)local_78 != -1) {
      DataMemoryBarrier(0xb);
      do {
        iVar9 = *(int *)local_78;
        bVar2 = (bool)hasExclusiveAccess(local_78);
      } while (!bVar2);
      *(int *)local_78 = iVar9 + -1;
      DataMemoryBarrier(0xb);
      if (iVar9 + -1 == 0) goto LAB_00098dec;
    }
LAB_00098b44:
    QDebug::~QDebug(this_01);
LAB_00098b4c:
    if (*(int *)local_84 == 0) goto LAB_00098b94;
    if (*(int *)local_84 == -1) {
      return;
    }
    DataMemoryBarrier(0xb);
    do {
      iVar9 = *(int *)local_84 + -1;
      bVar2 = (bool)hasExclusiveAccess(local_84);
    } while (!bVar2);
    *(int *)local_84 = iVar9;
  }
  else {
    sVar8 = -1;
    QString::operator=((QString *)&local_84,param_2);
LAB_000988e8:
    if (*(int *)(local_84 + 4) == 0) goto LAB_000988f8;
LAB_000987ec:
    iVar6 = QFile::exists((QString *)&local_84);
    if (iVar6 == 0) goto LAB_000988f8;
    QUrl::QUrl((QUrl *)&local_34,(QString *)&local_84,0);
    this_00 = operator_new(8);
    QQmlComponent::QQmlComponent
              (this_00,*(QQmlEngine **)(this + 8),(QUrl *)&local_34,(QObject *)0x0);
    *(QQmlComponent **)(this + 0xc) = this_00;
    QUrl::~QUrl((QUrl *)&local_34);
    piVar7 = *(int **)(this + 0xc);
    if (piVar7 == (int *)0x0) {
      this_01 = (QDebug *)&local_74;
      local_24 = DAT_00099470 + 0x98bc8;
      local_34 = 2;
      local_30 = piVar7;
      local_2c = piVar7;
      local_28 = piVar7;
      QMessageLogger::critical();
      pQVar4 = local_74;
      QString::fromUtf8_helper((char *)&local_50,DAT_00099474 + 0x98bf4);
      QTextStream::operator<<(pQVar4,(QString *)&local_50);
      if (*(int *)local_50 == 0) {
LAB_00099228:
        QArrayData::deallocate(local_50,2,4);
      }
      else if (*(int *)local_50 != -1) {
        DataMemoryBarrier(0xb);
        do {
          iVar9 = *(int *)local_50;
          bVar2 = (bool)hasExclusiveAccess(local_50);
        } while (!bVar2);
        *(int *)local_50 = iVar9 + -1;
        DataMemoryBarrier(0xb);
        if (iVar9 + -1 == 0) goto LAB_00099228;
      }
      if (local_74[0x14] != (QTextStream)0x0) {
        QTextStream::operator<<(local_74,' ');
      }
      QTextStream::operator<<(local_74,sVar8);
      if (local_74[0x14] != (QTextStream)0x0) {
        QTextStream::operator<<(local_74,' ');
      }
      pQVar4 = local_74;
      QString::fromUtf8_helper((char *)&local_4c,DAT_00099478 + 0x98c80);
      QTextStream::operator<<(pQVar4,(QString *)&local_4c);
      if (*(int *)local_4c == 0) {
LAB_00099258:
        QArrayData::deallocate(local_4c,2,4);
      }
      else if (*(int *)local_4c != -1) {
        DataMemoryBarrier(0xb);
        do {
          iVar9 = *(int *)local_4c;
          bVar2 = (bool)hasExclusiveAccess(local_4c);
        } while (!bVar2);
        *(int *)local_4c = iVar9 + -1;
        DataMemoryBarrier(0xb);
        if (iVar9 + -1 == 0) goto LAB_00099258;
      }
      if (local_74[0x14] != (QTextStream)0x0) {
        QTextStream::operator<<(local_74,' ');
      }
      QDebug::putString(this_01,(uint)(local_84 + *(int *)(local_84 + 0xc)));
      if (local_74[0x14] != (QTextStream)0x0) {
        QTextStream::operator<<(local_74,' ');
      }
      pQVar4 = local_74;
      QString::fromUtf8_helper((char *)&local_48,DAT_0009947c + 0x98d1c);
      QTextStream::operator<<(pQVar4,(QString *)&local_48);
      if (*(int *)local_48 == 0) {
LAB_00099248:
        QArrayData::deallocate(local_48,2,4);
      }
      else if (*(int *)local_48 != -1) {
        DataMemoryBarrier(0xb);
        do {
          iVar9 = *(int *)local_48;
          bVar2 = (bool)hasExclusiveAccess(local_48);
        } while (!bVar2);
        *(int *)local_48 = iVar9 + -1;
        DataMemoryBarrier(0xb);
        if (iVar9 + -1 == 0) goto LAB_00099248;
      }
      if (local_74[0x14] != (QTextStream)0x0) {
        QTextStream::operator<<(local_74,' ');
      }
      QDir::currentPath();
      QDebug::putString(this_01,(uint)(local_70 + *(int *)(local_70 + 0xc)));
      if (local_74[0x14] != (QTextStream)0x0) {
        QTextStream::operator<<(local_74,' ');
      }
      if (*(int *)local_70 != 0) {
        if (*(int *)local_70 != -1) {
          DataMemoryBarrier(0xb);
          do {
            iVar9 = *(int *)local_70;
            bVar2 = (bool)hasExclusiveAccess(local_70);
          } while (!bVar2);
          *(int *)local_70 = iVar9 + -1;
          DataMemoryBarrier(0xb);
          if (iVar9 + -1 == 0) goto LAB_00098dec;
        }
        goto LAB_00098b44;
      }
      goto LAB_00098dec;
    }
    iVar6 = (**(code **)(*piVar7 + 0x30))(piVar7,0);
    if (iVar6 == 0) {
      local_24 = DAT_00099480 + 0x98ecc;
      local_34 = 2;
      local_30 = (int *)iVar6;
      local_2c = (int *)iVar6;
      local_28 = (int *)iVar6;
      QMessageLogger::critical();
      pQVar4 = local_6c;
      QString::fromUtf8_helper((char *)&local_44,DAT_00099484 + 0x98ef8);
      QTextStream::operator<<(pQVar4,(QString *)&local_44);
      if (*(int *)local_44 == 0) {
LAB_00099238:
        QArrayData::deallocate(local_44,2,4);
      }
      else if (*(int *)local_44 != -1) {
        DataMemoryBarrier(0xb);
        do {
          iVar9 = *(int *)local_44;
          bVar2 = (bool)hasExclusiveAccess(local_44);
        } while (!bVar2);
        *(int *)local_44 = iVar9 + -1;
        DataMemoryBarrier(0xb);
        if (iVar9 + -1 == 0) goto LAB_00099238;
      }
      if (local_6c[0x14] != (QTextStream)0x0) {
        QTextStream::operator<<(local_6c,' ');
      }
      QTextStream::operator<<(local_6c,sVar8);
      if (local_6c[0x14] != (QTextStream)0x0) {
        QTextStream::operator<<(local_6c,' ');
      }
      pQVar4 = local_6c;
      QString::fromUtf8_helper((char *)&local_40,DAT_00099488 + 0x98f84);
      QTextStream::operator<<(pQVar4,(QString *)&local_40);
      if (*(int *)local_40 == 0) {
LAB_0009935c:
        QArrayData::deallocate(local_40,2,4);
      }
      else if (*(int *)local_40 != -1) {
        DataMemoryBarrier(0xb);
        do {
          iVar9 = *(int *)local_40;
          bVar2 = (bool)hasExclusiveAccess(local_40);
        } while (!bVar2);
        *(int *)local_40 = iVar9 + -1;
        DataMemoryBarrier(0xb);
        if (iVar9 + -1 == 0) goto LAB_0009935c;
      }
      if (local_6c[0x14] != (QTextStream)0x0) {
        QTextStream::operator<<(local_6c,' ');
      }
      QDebug::putString((QDebug *)&local_6c,(uint)(local_84 + *(int *)(local_84 + 0xc)));
      if (local_6c[0x14] != (QTextStream)0x0) {
        QTextStream::operator<<(local_6c,' ');
      }
      pQVar4 = local_6c;
      QString::fromUtf8_helper((char *)&local_3c,DAT_0009948c + 0x99020);
      QTextStream::operator<<(pQVar4,(QString *)&local_3c);
      if (*(int *)local_3c == 0) {
LAB_00099318:
        QArrayData::deallocate(local_3c,2,4);
      }
      else if (*(int *)local_3c != -1) {
        DataMemoryBarrier(0xb);
        do {
          iVar9 = *(int *)local_3c;
          bVar2 = (bool)hasExclusiveAccess(local_3c);
        } while (!bVar2);
        *(int *)local_3c = iVar9 + -1;
        DataMemoryBarrier(0xb);
        if (iVar9 + -1 == 0) goto LAB_00099318;
      }
      if (local_6c[0x14] != (QTextStream)0x0) {
        QTextStream::operator<<(local_6c,' ');
      }
      QDir::currentPath();
      QDebug::putString((QDebug *)&local_6c,(uint)(local_68 + *(int *)(local_68 + 0xc)));
      if (local_6c[0x14] != (QTextStream)0x0) {
        QTextStream::operator<<(local_6c,' ');
      }
      if (*(int *)local_68 == 0) {
LAB_000992d4:
        QArrayData::deallocate(local_68,2,4);
      }
      else if (*(int *)local_68 != -1) {
        DataMemoryBarrier(0xb);
        do {
          iVar9 = *(int *)local_68;
          bVar2 = (bool)hasExclusiveAccess(local_68);
        } while (!bVar2);
        *(int *)local_68 = iVar9 + -1;
        DataMemoryBarrier(0xb);
        if (iVar9 + -1 == 0) goto LAB_000992d4;
      }
      QDebug::~QDebug((QDebug *)&local_6c);
      local_34 = 2;
      local_24 = DAT_00099490 + 0x9911c;
      local_30 = (int *)0x0;
      local_2c = (int *)0x0;
      local_28 = (int *)0x0;
      QMessageLogger::critical();
      pQVar4 = local_64;
      QString::fromUtf8_helper((char *)&local_38,DAT_00099494 + 0x99148);
      QTextStream::operator<<(pQVar4,(QString *)&local_38);
      if (*(int *)local_38 == 0) {
LAB_000992f0:
        QArrayData::deallocate(local_38,2,4);
      }
      else if (*(int *)local_38 != -1) {
        DataMemoryBarrier(0xb);
        do {
          iVar9 = *(int *)local_38;
          bVar2 = (bool)hasExclusiveAccess(local_38);
        } while (!bVar2);
        *(int *)local_38 = iVar9 + -1;
        DataMemoryBarrier(0xb);
        if (iVar9 + -1 == 0) goto LAB_000992f0;
      }
      if (local_64[0x14] != (QTextStream)0x0) {
        QTextStream::operator<<(local_64,' ');
      }
      QQmlComponent::errorString();
      QDebug::putString((QDebug *)&local_64,(uint)(local_60 + *(int *)(local_60 + 0xc)));
      if (local_64[0x14] != (QTextStream)0x0) {
        QTextStream::operator<<(local_64,' ');
      }
      if (*(int *)local_60 == 0) {
LAB_000992c4:
        QArrayData::deallocate(local_60,2,4);
      }
      else if (*(int *)local_60 != -1) {
        DataMemoryBarrier(0xb);
        do {
          iVar9 = *(int *)local_60;
          bVar2 = (bool)hasExclusiveAccess(local_60);
        } while (!bVar2);
        *(int *)local_60 = iVar9 + -1;
        DataMemoryBarrier(0xb);
        if (iVar9 + -1 == 0) goto LAB_000992c4;
      }
      QDebug::~QDebug((QDebug *)&local_64);
      goto LAB_00098b4c;
    }
    uVar5 = QMetaObject::cast(*(QObject **)(iVar9 + DAT_0009945c));
    *(undefined4 *)(this + 4) = uVar5;
    QQmlEngine::setObjectOwnership(uVar5,0);
    QQuickItem::setParentItem(*(QQuickItem **)(this + 4));
    if (*(int *)(*(int *)param_2 + 4) == 0) {
      *(short *)(this + 0x144) = sVar8;
      set_all_properties(this);
    }
    if (*(int *)local_84 == 0) goto LAB_00098b94;
    if (*(int *)local_84 == -1) {
      return;
    }
    DataMemoryBarrier(0xb);
    do {
      iVar9 = *(int *)local_84 + -1;
      bVar2 = (bool)hasExclusiveAccess(local_84);
    } while (!bVar2);
    *(int *)local_84 = iVar9;
  }
  DataMemoryBarrier(0xb);
  if (iVar9 != 0) {
    return;
  }
LAB_00098b94:
  QArrayData::deallocate(local_84,2,4);
  return;
}



// UIComponent @ 00099498

/* ui_module::UIComponent::UIComponent(data_manager::settings::SETTING_REGULAR_STRUCT::DASH_STRUCT::SCREEN_STRUCT
   volatile*,
   data_manager::settings::SETTING_REGULAR_STRUCT::DASH_STRUCT::SCREEN_STRUCT::COMP_STRUCT
   volatile*, QQuickItem*, QQmlEngine*, unsigned int, unsigned int) */

UIComponent * __thiscall
ui_module::UIComponent::UIComponent
          (UIComponent *this,SCREEN_STRUCT *param_1,COMP_STRUCT *param_2,QQuickItem *param_3,
          QQmlEngine *param_4,uint param_5,uint param_6)

{
  bool bVar1;
  int iVar2;
  undefined4 uVar3;
  int iVar4;
  QArrayData *pQVar5;
  int iVar6;
  QArrayData *local_2c [2];
  
  iVar4 = DAT_000995d0;
  iVar6 = DAT_000995cc + 0x994b4;
  *(undefined4 *)(this + 4) = 0;
  *(undefined4 *)(this + 0xc) = 0;
  iVar2 = DAT_000995d4;
  pQVar5 = *(QArrayData **)(iVar6 + iVar4);
  *(QArrayData **)(this + 0x140) = pQVar5;
  *(undefined2 *)(this + 0x144) = 0;
  *(QArrayData **)(this + 0x150) = pQVar5;
  *(QArrayData **)(this + 0x154) = pQVar5;
  uVar3 = QString::fromAscii_helper((char *)(iVar2 + 0x994e8),0xd);
  *(undefined4 *)(this + 0x158) = uVar3;
  *(QQuickItem **)this = param_3;
  *(COMP_STRUCT **)(this + 0x40) = param_2;
  *(SCREEN_STRUCT **)(this + 0x24) = param_1;
  *(QQmlEngine **)(this + 8) = param_4;
  *(uint *)(this + 0x148) = param_5;
  *(uint *)(this + 0x14c) = param_6;
  *(undefined4 *)(this + 0x28) = 0;
  *(undefined4 *)(this + 0x10) = 0;
  local_2c[0] = pQVar5;
  reload_component(this,local_2c);
  if (*(int *)local_2c[0] == 0) {
LAB_00099584:
    QArrayData::deallocate(local_2c[0],2,4);
    return this;
  }
  if (*(int *)local_2c[0] != -1) {
    DataMemoryBarrier(0xb);
    do {
      iVar4 = *(int *)local_2c[0];
      bVar1 = (bool)hasExclusiveAccess(local_2c[0]);
    } while (!bVar1);
    *(int *)local_2c[0] = iVar4 + -1;
    DataMemoryBarrier(0xb);
    if (iVar4 + -1 == 0) goto LAB_00099584;
  }
  return this;
}



// UIComponent @ 000995d8

/* ui_module::UIComponent::UIComponent(QQuickItem*, QQmlEngine*, QString) */

UIComponent * __thiscall
ui_module::UIComponent::UIComponent(UIComponent *this,undefined4 param_1,undefined4 param_2)

{
  bool bVar1;
  int iVar2;
  QArrayData *pQVar3;
  int iVar4;
  int iVar5;
  undefined4 uVar6;
  QArrayData *local_24;
  QArrayData *local_20;
  QArrayData *local_1c;
  
  iVar4 = DAT_0009995c;
  iVar5 = DAT_00099958 + 0x995f4;
  *(undefined4 *)(this + 4) = 0;
  *(undefined4 *)(this + 0xc) = 0;
  iVar2 = DAT_00099960;
  uVar6 = *(undefined4 *)(iVar5 + iVar4);
  *(undefined4 *)(this + 0x140) = uVar6;
  *(undefined2 *)(this + 0x144) = 0;
  *(undefined4 *)(this + 0x150) = uVar6;
  *(undefined4 *)(this + 0x154) = uVar6;
  uVar6 = QString::fromAscii_helper((char *)(iVar2 + 0x9962c),0xd);
  *(undefined4 *)(this + 0x158) = uVar6;
  iVar4 = DAT_00099964;
  *(undefined4 *)this = param_1;
  *(undefined4 *)(this + 8) = param_2;
  pQVar3 = (QArrayData *)QString::fromAscii_helper((char *)(iVar4 + 0x99650),0x37);
  if (1 < *(int *)pQVar3 + 1U) {
    DataMemoryBarrier(0xb);
    do {
      bVar1 = (bool)hasExclusiveAccess(pQVar3);
    } while (!bVar1);
    *(int *)pQVar3 = *(int *)pQVar3 + 1;
    DataMemoryBarrier(0xb);
  }
  local_20 = pQVar3;
  QString::fromUtf8_helper((char *)&local_1c,DAT_00099968 + 0x9969c);
  QString::append((QString *)&local_20);
  if (*(int *)local_1c == 0) {
LAB_000998d8:
    QArrayData::deallocate(local_1c,2,4);
  }
  else if (*(int *)local_1c != -1) {
    DataMemoryBarrier(0xb);
    do {
      iVar4 = *(int *)local_1c;
      bVar1 = (bool)hasExclusiveAccess(local_1c);
    } while (!bVar1);
    *(int *)local_1c = iVar4 + -1;
    DataMemoryBarrier(0xb);
    if (iVar4 + -1 == 0) goto LAB_000998d8;
  }
  local_24 = local_20;
  if (1 < *(int *)local_20 + 1U) {
    DataMemoryBarrier(0xb);
    do {
      bVar1 = (bool)hasExclusiveAccess(local_20);
    } while (!bVar1);
    *(int *)local_20 = *(int *)local_20 + 1;
    DataMemoryBarrier(0xb);
  }
  QString::append((QString *)&local_24);
  if (*(int *)local_20 == 0) {
LAB_000998c8:
    QArrayData::deallocate(local_20,2,4);
  }
  else if (*(int *)local_20 != -1) {
    DataMemoryBarrier(0xb);
    do {
      iVar4 = *(int *)local_20;
      bVar1 = (bool)hasExclusiveAccess(local_20);
    } while (!bVar1);
    *(int *)local_20 = iVar4 + -1;
    DataMemoryBarrier(0xb);
    if (iVar4 + -1 == 0) goto LAB_000998c8;
  }
  local_1c = local_24;
  if (1 < *(int *)local_24 + 1U) {
    DataMemoryBarrier(0xb);
    do {
      bVar1 = (bool)hasExclusiveAccess(local_24);
    } while (!bVar1);
    *(int *)local_24 = *(int *)local_24 + 1;
    DataMemoryBarrier(0xb);
  }
  reload_component(this,&local_1c);
  if (*(int *)local_1c == 0) {
LAB_000998b8:
    QArrayData::deallocate(local_1c,2,4);
  }
  else if (*(int *)local_1c != -1) {
    DataMemoryBarrier(0xb);
    do {
      iVar4 = *(int *)local_1c;
      bVar1 = (bool)hasExclusiveAccess(local_1c);
    } while (!bVar1);
    *(int *)local_1c = iVar4 + -1;
    DataMemoryBarrier(0xb);
    if (iVar4 + -1 == 0) goto LAB_000998b8;
  }
  if (*(int *)(this + 4) != 0) {
    QQuickItem::setVisible(SUB41(*(int *)(this + 4),0));
  }
  if (*(int *)local_24 == 0) {
LAB_000998a8:
    QArrayData::deallocate(local_24,2,4);
  }
  else if (*(int *)local_24 != -1) {
    DataMemoryBarrier(0xb);
    do {
      iVar4 = *(int *)local_24;
      bVar1 = (bool)hasExclusiveAccess(local_24);
    } while (!bVar1);
    *(int *)local_24 = iVar4 + -1;
    DataMemoryBarrier(0xb);
    if (iVar4 + -1 == 0) goto LAB_000998a8;
  }
  if (*(int *)pQVar3 == 0) {
LAB_00099890:
    QArrayData::deallocate(pQVar3,2,4);
    return this;
  }
  if (*(int *)pQVar3 != -1) {
    DataMemoryBarrier(0xb);
    do {
      iVar4 = *(int *)pQVar3;
      bVar1 = (bool)hasExclusiveAccess(pQVar3);
    } while (!bVar1);
    *(int *)pQVar3 = iVar4 + -1;
    DataMemoryBarrier(0xb);
    if (iVar4 + -1 == 0) goto LAB_00099890;
  }
  return this;
}



// get_component @ 0009f088

/* ui_module::UIScreen::get_component(unsigned int) */

undefined4 __thiscall ui_module::UIScreen::get_component(UIScreen *this,uint param_1)

{
  undefined4 uVar1;
  
  if (param_1 < 100) {
    uVar1 = *(undefined4 *)(this + param_1 * 4 + 0xc);
  }
  else {
    uVar1 = 0;
  }
  return uVar1;
}



// reload_component @ 0009f640

/* ui_module::UIScreen::reload_component(unsigned int) */

void __thiscall ui_module::UIScreen::reload_component(UIScreen *this,uint param_1)

{
  bool bVar1;
  QTextStream *pQVar2;
  QQmlEngine *pQVar3;
  char *pcVar4;
  int iVar5;
  UIComponent *pUVar6;
  QTextStream *local_40;
  QArrayData *local_3c;
  QArrayData *local_38;
  undefined4 local_34;
  undefined4 local_30;
  undefined4 local_2c;
  undefined4 local_28;
  int local_24;
  
  if ((param_1 < 0x65) && (iVar5 = *(int *)this, iVar5 != 0)) {
    pUVar6 = *(UIComponent **)(this + param_1 * 4 + 0xc);
    if (pUVar6 != (UIComponent *)0x0) {
      UIComponent::~UIComponent(pUVar6);
      operator_delete(pUVar6,0x15c);
      *(undefined4 *)(this + param_1 * 4 + 0xc) = 0;
      iVar5 = *(int *)this;
    }
    if (*(ushort *)(iVar5 + param_1 * 0xfc + 0x124) - 2 < 0x10) {
      pQVar3 = (QQmlEngine *)QQuickView::engine();
      pUVar6 = operator_new(0x15c);
      UIComponent::UIComponent
                (pUVar6,*(SCREEN_STRUCT **)this,
                 (COMP_STRUCT *)(*(SCREEN_STRUCT **)this + param_1 * 0xfc + 0xa8),
                 *(QQuickItem **)(this + 4),pQVar3,*(uint *)(this + 0x1a0),param_1);
      *(UIComponent **)(this + param_1 * 4 + 0xc) = pUVar6;
      return;
    }
    *(undefined4 *)(this + param_1 * 4 + 0xc) = 0;
    return;
  }
  local_24 = DAT_0009f914 + 0x9f72c;
  local_34 = 2;
  local_30 = 0;
  local_2c = 0;
  local_28 = 0;
  QMessageLogger::warning();
  pQVar2 = local_40;
  QString::fromUtf8_helper((char *)&local_3c,DAT_0009f918 + 0x9f75c);
  QTextStream::operator<<(pQVar2,(QString *)&local_3c);
  if (*(int *)local_3c == 0) {
LAB_0009f8d8:
    QArrayData::deallocate(local_3c,2,4);
  }
  else if (*(int *)local_3c != -1) {
    DataMemoryBarrier(0xb);
    do {
      iVar5 = *(int *)local_3c;
      bVar1 = (bool)hasExclusiveAccess(local_3c);
    } while (!bVar1);
    *(int *)local_3c = iVar5 + -1;
    DataMemoryBarrier(0xb);
    if (iVar5 + -1 == 0) goto LAB_0009f8d8;
  }
  if (local_40[0x14] != (QTextStream)0x0) {
    QTextStream::operator<<(local_40,' ');
  }
  QTextStream::operator<<(local_40,param_1);
  if (local_40[0x14] != (QTextStream)0x0) {
    QTextStream::operator<<(local_40,' ');
  }
  pQVar2 = local_40;
  QString::fromUtf8_helper((char *)&local_38,DAT_0009f91c + 0x9f7e8);
  QTextStream::operator<<(pQVar2,(QString *)&local_38);
  if (*(int *)local_38 != 0) {
    if (*(int *)local_38 == -1) goto LAB_0009f834;
    DataMemoryBarrier(0xb);
    do {
      iVar5 = *(int *)local_38;
      bVar1 = (bool)hasExclusiveAccess(local_38);
    } while (!bVar1);
    *(int *)local_38 = iVar5 + -1;
    DataMemoryBarrier(0xb);
    if (iVar5 + -1 != 0) goto LAB_0009f834;
  }
  QArrayData::deallocate(local_38,2,4);
LAB_0009f834:
  if (local_40[0x14] != (QTextStream)0x0) {
    QTextStream::operator<<(local_40,' ');
  }
  if (*(int *)this == 0) {
    pcVar4 = (char *)(DAT_0009f920 + 0x9f85c);
  }
  else {
    pcVar4 = (char *)(DAT_0009f924 + 0x9f888);
  }
  QTextStream::operator<<(local_40,pcVar4);
  if (local_40[0x14] != (QTextStream)0x0) {
    QTextStream::operator<<(local_40,' ');
  }
  QDebug::~QDebug((QDebug *)&local_40);
  return;
}



// reload_all_components @ 0009f928

/* ui_module::UIScreen::reload_all_components() */

void __thiscall ui_module::UIScreen::reload_all_components(UIScreen *this)

{
  uint uVar1;
  
  uVar1 = 0;
  *(undefined4 *)(this + 0x19c) = 0;
  do {
    reload_component(this,uVar1);
    uVar1 = uVar1 + 1;
    *(int *)(this + 0x19c) = *(int *)(this + 0x19c) + 1;
  } while (uVar1 != 100);
  return;
}



// purge_all_components @ 0009fae4

/* ui_module::UIScreen::purge_all_components() */

void __thiscall ui_module::UIScreen::purge_all_components(UIScreen *this)

{
  UIScreen *pUVar1;
  UIComponent *this_00;
  
  pUVar1 = this + 0xc;
  do {
    this_00 = *(UIComponent **)pUVar1;
    if (this_00 != (UIComponent *)0x0) {
      UIComponent::~UIComponent(this_00);
      operator_delete(this_00,0x15c);
      *(undefined4 *)pUVar1 = 0;
    }
    pUVar1 = pUVar1 + 4;
  } while (pUVar1 != this + 0x19c);
  *(undefined4 *)(this + 0x19c) = 0;
  return;
}



// QQmlComponent @ 001e1154

/* WARNING: Control flow encountered bad instruction data */

void __thiscall
QQmlComponent::QQmlComponent(QQmlComponent *this,QQmlEngine *param_1,QUrl *param_2,QObject *param_3)

{
                    /* WARNING: Bad instruction - Truncating control flow here */
                    /* _ZN13QQmlComponentC1EP10QQmlEngineRK4QUrlP7QObject@@Qt_5 */
  halt_baddata();
}



