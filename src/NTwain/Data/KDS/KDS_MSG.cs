using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTwain.Data.Kds;

public enum KDS_MSG : ushort
{
    SETUPDS = 0x8002,
    DISABLEUI = 0x8003,
    ENABLEUI = 0x8004,
    GETSPECIAL = 0x8005,
    ENABLESCANNER = 0x8006,
    /// <summary>
    /// Deprecated TWAIN 10.x+
    /// </summary>
    SAVEPROFILE = 0x8008,
    /// <summary>
    /// Deprecated TWAIN 10.x+
    /// </summary>
    DELETEPROFILE = 0x8009,
    // Reserved =0x8007, =0x800A - =0x8010, =0x8013 - =0x8014, =0x801F
    ADDWINDOW = 0x8011,
    DELETEWINDOW = 0x8012,
    PROFILECREATE = 0x8015,
    PROFILEDELETE = 0x8016,
    PROFILESAVE = 0x8017,
    PROFILERENAME = 0x8018,
    PROFILERESTORE = 0x8019,
    PROFILEEXPORT = 0x801A,
    PROFILEIMPORT = 0x801B,
    PROFILESET = 0x801C,
    GETINQUIRY = 0x801D,
    ENDXFERSPECIAL = 0x801E,
    RESOURCELOCK = 0x801F,
    RESOURCEUNLOCK = 0x8020
}
