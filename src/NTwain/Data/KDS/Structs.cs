using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


using TW_HANDLE = System.IntPtr;
using TW_MEMREF = System.IntPtr;
using TW_UINTPTR = System.UIntPtr;

using TW_INT8 = System.SByte;
using TW_INT16 = System.Int16;
using TW_INT32 = System.Int32; // (was long on Linux 64 - bit)

using TW_UINT8 = System.Byte;
using TW_UINT16 = System.UInt16;

using TW_UINT32 = System.UInt32; //(was ulong on Linux 64 - bit)
using TW_BOOL = System.UInt16;

namespace NTwain.Data.Kds;

[StructLayout(LayoutKind.Sequential, Pack = 2)]
public struct TW_COLORTABLEMAP
{
    public TW_UINT16 ColorTableValue;
    public TW_STR255 szEnglish;
    public TW_STR255 szCurrent;
}

[StructLayout(LayoutKind.Sequential, Pack = 2)]
public struct TW_CONSUMABLEMETERINFO
{
    public TW_UINT16 MeterType;     // TWCONMTR_* value identifying the meter type.
    public TW_UINT32 FieldFlags;    // Bit mask of TWCONMTR_FIELD_* values, if a bit is present it means
                                    // that the associated field contains valid data for a MSG_GET or a
                                    // MSG_SET operation
    public TW_UINT32 Frequency;     // How often (in pages) maintenance should be performed.
    public TW_UINT32 LastReset;     // The value of the page count meter when maintenance was last performed.
    public TW_UINT32 Reminder;      // How many pages prior to maintenance being required that the user
                                    // should be reminded.  This interval also drives how often the user
                                    // is reminded after the maintenance deadline is passed.

    public unsafe fixed TW_UINT8 Reserved[512]; // Reserved
}

[StructLayout(LayoutKind.Sequential, Pack = 2)]
public struct TW_CONSUMABLEMETERS
{
    public TW_UINT32 Total;                  // Number of TW_CONSUMABLEMETERINFO structures.
    public TW_CONSUMABLEMETERINFO ConsumableMeterInfo; // First item of an array of Total
}

[StructLayout(LayoutKind.Sequential, Pack = 2)]
public struct TW_DEVICEINFO
{
    public TW_UINT32 dwFields;
    public TW_UINT32 dwModelNumber;             // field 01
    public TW_STR255 szModelName;               // field 02
    public TW_STR255 szProtocol;                // field 03
    public TW_STR255 szDeviceName;              // field 04
    public TW_UINT32 dwHostAdapter;             // field 05
    public TW_UINT32 dwTarget;                  // field 06
                                                // put new fields here...
    public TW_STR255 szDeviceChange;            // field 07  + 256 =  256
    public TW_UINT32 dwFirmware;                // field 08  +  32 =  288
    public TW_STR255 szDriverFilename;         // field 09  + 256 =  544
                                               // added Jun 14th, 2016
    public TW_UINT32 dwSorterFlags;                // field 10  +   4 =  548
                                                   // always reduce this whenever adding new fields!!!
    public unsafe fixed TW_UINT8 reserved[65536 - 548];
}

[StructLayout(LayoutKind.Sequential, Pack = 2)]
public struct TW_ECDO
{
    public TW_UINT16 EcdoValue;
    public TW_STR255 szEcdo;
    public TW_STR255 szText;
    public unsafe fixed TW_UINT8 Reserved[1024];            // Room for more stuff
}

[StructLayout(LayoutKind.Sequential, Pack = 2)]
public struct TW_LOG
{
    public TW_UINT16 LogType;          // log to get (see TWGL_*)
    public TW_UINT16 DeviceType;           // ADF or Flatbed (see TWDV_*)
    public TW_STR255 Filename;         // full path and name to store log into
    public TW_STR255 Description;      // Reason for log (use with TWLG_EKLOG)
    public TW_BOOL SaveImages;         // Save images (use with TWLG_EKLOG)
    public unsafe fixed TW_UINT8 Reserved[254];     // Room for future expansion
}

[StructLayout(LayoutKind.Sequential, Pack = 2)]
public struct DAT_OCPBUTTONS
{
    public TW_STR255 Text;             // Displayed text on OCP for a button
    public TW_UINT32 NumDataFields;        // Bit mask indicating what fields have
                                           //    been filled in for configuring
                                           //    the OCP (see TWOCPS_* defines)
    public TW_UINT32 PaperSource;      // TWPU_* enum from CAP_PAPERSOURCE
    public TW_STR255 szGraphicFilename;    // Displayed graphic on OCP for a button
    public TW_UINT32 GraphicLocation;  // How graphic and text are drawn on the
                                       //    the OCP (see TWOCPG_* defines)
    public unsafe fixed TW_UINT8 Reserved[244];     // Room for future expansion (MUST be zero)
}

