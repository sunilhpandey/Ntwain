using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTwain.Data.KDS;
public enum KDS_TWEI : ushort
{
    HDR_PAGESIDE = 0x8001,    // 0-front 1-rear
    HDR_DOCUMENTCOUNT = 0x8002,    // Count of pages (seeded by user)
    HDR_LENGTH = 0x8003,    // Number of bytes of image data
    HDR_LEVEL = 0x8004,    // Image Address Level
    HDR_MODE = 0x8005,    // Gemini Mode (1-18)
    HDR_LINELENGTH = 0x8006,    // Width
    HDR_PAGELENGTH = 0x8007,    // Height
    HDR_COMPRESSION = 0x8008,    // ICAP_COMPRESSION TWCP_* value
    HDR_DATE = 0x8009,    // YY/MM/DD
    HDR_TIME = 0x800A,    // HH/MM/00
    HDR_ROLL = 0x800B,    // Imagelink 990 Film Roll Number
    HDR_RESOLUTION = 0x800C,    // Dots Per Inch (DPI)
    HDR_BITORDER = 0x800D,    // Bit order in a byte
    HDR_SKEW = 0x800E,    // (obsolete)
    HDR_MOMENTARYFLAG = 0x800F,    // Gemini Momentary
    HDR_LATCHEDFLAG = 0x8010,    // Gemini Latched
    HDR_BARCODE = 0x8011,    // Gemini Barcode(s)
    HDR_DESKEW = 0x8012,    // Deskew status
    HDR_DESKEWANGLE = 0x8013,    // Deskew angle
    HDR_POLARITY = 0x8014,    // ICAP_PIXELFLAVOR TWPF_* value
    HDR_PRINTERSTRING = 0x8015,    // Viper/Prism/Wildfire printed string
    HDR_PRINTERINDEX = 0x8016,    // Kinda like the document count
    HDR_IMAGENUMBER = 0x8017,    // Count images this session
    HDR_PAGENUMBER = 0x8018,    // Count sheets of paper this session
    HDR_PAGEIMAGENUMBER = 0x8019,    // Image count on a page (1 - 4)
    HDR_BOOKNAME_A = 0x801A,    // Fixed field Gemini/Prism/Wildfire A
    HDR_BOOKNAME_B = 0x801B,    // Fixed field Prism/Wildfire B
    HDR_BOOKNAME_C = 0x801C,    // Fixed field Prism/Wildfire C
    HDR_BOOKNAME_D = 0x801D,    // Fixed field Prism/Wildfire D
    HDR_IMAGEADDRESSSTRING = 0x801E,    // Prism/Wildfire image address string
    HDR_XOFFSET = 0x801F,    // Left cropping offset
    HDR_YOFFSET = 0x8020,    // Right cropping offset
    HDR_FEATUREPATCH = 0x8021,    // Feature patch (only image with patch: i200/i600)
    HDR_IMAGEADDRESSDEFS = 0x8022,    // Image Address field definitions
    HDR_PCARD_HEADER = 0x8023,    // Personality-Card Header
    HDR_PCARD_FOOTER = 0x8024,    // Personality-Card Footer
    HDR_TOKEN_COUNT = 0x8025,    // Alien token flag
    HDR_REGENERATION = 0x8026,    // Alien retry count
    HDR_IMAGESTATUS = 0x8027,    // Alien image status
    HDR_DITHER = 0x8028,    // Bitonal dithering algorithm used
    HDR_PATCHDETECTED = 0x8029,    // Patch was found on the document
    HDR_FOLDEDCORNERPERCENTAGE = 0x802A,    // Phoenix folded corner percentage
    HDR_DESKEWCONFIDENCEFACTOR = 0x802B,    // Phoenix deskew confidence factor
    HDR_BITONALCONTRASTPERCENTAGE = 0x802C,    // Phoenix bitonal contrast percentage
    HDR_BITONALCONTRAST = 0x802D,    // Phoenix bitonal contrast
    HDR_BITONALTHRESHOLD = 0x802E,    // Phoenix bitonal threshold
    HDR_SUMHISTOGRAM = 0x802F,    // Phoenix sum historgram
    HDR_DIFFERENCEHISTOGRAM = 0x8030,    // Phoenix difference histogram
    HDR_GAMMATABLE = 0x8031,    // Phoenix gamma table
    HDR_MULTIFEED = 0x8032,    // Multifeed detected
    HDR_DESKEWANGLEACTUAL = 0x8033,    // Signed deskew angle to scanner precision
    HDR_RAWIMAGEHEADER = 0x8034,    // Raw image header from scanner
    HDR_LONGPAPERSEGMENT = 0x8035,    // Long paper segment number
    HDR_LONGPAPERLASTSEGMENT = 0x8036,    // Long pager last segment
    HDR_AUTOCOLORDETECTED = 0x8037,    // Auto color detected
    HDR_AUTOCOLORAMOUNT = 0x8038,    // Auto color amount
    HDR_AUTOCOLORTHRESHOLD = 0x8039,    // Auto color threshold
    HDR_XML = 0x803A,    // <reportimage> data in XML format (see sample at end of file)
    HDR_DROPOUTSTATUS = 0x803B,   // ECDO Algorithm Status
    HDR_PROCESSINGSTATUS = 0x803C,    // Processing Status
    HDR_BINARIZATIONQUALITY = 0x803D,    // Conveys the quality level of the binarized image
    HDR_DUALSTACKINGSTACK = 0x803E,    // Which output tray a document was dropped into (i5000 only)
                                       // Only valid if dual stacking is enabled; legal values are 1 and 2
    HDR_PAPERDESTINATION = 0x803F,    // Which output tray a document 
                                      // was dropped into (i5000 only)
    HDR_SLEEVETYPE = 0x8040,    // Type of sleeve that was detected during Sleeve Scanning
    HDR_MULTIIMAGEINDEX = 0x8041,    // Image ID for the image that was split from a document
    HDR_MULTIIMAGETOTAL = 0x8042,    // Total number of images split from a document
    HDR_ENDOFSHEET = 0x8043,    // Is this the last image on this sheet? (0-no or 1-yes)
    HDR_STAMPEDSTRING = 0x8044,    // Stamped string
    HDR_STAMPCOUNT = 0x8045,    // Digital Stamping Counter

}