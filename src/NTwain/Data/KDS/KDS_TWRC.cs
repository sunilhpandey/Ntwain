using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTwain.Data.Kds;

public enum KDS_TWRC : ushort
{
    BUSY = 0x8001,
    PCARD_CHECKSTATUS = 0x8002,
    PCARD_FATAL = 0x8003,
    PCARD_RETRYIMAGE = 0x8004,
    PCARD_NOCARD = 0x8005,
    FILTER_CONTINUE = 0x8010,
}
