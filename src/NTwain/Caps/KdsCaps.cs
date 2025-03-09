using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTwain.Caps;

/// <summary>
/// Provides reader/writer wrapper of known <see cref="NTwain.Data.Kds.KDS_CAP"/>s.
/// </summary>
public partial class KdsCaps
{
    protected readonly TwainAppSession _twain;

    public KdsCaps(TwainAppSession twain)
    {
        _twain = twain;
    }

}