[StructLayout(LayoutKind.Sequential, Pack = 2)]
public struct TW_PCARD
{
    public TW_UINT32 StructSize;
    public TW_UINT32 Action;
    public TW_UINT32 DataSize;
    public TW_MEMREF Data;
}

[StructLayout(LayoutKind.Sequential, Pack = 2)]
public unsafe struct TW_PCARD_INQUIRY
{
    public fixed TW_INT8 StructSize[4];             // 0-3
    public fixed TW_INT8 VendorId[8];               // 4-11
    public fixed TW_INT8 ProductId[16];             // 12-27
    public fixed TW_INT8 RevisionNumber[4];         // 28-31
    public fixed TW_INT8 BuildNumber[2];            // 32-33
    public fixed TW_INT8 Reserved[2048 - 34];         // 34-2048
}

[StructLayout(LayoutKind.Sequential, Pack = 2)]
public unsafe struct TW_PCARD_STATUS
{
    public fixed TW_INT8 StructSize[4];             // 0-3
    public fixed TW_INT8 Code[4];                   // 4-7
    public TW_INT8 Severity;                  // 8
    public fixed TW_INT8 Text[1011];                // 9-1019
    public fixed TW_INT8 Reserved[2048 - 1020];       // 1020-2048
}

[StructLayout(LayoutKind.Sequential, Pack = 2)]
public struct TW_PCARD_ATTRIBUTES
{
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
    public TW_INT8[] StructSize;             // 0-3
}

[StructLayout(LayoutKind.Sequential, Pack = 2)]
public struct TW_PCARD_HEADER
{
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
    public TW_INT8[] StructSize;             // 0-3
}

[StructLayout(LayoutKind.Sequential, Pack = 2)]
public struct TW_PROFILES
{
    public TW_UINT16 ProfilesValue;          // CAP_PROFILES TWPO_* value
    public TW_STR255 szFamily;               // Deprecated TWAIN 10.x+
    public TW_STR255 szId;                   // unique profile ID
    public TW_STR255 szEnglish;              // profile name in English
    public TW_STR255 szCurrent;              // Deprecated TWAIN 10.x+
    public TW_UINT32 Group;                    // group type (see TWPRF_GROUP_*)
    public TW_BOOL Readonly;               // cannot be modifed or deleted?
    public TW_BOOL Default;                // a default profile?
    public TW_UINT32 DriverVersion;          // Deprecated TWAIN 10.x+
    public TW_STR255 szMethod;               // Deprecated TWAIN 10.x+

    // the following are valid version 10.x+

    public TW_STR255 szName;                 // profile name in the current language.
                                             // Uses the Ansi code page. The
                                             // language is based on CAP_LANGUAGE

    public TW_STR255 szFilename;             // Full path and filename to a file	
                                             // The filename is either graphic filename
                                             // or profile filename based on the MSG
                                             // See the description above for more details

    public TW_BOOL blSharedSettings;       // Indicates whether the shared profile
                                           // settings are to be reset as well. 
    public TW_UINT16 ProfileState;           // Profile state (see TWPRF_PROFILESTATE_*)

    public unsafe fixed TW_UINT8 Reserved[508];          // Room for more stuff, always set to 0.
}

[StructLayout(LayoutKind.Sequential, Pack = 2)]
public struct TW_QUERYSUPPORT
{
    public TW_UINT32 DG;
    public TW_UINT16 DAT;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
    public TW_UINT16[] MSG;      //Return the array of supported MSG
}

[StructLayout(LayoutKind.Sequential, Pack = 2)]
public struct TW_STATUSRAW
{
    public TW_INT32 LastToolkitStatus;
    public TW_INT32 LastSenseData1;
    public TW_INT32 LastSenseData2;
    public TW_INT32 LastSenseData3;
    public TW_STR255 LastText;
    public TW_INT32 CurrentState;
    public TW_INT32 LastKDSStatus;
}

[StructLayout(LayoutKind.Sequential, Pack = 2)]
public struct TW_WINDOW
{
    public TW_UINT16 WindowCamera;              // CAP_WINDOWCAMERA value
    public unsafe fixed TW_UINT8 Reserved[1024];            // Room for more stuff
}

[StructLayout(LayoutKind.Sequential, Pack = 2)]
public struct TW_FRAMEANGLE
{
    public TW_FIX32 Left;      // same as TW_FRAME.Left
    public TW_FIX32 Top;       // same as TW_FRAME.Top
    public TW_FIX32 Right; // same as TW_FRAME.Right
    public TW_FIX32 Bottom;    // same as TW_FRAME.Bottom
    public TW_INT32 Angle; // -3600000 to +3600000
}