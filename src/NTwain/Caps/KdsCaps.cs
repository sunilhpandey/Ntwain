using NTwain.Data;
using NTwain.Data.Kds;
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


    CapWriter<TWBM>? _CAP_BLANKPAGEMODE;
    public CapWriter<TWBM> CAP_BLANKPAGEMODE =>
        _CAP_BLANKPAGEMODE ??= new(_twain, (CAP)KDS_CAP.CAP_BLANKPAGEMODE, 2);


    CapWriter<uint>? _CAP_BLANKPAGECONTENT;
    public CapWriter<uint> CAP_BLANKPAGECONTENT =>
        _CAP_BLANKPAGECONTENT ??= new(_twain, (CAP)KDS_CAP.CAP_BLANKPAGECONTENT, 2);


    CapWriter<uint>? _CAP_BLANKPAGECOMPSIZEBW;
    public CapWriter<uint> CAP_BLANKPAGECOMPSIZEBW =>
        _CAP_BLANKPAGECOMPSIZEBW ??= new(_twain, (CAP)KDS_CAP.CAP_BLANKPAGECOMPSIZEBW, 2);


    CapWriter<uint>? _CAP_BLANKPAGECOMPSIZEGRAY;
    public CapWriter<uint> CAP_BLANKPAGECOMPSIZEGRAY =>
        _CAP_BLANKPAGECOMPSIZEGRAY ??= new(_twain, (CAP)KDS_CAP.CAP_BLANKPAGECOMPSIZEGRAY, 2);


    CapWriter<uint>? _CAP_BLANKPAGECOMPSIZERGB;
    public CapWriter<uint> CAP_BLANKPAGECOMPSIZERGB =>
        _CAP_BLANKPAGECOMPSIZERGB ??= new(_twain, (CAP)KDS_CAP.CAP_BLANKPAGECOMPSIZERGB, 2);



    CapWriter<TWBK>? _CAP_BACKGROUND;
    public CapWriter<TWBK> CAP_BACKGROUND =>
        _CAP_BACKGROUND ??= new(_twain, (CAP)KDS_CAP.CAP_BACKGROUND, 2);
}
