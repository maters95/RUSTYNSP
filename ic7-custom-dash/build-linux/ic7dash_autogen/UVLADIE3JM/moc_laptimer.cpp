/****************************************************************************
** Meta object code from reading C++ file 'laptimer.h'
**
** Created by: The Qt Meta Object Compiler version 67 (Qt 5.15.13)
**
** WARNING! All changes made in this file will be lost!
*****************************************************************************/

#include <memory>
#include "../../../src/laptimer.h"
#include <QtCore/qbytearray.h>
#include <QtCore/qmetatype.h>
#if !defined(Q_MOC_OUTPUT_REVISION)
#error "The header file 'laptimer.h' doesn't include <QObject>."
#elif Q_MOC_OUTPUT_REVISION != 67
#error "This file was generated using the moc from 5.15.13. It"
#error "cannot be used with the include files from this version of Qt."
#error "(The moc has changed too much.)"
#endif

QT_BEGIN_MOC_NAMESPACE
QT_WARNING_PUSH
QT_WARNING_DISABLE_DEPRECATED
struct qt_meta_stringdata_LapTimer_t {
    QByteArrayData data[21];
    char stringdata0[159];
};
#define QT_MOC_LITERAL(idx, ofs, len) \
    Q_STATIC_BYTE_ARRAY_DATA_HEADER_INITIALIZER_WITH_OFFSET(len, \
    qptrdiff(offsetof(qt_meta_stringdata_LapTimer_t, stringdata0) + ofs \
        - idx * sizeof(QByteArrayData)) \
    )
static const qt_meta_stringdata_LapTimer_t qt_meta_stringdata_LapTimer = {
    {
QT_MOC_LITERAL(0, 0, 8), // "LapTimer"
QT_MOC_LITERAL(1, 9, 11), // "lapsChanged"
QT_MOC_LITERAL(2, 21, 0), // ""
QT_MOC_LITERAL(3, 22, 4), // "tick"
QT_MOC_LITERAL(4, 27, 12), // "armedChanged"
QT_MOC_LITERAL(5, 40, 12), // "lapCompleted"
QT_MOC_LITERAL(6, 53, 2), // "ms"
QT_MOC_LITERAL(7, 56, 13), // "setFinishLine"
QT_MOC_LITERAL(8, 70, 4), // "lat1"
QT_MOC_LITERAL(9, 75, 4), // "lon1"
QT_MOC_LITERAL(10, 80, 4), // "lat2"
QT_MOC_LITERAL(11, 85, 4), // "lon2"
QT_MOC_LITERAL(12, 90, 6), // "addFix"
QT_MOC_LITERAL(13, 97, 3), // "lat"
QT_MOC_LITERAL(14, 101, 3), // "lon"
QT_MOC_LITERAL(15, 105, 5), // "reset"
QT_MOC_LITERAL(16, 111, 8), // "lapCount"
QT_MOC_LITERAL(17, 120, 12), // "currentLapMs"
QT_MOC_LITERAL(18, 133, 9), // "lastLapMs"
QT_MOC_LITERAL(19, 143, 9), // "bestLapMs"
QT_MOC_LITERAL(20, 153, 5) // "armed"

    },
    "LapTimer\0lapsChanged\0\0tick\0armedChanged\0"
    "lapCompleted\0ms\0setFinishLine\0lat1\0"
    "lon1\0lat2\0lon2\0addFix\0lat\0lon\0reset\0"
    "lapCount\0currentLapMs\0lastLapMs\0"
    "bestLapMs\0armed"
};
#undef QT_MOC_LITERAL

static const uint qt_meta_data_LapTimer[] = {

 // content:
       8,       // revision
       0,       // classname
       0,    0, // classinfo
       7,   14, // methods
       5,   70, // properties
       0,    0, // enums/sets
       0,    0, // constructors
       0,       // flags
       4,       // signalCount

 // signals: name, argc, parameters, tag, flags
       1,    0,   49,    2, 0x06 /* Public */,
       3,    0,   50,    2, 0x06 /* Public */,
       4,    0,   51,    2, 0x06 /* Public */,
       5,    1,   52,    2, 0x06 /* Public */,

 // slots: name, argc, parameters, tag, flags
       7,    4,   55,    2, 0x0a /* Public */,
      12,    2,   64,    2, 0x0a /* Public */,
      15,    0,   69,    2, 0x0a /* Public */,

 // signals: parameters
    QMetaType::Void,
    QMetaType::Void,
    QMetaType::Void,
    QMetaType::Void, QMetaType::Double,    6,

 // slots: parameters
    QMetaType::Void, QMetaType::Double, QMetaType::Double, QMetaType::Double, QMetaType::Double,    8,    9,   10,   11,
    QMetaType::Void, QMetaType::Double, QMetaType::Double,   13,   14,
    QMetaType::Void,

 // properties: name, type, flags
      16, QMetaType::Int, 0x00495001,
      17, QMetaType::Double, 0x00495001,
      18, QMetaType::Double, 0x00495001,
      19, QMetaType::Double, 0x00495001,
      20, QMetaType::Bool, 0x00495001,

 // properties: notify_signal_id
       0,
       1,
       0,
       0,
       2,

       0        // eod
};

