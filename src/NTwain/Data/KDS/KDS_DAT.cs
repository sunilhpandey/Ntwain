using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTwain.Data.KDS;

public enum KDS_DAT : ushort
{
    STATUSRAW = 0x8001,
    PCARD = 0x8002,
    COLORTABLEMAP = 0x8003,
    DEVICEINFO = 0x8005,
    AUTOCOLORLEARN = 0x8006,
    PROFILES = 0x8007,
    WINDOW = 0x8008,
    CUSTOMDSDATAGROUP = 0x8009,
    ECDO = 0x800A,
    QUERYSUPPORT = 0x800B,
    LOG = 0x800C,
    UTC = 0x800D,
    OCPBUTTONS = 0x800E,
    CONSUMABLEMETERS = 0x8010
}