void LapTimer::qt_static_metacall(QObject *_o, QMetaObject::Call _c, int _id, void **_a)
{
    if (_c == QMetaObject::InvokeMetaMethod) {
        auto *_t = static_cast<LapTimer *>(_o);
        (void)_t;
        switch (_id) {
        case 0: _t->lapsChanged(); break;
        case 1: _t->tick(); break;
        case 2: _t->armedChanged(); break;
        case 3: _t->lapCompleted((*reinterpret_cast< double(*)>(_a[1]))); break;
        case 4: _t->setFinishLine((*reinterpret_cast< double(*)>(_a[1])),(*reinterpret_cast< double(*)>(_a[2])),(*reinterpret_cast< double(*)>(_a[3])),(*reinterpret_cast< double(*)>(_a[4]))); break;
        case 5: _t->addFix((*reinterpret_cast< double(*)>(_a[1])),(*reinterpret_cast< double(*)>(_a[2]))); break;
        case 6: _t->reset(); break;
        default: ;
        }
    } else if (_c == QMetaObject::IndexOfMethod) {
        int *result = reinterpret_cast<int *>(_a[0]);
        {
            using _t = void (LapTimer::*)();
            if (*reinterpret_cast<_t *>(_a[1]) == static_cast<_t>(&LapTimer::lapsChanged)) {
                *result = 0;
                return;
            }
        }
        {
            using _t = void (LapTimer::*)();
            if (*reinterpret_cast<_t *>(_a[1]) == static_cast<_t>(&LapTimer::tick)) {
                *result = 1;
                return;
            }
        }
        {
            using _t = void (LapTimer::*)();
            if (*reinterpret_cast<_t *>(_a[1]) == static_cast<_t>(&LapTimer::armedChanged)) {
                *result = 2;
                return;
            }
        }
        {
            using _t = void (LapTimer::*)(double );
            if (*reinterpret_cast<_t *>(_a[1]) == static_cast<_t>(&LapTimer::lapCompleted)) {
                *result = 3;
                return;
            }
        }
    }
#ifndef QT_NO_PROPERTIES
    else if (_c == QMetaObject::ReadProperty) {
        auto *_t = static_cast<LapTimer *>(_o);
        (void)_t;
        void *_v = _a[0];
        switch (_id) {
        case 0: *reinterpret_cast< int*>(_v) = _t->lapCount(); break;
        case 1: *reinterpret_cast< double*>(_v) = _t->currentLapMs(); break;
        case 2: *reinterpret_cast< double*>(_v) = _t->lastLapMs(); break;
        case 3: *reinterpret_cast< double*>(_v) = _t->bestLapMs(); break;
        case 4: *reinterpret_cast< bool*>(_v) = _t->armed(); break;
        default: break;
        }
    } else if (_c == QMetaObject::WriteProperty) {
    } else if (_c == QMetaObject::ResetProperty) {
    }
#endif // QT_NO_PROPERTIES
}

QT_INIT_METAOBJECT const QMetaObject LapTimer::staticMetaObject = { {
    QMetaObject::SuperData::link<QObject::staticMetaObject>(),
    qt_meta_stringdata_LapTimer.data,
    qt_meta_data_LapTimer,
    qt_static_metacall,
    nullptr,
    nullptr
} };


const QMetaObject *LapTimer::metaObject() const
{
    return QObject::d_ptr->metaObject ? QObject::d_ptr->dynamicMetaObject() : &staticMetaObject;
}

void *LapTimer::qt_metacast(const char *_clname)
{
    if (!_clname) return nullptr;
    if (!strcmp(_clname, qt_meta_stringdata_LapTimer.stringdata0))
        return static_cast<void*>(this);
    return QObject::qt_metacast(_clname);
}

int LapTimer::qt_metacall(QMetaObject::Call _c, int _id, void **_a)
{
    _id = QObject::qt_metacall(_c, _id, _a);
    if (_id < 0)
        return _id;
    if (_c == QMetaObject::InvokeMetaMethod) {
        if (_id < 7)
            qt_static_metacall(this, _c, _id, _a);
        _id -= 7;
    } else if (_c == QMetaObject::RegisterMethodArgumentMetaType) {
        if (_id < 7)
            *reinterpret_cast<int*>(_a[0]) = -1;
        _id -= 7;
    }
#ifndef QT_NO_PROPERTIES
    else if (_c == QMetaObject::ReadProperty || _c == QMetaObject::WriteProperty
            || _c == QMetaObject::ResetProperty || _c == QMetaObject::RegisterPropertyMetaType) {
        qt_static_metacall(this, _c, _id, _a);
        _id -= 5;
    } else if (_c == QMetaObject::QueryPropertyDesignable) {
        _id -= 5;
    } else if (_c == QMetaObject::QueryPropertyScriptable) {
        _id -= 5;
    } else if (_c == QMetaObject::QueryPropertyStored) {
        _id -= 5;
    } else if (_c == QMetaObject::QueryPropertyEditable) {
        _id -= 5;
    } else if (_c == QMetaObject::QueryPropertyUser) {
        _id -= 5;
    }
#endif // QT_NO_PROPERTIES
    return _id;
}

// SIGNAL 0
void LapTimer::lapsChanged()
{
    QMetaObject::activate(this, &staticMetaObject, 0, nullptr);
}

// SIGNAL 1
void LapTimer::tick()
{
    QMetaObject::activate(this, &staticMetaObject, 1, nullptr);
}

// SIGNAL 2
void LapTimer::armedChanged()
{
    QMetaObject::activate(this, &staticMetaObject, 2, nullptr);
}

// SIGNAL 3
void LapTimer::lapCompleted(double _t1)
{
    void *_a[] = { nullptr, const_cast<void*>(reinterpret_cast<const void*>(std::addressof(_t1))) };
    QMetaObject::activate(this, &staticMetaObject, 3, _a);
}
QT_WARNING_POP
QT_END_MOC_NAMESPACE
