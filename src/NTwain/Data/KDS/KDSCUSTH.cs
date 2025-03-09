using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace NTwain.Data.Kds;

///// <summary>
///// Contains values defined by kdscust.h (kodak).
///// </summary>
//public static class KDSCUST
//{

//    ////////////////////////////////////////////////////////////////////////////////
//    //                      CAP Section
//    ////////////////////////////////////////////////////////////////////////////////



//    // CAP_ACTIVEFEED
//    // Type:        TWTY_UINT16
//    // Container:   Enumeration
//    // Allowed:     None, Gentle, Normal
//    // Default:     None
//    // Notes:       For scanners that support "active feed". If used, this will
//    //              shuffle/straighten a stack of documents at the start of a scan.
//#define CAP_ACTIVEFEED                     = 0x8140
//#define TWAFD_NONE  =                    0
//#define TWAFD_GENTLE=               	 1
//#define TWAFD_NORMAL =                   2


//    // ICAP_AUTOCOLORIGNOREBACKGROUND
//    // Type:        TWTY_BOOL
//    // Container:   Enumeration
//    // Allowed:     TRUE, FALSE
//    // Default:     FALSE
//    // Notes:       Prevents auto color detect from including
//    //              the background in its determination whether
//    //              or not an image contains color content
//#define ICAP_AUTOCOLORIGNOREBACKGROUND    =  = 0x814A


//    // CAP_BACKGROUND
//    // Type:        TWTY_INT16
//    // Container:   Enumeration
//    // Allowed:     TWBK_BLACK, TWBK_WHITE
//    // Default:     (scanner dependent)
//    // Notes:       Reports what the scanner background was at the
//    //              time the scanner was started.  This capability
//    //              cannot detect a "hot" change.
//    //              For Blaze and Panther, it allows the user to select the color
//    //              of the imaging background. This can be set differently per side.
//#define CAP_BACKGROUND                     = 0x8089
//#define TWBK_BLACK                   =     0
//#define TWBK_WHITE                  =      1


//    // CAP_BACKGROUNDFRONT
//    // Type:        TWTY_INT16
//    // Container:   Enumeration
//    // Allowed:     TWBF_BLACK, TWBF_WHITE
//    // Default:     (scanner dependent)
//    // Notes:       Reports what the scanner front background was at the
//    //              time the scanner was started.  This capability
//    //              cannot detect a "hot" change.
//#define CAP_BACKGROUNDFRONT                = 0x808C
//#define TWBF_BLACK                        0
//#define TWBF_WHITE                        1


//    // CAP_BACKGROUNDREAR
//    // Type:        TWTY_INT16
//    // Container:   Enumeration
//    // Allowed:     TWBR_BLACK, TWBR_WHITE
//    // Default:     (scanner dependent)
//    // Notes:       Reports what the scanner rear background was at the
//    //              time the scanner was started.  This capability
//    //              cannot detect a "hot" change.
//#define CAP_BACKGROUNDREAR                 = 0x808D
//#define TWBR_BLACK                 =       0
//#define TWBR_WHITE                   =     1


//    // CAP_BACKGROUNDPLATEN
//    // Type:        TWTY_INT16
//    // Container:   Enumeration
//    // Allowed:     TWBP_BLACK, TWBP_WHITE
//    // Default:     (scanner dependent)
//    // Notes:       Reports what the scanner background was at the
//    //              time the scanner was started.  This capability
//    //              cannot detect a "hot" change.
//    //              This capability is not available at this time.
//#define CAP_BACKGROUNDPLATEN               = 0x808E
//#define TWBP_BLACK                   =     0
//#define TWBP_WHITE                   =     1


//    // CAP_BATCHCOUNT
//    // Type:        TWTY_FIX32
//    // Container:   Range
//    // Allowed:     0 - 32767
//    // Default:     0
//    // Notes:       Count of CAP_BATCHLEVEL's...
//#define CAP_BATCHCOUNT                     = 0x802B


//    // CAP_BATCHENDFUNCTION
//    // Type:        TWTY_INT16
//    // Container:   Enumeration (per camera)
//    // Allowed:     TWPL_NONE, TWPL_LEVEL1, TWPL_LEVEL2, TWPL_LEVEL3
//    // Default:     TWPL_NONE
//    // Notes:       Determines the level that batching will count
//    //              and test against the batch counting value.
//#define CAP_BATCHENDFUNCTION               = 0x804F
//#define TWBE_NONE                     =    0
//#define TWBE_STOPFEEDER               =    1
//#define TWBE_ENDOFJOB                 =    2
//#define TWBE_NEWBATCH                 =    3


//    // CAP_BATCHLEVEL
//    // Type:        TWTY_INT16
//    // Container:   Enumeration (per camera)
//    // Allowed:     TWPL_LEVEL1, TWPL_LEVEL2, TWPL_LEVEL3
//    // Default:     TWPL_LEVEL1
//    // Notes:       Determines the level that batching will count
//    //              and test against the batch counting value.
//#define CAP_BATCHLEVEL                     = 0x804E


//    // CAP_BATCHSTARTFUNCTION
//    // Type:        TWTY_INT16
//    // Container:   Enumeration (per camera)
//    // Allowed:     TWPL_NONE, TWPL_LEVEL1, TWPL_LEVEL2, TWPL_LEVEL3
//    // Default:     TWPL_NONE
//    // Notes:       Level that a batch should start in...
//#define CAP_BATCHSTARTFUNCTION             = 0x803F


//    // CAP_BINARIZATION (3590 only)
//    // Type:        TWTY_BOOL
//    // Container:   OneValue
//    // Allowed:     TRUE / FALSE
//    // Default:     FALSE
//    // Notes:       Controls the presence of binarization in the
//    //              camera control.  It also overrides the value
//    //              of the front bitonal CAP_CAMERAENABLE.
//#define CAP_BINARIZATION                   = 0x8030


//    // CAP_BLANKPAGE
//    // Type:        TW_UINT16
//    // Container:   Enumeration
//    // Allowed:     TWBP_IMAGE
//    // Default:     TWBP_IMAGE
//    // Notes:       Blank image deletion (values 0 and 2 can not used, they became obsolete)
//#define CAP_BLANKPAGE                  = 0x809A
//#define TWBP_IMAGE                 =   1


//    // CAP_BLANKPAGEMODE
//    // Type:        TW_UINT16
//    // Container:   Enumeration
//    // Allowed:     TWBM_NONE, TWBM_COMPSIZE, TWBM_CONTENT
//    // Default:     TWBM_NONE
//    // Notes:       Blank image deletion mode. Not all values are supported on all scanners.
//#define CAP_BLANKPAGEMODE              = 0x809B
//#define TWBM_COMPSIZE              =   0
//#define TWBM_NONE                  =   1
//#define TWBM_CONTENT                =  2


//    // CAP_BLANKPAGECOMPSIZEBW
//    // Type:        TW_UINT32
//    // Container:   Range
//    // Allowed:     0 to 1000KB
//    // Default:     0
//    // Notes:       Delete Bitonal image if the final size is less than specific amount.
//    //              Value needs to be in 1024 increments
//    //              The front and rear values must be the same on Mustang2 and Pony
//    //              When set to a non-zero value: CAP_BLANKPAGEMODE is automatically
//    //              set to TWBM_COMPSIZE
//    //              If set zero and CAP_BLANKPAGECOMPSIZEBW and CAP_BLANKPAGECOMPSIZEGRAY
//    //              are zero, then CAP_BLANKPAGEMODE is automatically changed to TWBM_NONE
//#define CAP_BLANKPAGECOMPSIZEBW         = 0x809C


//    // CAP_BLANKPAGECOMPSIZEGRAY
//    // Type:        TW_UINT32
//    // Container:   Range
//    // Allowed:     0 to 1000KB
//    // Default:     0
//    // Notes:       Delete Gray image if the final size is less than specific amount.
//    //              Value needs to be in 1024 increments
//    //              The front and rear values must be the same on Mustang2 and Pony
//    //              When set to a non-zero value: CAP_BLANKPAGEMODE is automatically
//    //              set to TWBM_COMPSIZE
//    //              If set zero and CAP_BLANKPAGECOMPSIZEBW and CAP_BLANKPAGECOMPSIZEGRAY
//    //              are zero, then CAP_BLANKPAGEMODE is automatically changed to TWBM_NONE
//#define CAP_BLANKPAGECOMPSIZEGRAY         = 0x809D


//    // CAP_BLANKPAGECOMPSIZERGB
//    // Type:        TW_UINT32
//    // Container:   Range
//    // Allowed:     0 to 1000KB
//    // Default:     0
//    // Notes:       Delete Color image if the final size is less than specific amount.
//    //              Value needs to be in 1024 increments
//    //              The front and rear values must be the same on Mustang2 and Pony
//    //              When set to a non-zero value: CAP_BLANKPAGEMODE is automatically
//    //              set to TWBM_COMPSIZE
//    //              If set zero and CAP_BLANKPAGECOMPSIZEBW and CAP_BLANKPAGECOMPSIZEGRAY
//    //              are zero, then CAP_BLANKPAGEMODE is automatically changed to TWBM_NONE
//#define CAP_BLANKPAGECOMPSIZERGB          = 0x809E


//    // CAP_BLANKPAGECONTENT
//    // Type:        TW_UINT32
//    // Container:   Range
//    // Allowed:     0 to 100
//    // Default:     0
//    // Notes:       If the percent of content on the image is less than or equal to
//    //              this amount, the image will be deleted. This is only valid when
//    //              CAP_BLANKPAGEMODE is set to TWBM_CONTENT
//#define CAP_BLANKPAGECONTENT		    = 0x80C4


//    // CAP_CAMERAENABLE
//    // Type:        TWTY_BOOL
//    // Container:   OneValue (per camera)
//    // Allowed:     TRUE / FALSE
//    // Default:     TRUE (except for the 3590 front bitonal)
//    // Notes:       Controls the delivery of images.  If this capability
//    //              is set to TRUE then the Source will deliver an image
//    //              for this camera during scanning.  You need to use
//    //              DAT_FILESYSTEM to address each of the cameras.
//#define CAP_CAMERAENABLE                   = 0x801D


//    // CAP_CAMERAORDER
//    // Type:        TWTY_UINT16
//    // Container:   Array
//    // Allowed:     TWCM_BW_BOTH, TWCM_CL_BOTH
//    // Default:     TWCM_CL_BOTH, TWCM_BW_BOTH
//    // Notes:       Selects the ordering of the cameras according to the
//    //              order that they appear in the list.  So the default
//    //              indicates that a color front or rear will precede a
//    //              bitonal front or rear.
//    //
//    // There is a conflict between the standard TWAIN CAP_CAMERAORDER and
//    // the Kodak Alrais Inc. custom CAP_CAMERAORDER.  The standard version
//    // has a value of= 0x1037 and uses the TWPT_* values.
//    // The Kodak Alaris Inc. version can be seen below.  This driver does
//    // not support the TWAIN 2.0 version of this capability.  An
//    // application must use the Kodak Alaris Inc. version to talk to a
//    // Kodak Alaris Inc. driver.
//# ifdef CAP_CAMERAORDER
//#undef CAP_CAMERAORDER
//#endif
//#define CAP_CAMERAORDERSTANDARD			=	0x1037
//#define CAP_CAMERAORDER					=	0x801E
//#define TWCM_BW_BOTH                   =  0
//#define TWCM_BW_TOP                     = 1
//#define TWCM_BW_BOTTOM                  = 2
//#define TWCM_CLBW_BOTH                  = 3
//#define TWCM_CL_TOP                     = 4
//#define TWCM_CL_BOTTOM                  = 5
//#define TWCM_CL_BOTH                    = 6
//#define TWCM_GR_TOP                     = 7
//#define TWCM_GR_BOTTOM                  = 8
//#define TWCM_GR_BOTH                    = 9


//    // CAP_CARTRIDGEDETECTED
//    // Type:        TWTY_UINT16
//    // Container:   Array
//    // Allowed:     Scanner Model Specific
//    // Default:     none
//    // Notes:       For scanners which support front and rear printers, indicates
//    //              which ink cartridges are installed.
//#define CAP_CARTRIDGEDETECTED              = 0x811D
//#define TWPRCART_POSTIMAGEFRONT       =   0
//#define TWPRCART_POSTIMAGEREAR        =   1
//#define TWPRCART_PREIMAGEFRONT        =   2
//#define TWPRCART_PREIMAGEREAR         =   3


//    // CAP_CHECKDIGIT
//    // Type:        TWTY_BOOL
//    // Container:   OneValue
//    // Allowed:     TRUE / FALSE
//    // Default:     TRUE
//    // Notes:       To set the check image address digit ON/OFF.
//#define CAP_CHECKDIGIT                     = 0x808B


//    // CAP_DOCUMENTCOUNT
//    // Type:        TWTY_STR32
//    // Container:   OneValue
//    // Allowed:     0 - 999,999,999
//    // Default:     0
//    // Notes:       5000/7000/9000 only.  Sets the document count, but
//    //              only if CAP_PRINTERENABLED is either undefined or
//    //              set to FALSE.
//#define CAP_DOCUMENTCOUNT                  = 0x8017


//    // CAP_DOCUMENTCOUNTENABLED
//    // Type:        TWTY_BOOL
//    // Container:   OneValue
//    // Allowed:     TRUE / FALSE
//    // Default:     FALSE
//    // Notes:       5000/7000/9000 only.  Determines whether or not
//    //              the CAP_DOCUMENTCOUNT is to be downloaded.
//#define CAP_DOCUMENTCOUNTENABLED           = 0x8018


//    // CAP_DOUBLEFEEDENDJOB
//    // Type:        TWTY_BOOL
//    // Container:   OneValue
//    // Allowed:     TRUE / FALSE
//    // Default:     TRUE
//    // Notes:       Controls the action the scanner takes when a double
//    //              feed is detected.  A value of TRUE will cause the
//    //              session to be terminated.  A value of FALSE will
//    //              cause the multifeed to be ignored (though an audible
//    //              alarm will still be sounded, if it is turned on).
//#define CAP_DOUBLEFEEDENDJOB               = 0x806E


//    // CAP_DOUBLEFEEDSTOP
//    // Type:        TWTY_BOOL
//    // Container:   OneValue
//    // Allowed:     TRUE / FALSE
//    // Default:     TRUE
//    // Notes:       Controls the action the scanner takes when a double
//    //              feed is detected.  A value of TRUE will cause the
//    //              session to be terminated.  A value of FALSE will
//    //              cause the multifeed to be ignored (though an audible
//    //              alarm will still be sounded, if it is turned on).
//#define CAP_DOUBLEFEEDSTOP                 = 0x8056


//    // CAP_DUALSTACKINGENABLED
//    // Type:        TWTY_BOOL
//    // Container:   OneValue
//    // Allowed:     TRUE / FALSE
//    // Default:     FALSE
//    // Notes:       Indicates if the Controlled Dual Stacking Accessory is
//    //              enabled. It can only be enabled if the accessory is
//    //              installed.
//#define CAP_DUALSTACKINGENABLED            = 0x8110


//    // CAP_DUALSTACKINGLENGTHMODE
//    // Type:        TWTY_UINT16
//    // Container:   Enumeration
//    // Allowed:     Scanner specific
//    // Default:     TWDSLM_NONE
//    // Notes:       Indicates the length method being used to make document sorting decisions
//    //              for the Controlled Dual Stacking Accessory. The stacking length mode
//    //              only has meaning if CAP_DUALSTACKINGENABLED is TRUE.
//#define CAP_DUALSTACKINGLENGTHMODE        = 0x8111
//#define TWDSLM_NONE             =       0
//#define TWDSLM_LESSTHAN          =      1
//#define TWDSLM_GREATERTHAN        =     2
//#define TWDSLM_BETWEEN             =    3


//    // CAP_DUALSTACKINGLENGTH1
//    // Type:        TWTY_FIX32
//    // Container:   Range
//    // Allowed:     Scanner-specific
//    // Default:     Scanner-specific (min range value)
//    // Notes:       Dual stacking length1 (in ICAP_UNITS).
//    //              If CAP_DUALSTACKINGLENGTHMODE is "less than", then any documents shorter
//    //              than this value will be placed in the selected  CAP_DUALSTACKINGSTACK.
//    //              If CAP_DUALSTACKINGLENGTHMODE is "greater than", then any documents longer
//    //              than this value will be placed in the selected CAP_DUALSTACKINGSTACK.
//    //              If CAP_DUALSTACKINGLENGTHMODE is "between", then any documents longer than
//    //              this value and shorter than CAP_DUALSTACKINGLENGTH2 will be placed in the
//    //              selected CAP_DUALSTACKINGSTACK.
//    //              Only valid if CAP_DUALSTACKINGENABLED is TRUE and CAP_DUALSTACKINGLENGTHMODE
//    //              is set to any value other than TWDSLM_NONE.
//    //              The range is determined by the scanner, so an application
//    //              might want to ask what the range is.
//#define CAP_DUALSTACKINGLENGTH1            = 0x8112


//    // CAP_DUALSTACKINGLENGTH2
//    // Type:        TWTY_FIX32
//    // Container:   Range
//    // Allowed:     Scanner-specific
//    // Default:     Scanner-specific (min range value)
//    // Notes:       Dual stacking length2 (in ICAP_UNITS).
//    //              If CAP_DUALSTACKINGLENGTHMODE is "between", then any documents longer than
//    //              CAP_DUALSTACKINGLENGTH1 and shorter than CAP_DUALSTACKINGLENGTH2 will be
//    //              placed in the selected CAP_DUALSTACKINGSTACK.
//    //              Only valid if CAP_DUALSTACKINGENABLED is TRUE and CAP_DUALSTACKINGLENGTHMODE
//    //              is set to TWDSLM_BETWEEN.
//    //              The range is determined by the scanner, so an application
//    //              might want to ask what the range is.
//#define CAP_DUALSTACKINGLENGTH2            = 0x8113


//    // CAP_DUALSTACKINGMULTIFEED
//    // Type:        TWTY_BOOL
//    // Container:   OneValue
//    // Allowed:     TRUE / FALSE
//    // Default:     FALSE
//    // Notes:       Indicates if Multifeed documents should be placed in
//    //              the selected  CAP_DUALSTACKINGSTACK.
//    //              Only valid if CAP_DUALSTACKINGENABLED is TRUE.
//#define CAP_DUALSTACKINGMULTIFEED          = 0x8114


//    // CAP_DUALSTACKINGPATCHTRANSFER
//    // Type:        TWTY_BOOL
//    // Container:   OneValue
//    // Allowed:     TRUE / FALSE
//    // Default:     FALSE
//    // Notes:       Indicates if Patch Type Transfer documents should be placed in
//    //              the selected  CAP_DUALSTACKINGSTACK.
//    //              Only valid if CAP_DUALSTACKINGENABLED is TRUE.
//#define CAP_DUALSTACKINGPATCHTRANSFER      = 0x8115


//    // CAP_DUALSTACKINGPATCHTYPE1
//    // Type:        TWTY_BOOL
//    // Container:   OneValue
//    // Allowed:     TRUE / FALSE
//    // Default:     FALSE
//    // Notes:       Indicates if Patch Type 1 documents should be placed in
//    //              the selected  CAP_DUALSTACKINGSTACK.
//    //              Only valid if CAP_DUALSTACKINGENABLED is TRUE.
//#define CAP_DUALSTACKINGPATCHTYPE1         = 0x8116


//    // CAP_DUALSTACKINGPATCHTYPE2
//    // Type:        TWTY_BOOL
//    // Container:   OneValue
//    // Allowed:     TRUE / FALSE
//    // Default:     FALSE
//    // Notes:       Indicates if Patch Type 2 documents should be placed in
//    //              the selected  CAP_DUALSTACKINGSTACK.
//    //              Only valid if CAP_DUALSTACKINGENABLED is TRUE.
//#define CAP_DUALSTACKINGPATCHTYPE2         = 0x8117


//    // CAP_DUALSTACKINGPATCHTYPE3
//    // Type:        TWTY_BOOL
//    // Container:   OneValue
//    // Allowed:     TRUE / FALSE
//    // Default:     FALSE
//    // Notes:       Indicates if Patch Type 3 documents should be placed in
//    //              the selected  CAP_DUALSTACKINGSTACK.
//    //              Only valid if CAP_DUALSTACKINGENABLED is TRUE.
//#define CAP_DUALSTACKINGPATCHTYPE3         = 0x8118


//    // CAP_DUALSTACKINGPATCHTYPE4
//    // Type:        TWTY_BOOL
//    // Container:   OneValue
//    // Allowed:     TRUE / FALSE
//    // Default:     FALSE
//    // Notes:       Indicates if Patch Type 4 documents should be placed in
//    //              the selected  CAP_DUALSTACKINGSTACK.
//    //              Only valid if CAP_DUALSTACKINGENABLED is TRUE.
//#define CAP_DUALSTACKINGPATCHTYPE4         = 0x8119


//    // CAP_DUALSTACKINGPATCHTYPE6
//    // Type:        TWTY_BOOL
//    // Container:   OneValue
//    // Allowed:     TRUE / FALSE
//    // Default:     FALSE
//    // Notes:       Indicates if Patch Type 6 documents should be placed in
//    //              the selected  CAP_DUALSTACKINGSTACK.
//    //              Only valid if CAP_DUALSTACKINGENABLED is TRUE.
//#define CAP_DUALSTACKINGPATCHTYPE6         = 0x811A


//    // CAP_DUALSTACKINGPATCHTYPE10
//    // Type:        TWTY_BOOL
//    // Container:   OneValue
//    // Allowed:     TRUE / FALSE
//    // Default:     FALSE
//    // Notes:       Indicates if Patch Type 10 documents should be placed in
//    //              the selected CAP_DUALSTACKINGSTACK.
//    //              Only valid if CAP_DUALSTACKINGENABLED is TRUE.
//    //              This feature is not available for all models.
//#define CAP_DUALSTACKINGPATCHTYPE10        = 0x8139


//    // CAP_DUALSTACKINGPATCHTYPE11
//    // Type:        TWTY_BOOL
//    // Container:   OneValue
//    // Allowed:     TRUE / FALSE
//    // Default:     FALSE
//    // Notes:       Indicates if Patch Type 11 documents should be placed in
//    //              the selected CAP_DUALSTACKINGSTACK.
//    //              Only valid if CAP_DUALSTACKINGENABLED is TRUE.
//    //              This feature is not available for all models.
//#define CAP_DUALSTACKINGPATCHTYPE11        = 0x813A


//    // CAP_DUALSTACKINGPATCHTYPE12
//    // Type:        TWTY_BOOL
//    // Container:   OneValue
//    // Allowed:     TRUE / FALSE
//    // Default:     FALSE
//    // Notes:       Indicates if Patch Type 12 documents should be placed in
//    //              the selected CAP_DUALSTACKINGSTACK.
//    //              Only valid if CAP_DUALSTACKINGENABLED is TRUE.
//    //              This feature is not available for all models.
//#define CAP_DUALSTACKINGPATCHTYPE12        = 0x813B


//    // CAP_DUALSTACKINGPATCHTYPE13
//    // Type:        TWTY_BOOL
//    // Container:   OneValue
//    // Allowed:     TRUE / FALSE
//    // Default:     FALSE
//    // Notes:       Indicates if Patch Type 13 documents should be placed in
//    //              the selected CAP_DUALSTACKINGSTACK.
//    //              Only valid if CAP_DUALSTACKINGENABLED is TRUE.
//    //              This feature is not available for all models.
//#define CAP_DUALSTACKINGPATCHTYPE13        = 0x813C


//    // CAP_DUALSTACKINGPATCHTYPE14
//    // Type:        TWTY_BOOL
//    // Container:   OneValue
//    // Allowed:     TRUE / FALSE
//    // Default:     FALSE
//    // Notes:       Indicates if Patch Type 14 documents should be placed in
//    //              the selected CAP_DUALSTACKINGSTACK.
//    //              Only valid if CAP_DUALSTACKINGENABLED is TRUE.
//    //              This feature is not available for all models.
//#define CAP_DUALSTACKINGPATCHTYPE14        = 0x813D


//    // CAP_DUALSTACKINGPATCHTYPE15
//    // Type:        TWTY_BOOL
//    // Container:   OneValue
//    // Allowed:     TRUE / FALSE
//    // Default:     FALSE
//    // Notes:       Indicates if Patch Type 15 documents should be placed in
//    //              the selected CAP_DUALSTACKINGSTACK.
//    //              Only valid if CAP_DUALSTACKINGENABLED is TRUE.
//    //              This feature is not available for all models.
//#define CAP_DUALSTACKINGPATCHTYPE15        = 0x813E


//    // CAP_DUALSTACKINGSTACK
//    // Type:        TWTY_UINT16
//    // Container:   Enumeration
//    // Allowed:     Scanner specific
//    // Default:     TWDSS_STACK1
//    // Notes:       Which stack a document should drop into
//    //              based on stacking criteria. Only valid if 
//    //              CAP_DUALSTACKINGENABLED is TRUE.
//#define CAP_DUALSTACKINGSTACK              = 0x811B
//#define TWDSS_STACK1                =    1
//#define TWDSS_STACK2                =    2


//    // CAP_EASYSTACKING
//    // Type:        TWTY_BOOL
//    // Container:   OneValue
//    // Allowed:     TRUE / FALSE
//    // Default:     FALSE
//    // Notes:       If set to TRUE then the scanner makes adjustments
//    //              to improve the arrangement of the output stack as
//    //              the paper exits the transport.
//#define CAP_EASYSTACKING                   = 0x8075


//    // CAP_ENABLECOLORPATCHCODE (3590 only)
//    // Type:        TWTY_BOOL
//    // Container:   OneValue
//    // Allowed:     TRUE / FALSE
//    // Default:     FALSE
//    // Notes:       Controls recognition of the 3590 patch page.
//#define CAP_ENABLECOLORPATCHCODE           = 0x8054


//    // CAP_ENERGYSTAR
//    // Type:        TWTY_INT32
//    // Container:   Range
//    // Allowed:     typically 1 (or 5) - 240 (minutes)
//    // Default:     15
//    // Notes:       Minutes of idle time before Energy Star kicks in...
//#define CAP_ENERGYSTAR                     = 0x802F


//    // CAP_FEEDERKEEPALIVE (3000, 4000 only)
//    // Type:        TWTY_BOOL
//    // Container:   OneValue
//    // Allowed:     TRUE / FALSE
//    // Default:     FALSE
//    // Notes:       Controls the behavior of the feeder in the following way:
//    // 
//    // State       ICAP_XFERCOUNT       First Page       All Other Pages
//    // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//    // FALSE             -1             Timeout          Timeout
//    // FALSE             >0             Timeout          Timeout
//    // TRUE              -1             Keep Alive       Timeout
//    // TRUE              >0             Keep Alive       Timeout
//    //
//    // The effect when TRUE from the user's perspective is that if the
//    // transport times out while waiting for the first sheet of paper,
//    // the Source will reenable the scanner, and start the transport
//    // back up again.  It will continue to do this until it gets the
//    // first sheet of paper, or until the user stops the scanner from
//    // the application.
//#define CAP_FEEDERKEEPALIVE                = 0x8001


//    // CAP_FEEDERMODE
//    // Type:        TWTY_UINT16
//    // Container:   Enumeration
//    // Allowed:     Scanner specific
//    // Default:     Scanner specific
//    // Notes:       Selects TWFM_NONE will show Off on the UI
//    //              and TWFM_SPECIAL is On on the UI
//    //              CAP_FEEDERMODE is for Special Document
//#define CAP_FEEDERMODE                     = 0x806F
//#define TWFM_NONE                  =    0
//#define TWFM_SPECIAL                =   1
//#define TWFM_STACKINGIMPROVED        =  2
//#define TWFM_STACKINGBEST             = 3
//#define TWFM_FRAGILE                   =4
//#define TWFM_LIGHTWEIGHT               =5
//#define TWFM_THICK                     =6
//#define TWFM_THIN                      =7


//    // CAP_FIXEDDOCUMENTSIZE (3000, 4000, but no 3500)
//    // Type:        TWTY_BOOL
//    // Container:   OneValue
//    // Allowed:     TRUE / FALSE
//    // Default:     FALSE
//    // Notes:       Controls the scanner speed-up feature.  Note that this
//    //              feature cannot be used with overscan.  And it does
//    //              require that all the documents in the batch be of the
//    //              same size.
//#define CAP_FIXEDDOCUMENTSIZE              = 0x8055


//    // CAP_FOLDEDCORNER
//    // Type:        TWTY_UINT16
//    // Container:   Enumeration
//    // Allowed:     TWFC_DISABLED, TWFC_STOP, TWFC_ENDOFJOB
//    // Default:     TWFC_DISABLED
//    // Notes:       Controls Folded Corner detection and the action taken
//    //              if one is discovered during scanning...
//#define CAP_FOLDEDCORNER                   = 0x8070
//#define TWFC_DISABLED                  =     0
//#define TWFC_STOPFEEDER                 =    1
//#define TWFC_ENDOFJOB                 =      2
//#define TWCC_FOLDEDCORNER                  = 0x8001
//#define TWDE_FOLDEDCORNER                  = 0x8001


//    // CAP_FOLDEDCORNERSENSITIVITY
//    // Type:        TWTY_UINT16
//    // Container:   Range
//    // Allowed:     1 - 100
//    // Default:     2
//    // Notes:       Controls the folded corner sensitivity, if folder
//    //              corner detection is turned on...
//#define CAP_FOLDEDCORNERSENSITIVITY        = 0x8071


//    // CAP_FUNCTIONKEY*
//    // Type:        TWTY_UINT16
//    // Container:   Enumeration
//    // Allowed:     (see list below)
//    // Default:     TWFK_NONE
//    // Notes:       i800 series only.  Controls the action taken by the
//    //              function keys during a scanning session...
//#define CAP_FUNCTIONKEY1                   = 0x8037
//#define CAP_FUNCTIONKEY2                   = 0x8038
//#define CAP_FUNCTIONKEY3                   = 0x8039
//#define CAP_FUNCTIONKEY4                   = 0x803A // not used
//#define TWFK_NONE               =          0
//#define TWFK_ENDOFJOB            =         1
//#define TWFK_TERMINATEBATCH       =        2
//#define TWFK_SKIPMULTIFEED         =       3
//#define TWFK_SKIPPRINTING           =      4
//#define TWFK_SKIPPATCH               =     5
//#define TWFK_LOWERELEVATOR            =    6


//    // CAP_IMAGEADDRESS
//    // Type:        TWTY_STR255
//    // Container:   OneValue
//    // Allowed:     The image address string...
//    // Default:     Scanner Next Image Address (read from device)
//    // Notes:       800/5000/7000/9000 only.  Sets the image address.
//#define CAP_IMAGEADDRESS                   = 0x8015


//    // CAP_IMAGEADDRESSENABLED
//    // Type:        TWTY_BOOL
//    // Container:   OneValue
//    // Allowed:     TRUE / FALSE
//    // Default:     FALSE
//    // Notes:       5000/7000/9000 only.  Determines whether or not
//    //              the CAP_IMAGEADDRESS is to be downloaded.
//#define CAP_IMAGEADDRESSENABLED            = 0x8016


//    // CAP_IMAGEADDRESSTEMPLATES
//    // Type:        TWTY_UINT16
//    // Container:   Enumeration
//    // Allowed:     (see below)
//    // Default:     TWIA_1
//    // Notes:       Determines what kind of image address
//    //              format is allowed.  See CONST.INI for the user
//    //              selectable list of formats, and the language files
//    //              L_XX_XXX.INI for the associated text in the image
//    //              address presets dropdown list.  Note that, like
//    //              with ICAP_HALFTONES and ICAP_SUPPORTEDSIZES, it is
//    //              not really possible for an application to know
//    //              what the user is selecting, it just has to be
//    //              accepted blindly.
//    //		Some scanners limit what is allowed.
//#define CAP_IMAGEADDRESSTEMPLATES          = 0x803E
//#define TWIA_CUSTOM       =                -1
//#define TWIA_NONE          =               0
//#define TWIA_1              =              1
//#define TWIA_2               =             2
//#define TWIA_3                =            3
//#define TWIA_4                 =           4
//#define TWIA_5                   =         5
//#define TWIA_6                    =        6
//#define TWIA_7                  =          7
//#define TWIA_8                   =         8
//#define TWIA_9                    =        9
//#define TWIA_10                    =       10
//#define TWIA_11                     =      11
//#define TWIA_12                      =     12
//#define TWIA_13                       =    13
//#define TWIA_14                        =   14
//#define TWIA_15                         =  15
//#define TWIA_16                          = 16


//    // CAP_IMAGEADDRESS_A
//    // CAP_IMAGEADDRESS_B
//    // CAP_IMAGEADDRESS_C
//    // CAP_IMAGEADDRESS_D
//    // Type:        TWTY_STR255
//    // Container:   OneValue
//    // Allowed:     The image address template fields...
//    // Default:     (see CAP_IMAGEADDRESSTEMPLATES)
//    // Notes:       Specifies the meaning and the maximum sizes
//    //              of the fields in the image address.  A value of 'f'
//    //              indicates a fixed field.  Values of 1, 2, 3 indicate
//    //              level fields.  The number of characters determines the
//    //              maximum allowed in that field.
//    //		Some scanners limit what is allowed.
//#define CAP_IMAGEADDRESS_A                 = 0x804A
//#define CAP_IMAGEADDRESS_B                 = 0x804B
//#define CAP_IMAGEADDRESS_C                 = 0x804C
//#define CAP_IMAGEADDRESS_D                 = 0x804D


//    // CAP_IMAGEMERGE
//    // Type:        TW_UINT16
//    // Container:   Enumeration
//    // Allowed:     TWIM_NONE, TWIM_FRONTONTOP, TWIM_FRONTONBOTTOM,
//    //              TWIM_FRONTONLEFT, TWIM_FRONTONRIGHT
//    // Default:     TWIM_NONE
//    // Notes:       Merges the front and back images into a single image that is 
//    //              returned to the application.
//#define CAP_IMAGEMERGE                     = 0x80C5
//#define TWIM_NONE              =          0
//#define TWIM_FRONTONTOP	        =        1	// front is on top of the back
//#define TWIM_FRONTONBOTTOM       =        2	// back is on top of front
//#define TWIM_FRONTONLEFT	      =          3	// front is to the left of the back
//#define TWIM_FRONTONRIGHT          =      4	// back is to the left of the front


//    // CAP_IMAGESDIFFERENT
//    // Type:        TWTY_BOOL
//    // Container:   OneValue (per camera)
//    // Allowed:     TRUE / FALSE
//    // Default:     FALSE
//    // Notes:       When this is TRUE the user can set different values for the
//    //              color and bitonal cameras.  When set to FALSE a value set
//    //				on a color camera will be matched (if possible) by the bitonal
//    //				camera, and vice versa.
//#define CAP_IMAGESDIFFERENT                 = 0x8100


//    // CAP_INDICATORSWARMUP
//    // Type:        TWTY_BOOL
//    // Container:   OneValue
//    // Allowed:     TRUE / FALSE
//    // Default:     TRUE
//    // Notes:       Controls the appearance of the LampSaver and Warmup
//    //              dialogs.  Only turn this off if these dialogs are
//    //              interfering with the operation of your application.
//    //              For version 9.3 drivers and up, if lamps are not
//    //              warmed-up at scan time, your application can be told
//    //              the number of seconds remaining before scanning will
//    //              begin; refer to TWDE_LAMPWARMUP in CAP_DEVICEEVENT
//    //              for more information.
//#define CAP_INDICATORSWARMUP               = 0x806C


//    // CAP_INTELLIGENTDOCUMENTPROTECTION
//    // Type:        TWTY_UINT16
//    // Container:   Enumeration
//    // Allowed:     See below...
//    // Default:     TWIDP_NORMAL
//    // Notes:       ADF only. Controls the level of document protection.
//#define CAP_INTELLIGENTDOCUMENTPROTECTION	0x810D
//#define TWIDP_NONE             =           0
//#define TWIDP_MINIMUM           =          1
//#define TWIDP_NORMAL             =         2
//#define TWIDP_MAXIMUM             =        3


//    // CAP_KADIGITALSTAMPCOUNT
//    // Type:        TWTY_UINT32
//    // Container:   OneValue
//    // Allowed:     0 - 999999999
//    // Default:     1
//    // Notes:       Stamp-specific counter, which is independent of the sheet counter
//    //              (CAP_PRINTERINDEX). This value allows the user to set the starting
//    //              digital stamping counter.
//#define CAP_KADIGITALSTAMPCOUNT            = 0x814E


//    // CAP_KADIGITALSTAMPINGSUPPORTED
//    // Type:        TWTY_BOOL
//    // Container:   OneValue
//    // Allowed:     TRUE / FALSE
//    // Default:     FALSE
//    // Notes:       A value of TRUE indicates that the Digital Stamping
//    //              feature is supported.
//#define CAP_KADIGITALSTAMPINGSUPPORTED     = 0x8149


//    // CAP_KADIGITALSTAMPCOUNT
//    // Type:        TWTY_BOOL
//    // Container:   OneValue
//    // Allowed:     TRUE
//    // Default:     TRUE
//    // Notes:       Present if .eklog.zip files are supported by DAT_LOG.
//    //              See TW_LOG for more info.
//#define CAP_KAEKLOGUSESZIP                 = 0x814F


//    // CAP_LEVELTOFOLLOW1
//    // CAP_LEVELTOFOLLOW2
//    // CAP_LEVELTOFOLLOW3
//    // Type:        TWTY_UINT16
//    // Container:   Enumeration
//    // Allowed:     TWPL_LEVEL1, TWPL_LEVEL2, TWPL_LEVEL3
//    // Default:     TWPL_LEVEL1
//    // Notes:       For Image Addressing, determines dependencies among the
//    //              level counters.
//#define CAP_LEVELTOFOLLOW1                 = 0x803B
//#define CAP_LEVELTOFOLLOW2                 = 0x803C
//#define CAP_LEVELTOFOLLOW3                 = 0x803D


//    // CAP_MODE
//    // Type:        TWTY_UINT16
//    // Container:   Enumeration
//    // Allowed:     (see list below)
//    // Default:     TWMO_MODE1
//    // Notes:       Selects the current mode.
//#define CAP_MODE                           = 0x8019
//#define TWMO_MODE1    =                    1
//#define TWMO_MODE2     =                   2
//#define TWMO_MODE3      =                  3
//#define TWMO_MODE4       =                 4
//#define TWMO_MODE5        =                5
//#define TWMO_MODE6         =               6
//#define TWMO_MODE7          =              7
//#define TWMO_MODE8           =             8
//#define TWMO_MODE9            =            9
//#define TWMO_MODE10            =           10
//#define TWMO_MODE11             =          11
//#define TWMO_MODE12              =         12
//#define TWMO_MODE13               =        13
//#define TWMO_MODE14                =       14
//#define TWMO_MODE15                 =      15
//#define TWMO_MODE16                  =     16
//#define TWMO_MODE17                   =    17
//#define TWMO_MODE18                    =   18


//    // CAP_FLATBEDMULTIDOCLOCATE
//    // Type:        TWTY_BOOL
//    // Container:   OneValue
//    // Allowed:     TRUE / FALSE
//    // Default:     FALSE
//    // Notes:       For scanners that support "multi doc locate". If this feature is true/on, multiple
//    //				documents will be separated into different images if placed on a flatbed
//#define CAP_FLATBEDMULTIDOCLOCATE          = 0x8142


//    // CAP_SLEEVEMULTIDOCLOCATE
//    // Type:        TWTY_BOOL
//    // Container:   OneValue
//    // Allowed:     TRUE / FALSE
//    // Default:     FALSE
//    // Notes:       For scanners that support "multi doc locate". If this feature is true/on, multiple
//    //				documents will be separated into different images if fed in a single carrier sheet
//    //				(sleeve)
//#define CAP_SLEEVEMULTIDOCLOCATE           = 0x8143


//    // CAP_MULTIFEEDCOUNT
//    // Type:        TWTY_INT32
//    // Container:   OneValue
//    // Allowed:     0 - 32767
//    // Default:     0
//    // Notes:       Count of multifeeds per scan session
//#define CAP_MULTIFEEDCOUNT                 = 0x8086


//    // CAP_MULTIFEEDRESPONSE
//    // Type:        TWTY_UINT16
//    // Container:   Enumeration
//    // Allowed:     Scanner specific
//    // Default:     TWMR_ENDOFJOB
//    // Notes:       Selects action taken when the multifeed detected.
//#define CAP_MULTIFEEDRESPONSE               = 0x80BA
//#define TWMR_CONTINUE            =         0
//#define TWMR_ENDOFJOB             =        1
//#define TWMR_ENDOFJOBLEAVEPAPER    =       2
//#define TWMR_STOPFEEDER             =      3
//#define TWMR_STOPFEEDERLEAVEPAPER    =     4
//#define TWMR_ENDOFJOBGENERATEIMAGE    =    5
//#define TWMR_ENDOFJOBHOLDPAPERATEXIT   =   6
//#define TWMR_STOPFEEDERHOLDPAPERATEXIT  =  7
//#define TWMR_INTERACTIVEHOLDPAPERATEXIT  = 8



//    // CAP_MULTIFEEDSOUND
//    // Type:        TWTY_STR255
//    // Container:   OneValue
//    // Allowed:     Text
//    // Default:     "ding.wav"
//    // Notes:       Sound when detect document multifeeds.
//#define CAP_MULTIFEEDSOUND                 = 0x802D


//    // CAP_MULTIFEEDTHICKNESSDETECTION
//    // Type:        TWTY_BOOL
//    // Container:   OneValue
//    // Allowed:     TRUE / FALSE
//    // Default:     FALSE
//    // Notes:       Controls the whether thickness is used to detect
//    //              document multifeeds.
//#define CAP_MULTIFEEDTHICKNESSDETECTION    = 0x8057


//    // CAP_NOWAIT
//    // Type:        TWTY_BOOL
//    // Container:   OneValue
//    // Allowed:     TRUE / FALSE
//    // Default:     FALSE
//    // Notes:       Legacy behavior for this Source is to wait inside
//    //              of the MSG_ENDXFER command until the next image
//    //              is scanned or until the session is terminated, so
//    //              that it can properly set the value of the
//    //              TW_PENDINGXFERS.Count field.  This has the unhappy
//    //              side-effect of hanging the application.
//    //
//    //              This capability allows the application to issue a
//    //              non-blocking call to MSG_ENDXFER.  The application
//    //              must NOT move on to the next image until it receives
//    //              a TWRC_SUCCESS from the command.  A custom return
//    //              code of TWRC_BUSY will indicate that the Source
//    //              is still waiting on the device.  The application can
//    //              end the session by issuing a MSG_STOPFEEDER command.
//    //
//    //              Note that if CAP_AUTOSCAN is off then this situation
//    //              can happen for any image related command that is
//    //              issued:  DAT_IMAGEINFO, DAT_IMAGELAYOUT,
//    //              DAT_IMAGEFILEXFER, DAT_IMAGEMEMXFER, DAT_IMAGEFILEXFER.
//    //
//    //              TWAIN 2.2 defines TWRC_BUSY.  The driver assumes that
//    //              the application's TWAIN protocol corresponds to the
//    //              twain.h file that it was built with.  Therefore, for
//    //              applications that report a protocol of 2.1 or less
//    //              the value of TWRC_BUSY will be= 0x8001.  For apps that
//    //              report a value of 2.2 or higher the value returned
//    //              will match whatever TWRC_BUSY is set to in the twain.h
//    //              file.  OBS_TWRC_BUSY is provided for situations where
//    //              an app reports a value of 2.1 or less when it is using
//    //              a 2.2 or greater twain.h.  In this case the application
//    //              must make a code change to use OBS_TWRC_BUSY.
//    //
//    //              Applications must also allow for the protocol reported
//    //              by the TWAIN driver.  Drivers reporting 2.1 or less
//    //              will only report a value of= 0x8001 for TWRC_BUSY,
//    //              regardless of the protocol reported by the application.
//#define CAP_NOWAIT                         = 0x8032
//#define OBS_TWRC_BUSY                  = 0x8001
//# ifndef TWRC_BUSY
//#define TWRC_BUSY						0x8001
//#endif


//    // CAP_PAGECOUNT
//    // Type:        TWTY_FIX32
//    // Container:   Range
//    // Allowed:     0 - 32767
//    // Default:     0
//    // Notes:       Count of pages to transfer.  This capability only
//    //              takes effect if CAP_XFERCOUNT is -1.  A value of 0
//    //              disables this capability.
//#define CAP_PAGECOUNT                      = 0x8031


//    // CAP_PAGESIZELIMIT
//    // Type:        TWTY_FIX32
//    // Container:   Range
//    // Allowed:     0 - ICAP_PHYSICALHEIGHT
//    // Default:     0
//    // Notes:       Maximum allowed physical page height (in ICAP_UNITS).
//    //              This is a double document detection feature.
//#define CAP_PAGESIZELIMIT                  = 0x8002

//    // CAP_PAPERDESTINATION
//    // Type:         TWTY_UINT16
//    // Container:    Enumeration
//    // Allowed:      Scanner specific
//    // Default:      Scanner specific
//    // Notes:        Allows the user to select the default paper
//    //	               output destination tray. This feature is not
//    //                     available for all models. Not all values are
//    //                     supported on all scanners.
//#define CAP_PAPERDESTINATION                 = 0x813F
//#define TWTRAY_LOWERTRAY=			0
//#define TWTRAY_REAREXIT	=		1
//#define TWTRAY_UPPERTRAY=			2


//    // CAP_PAPERJAMRESPONSE
//    // Type:        TWTY_UINT16
//    // Container:   Enumeration
//    // Allowed:     TWPJR_STOPFEEDER, TWPJR_ENDOFJOB
//    // Default:     TWPJR_ENDOFJOB
//    // Notes:       Selects action taken when a Paper Jam occurs.
//#define CAP_PAPERJAMRESPONSE               = 0x8125
//#define TWPJR_STOPFEEDER     =            0
//#define TWPJR_ENDOFJOB        =           1


//    // CAP_PAPERSOURCE
//    // Type:        TWTY_UINT16
//    // Container:   Enumeration
//    // Allowed:     Scanner specific
//    // Default:     Scanner specific; can change when a Flatbed accessory
//    //              is attached
//    // Notes:       Selects source of paper (ADF or Platen).  TWPU_AUTO
//    //              selects ADF but changes to Platen if the ADF has no
//    //              paper in it at the start of the scanning session.
//#define CAP_PAPERSOURCE                    = 0x802C
//#define TWPU_AUTO              =          0
//#define TWPU_ADF                =         1
//#define TWPU_PLATEN              =        2
//#define TWPU_ELEVATOR500          =       3
//#define TWPU_ELEVATOR250           =      4
//#define TWPU_ELEVATOR100            =     5
//#define TWPU_ELEVATOR750             =    6
//#define TWPU_ELEVATOR100PLATEN        =   7
//#define TWPU_ELEVATOR250PLATEN         =  8
//#define TWPU_ELEVATOR500PLATEN          = 9
//#define TWPU_ELEVATOR750PLATEN           =10
//#define TWPU_ELEVATOR300                = 11
//#define TWPU_ELEVATOR300PLATEN           =12

//    // CAP_PATCHCOUNT
//    // Type:        TWTY_INT32
//    // Container:   OneValue
//    // Allowed:     0 - 32767
//    // Default:     0
//    // Notes:       Count of patches per scan session
//#define CAP_PATCHCOUNT                     = 0x8087


//    // CAP_PATCHHEAD1
//    // Type:        TWTY_BOOL
//    // Container:   OneValue
//    // Allowed:     TRUE / FALSE
//    // Default:     TRUE
//    // Notes:       Enables/disables the first patch reader.
//#define CAP_PATCHHEAD1                   = 0x80BF


//    // CAP_PATCHHEAD2
//    // Type:        TWTY_BOOL
//    // Container:   OneValue
//    // Allowed:     TRUE / FALSE
//    // Default:     TRUE
//    // Notes:       Enables/disables the second patch reader.
//#define CAP_PATCHHEAD2                   = 0x80C0


//    // CAP_PATCHHEAD3
//    // Type:        TWTY_BOOL
//    // Container:   OneValue
//    // Allowed:     TRUE / FALSE
//    // Default:     TRUE
//    // Notes:       Enables/disables the third patch reader.
//#define CAP_PATCHHEAD3                   = 0x80C1


//    // CAP_PATCHHEAD4
//    // Type:        TWTY_BOOL
//    // Container:   OneValue
//    // Allowed:     TRUE / FALSE
//    // Default:     TRUE
//    // Notes:       Enables/disables the fourth patch reader.
//#define CAP_PATCHHEAD4                   = 0x80C2


//    // CAP_PCARDENABLED
//    // Type:        TWTY_BOOL
//    // Container:   OneValue (per camera)
//    // Allowed:     TRUE / FALSE
//    // Default:     TRUE
//    // Notes:       Enables/disables the P-Card (note that this operates
//    //              in tandem with the DAT_PCARD operation, setting this
//    //              value here or there will modify both values).
//    //              This capability is not available at this time.
//#define CAP_PCARDENABLED                   = 0x806A


//    // CAP_POWEROFFTIMEOUT
//    // Type:        TWTY_INT32
//    // Container:   Range
//    // Allowed:     typically 0 - 240 (minutes)
//    // Default:     typically 60
//    // Notes:       When CAP_ENERGYSTAR is supported, then this is the minutes of
//    //              idle time following CAP_ENERGYSTAR before device is powered off.
//    //              This feature is not available for all models.
//#define CAP_POWEROFFTIMEOUT                     = 0x810C


//    // CAP_POWEROFFTIMEOUTENABLED
//    // Type:        TWTY_BOOL
//    // Container:   OneValue
//    // Allowed:     TRUE / FALSE
//    // Default:     TRUE
//    // Notes:       Allows the user to turn the “power off timeout”
//    //              feature On and Off.
//    //              This feature is not available for all models.
//#define CAP_POWEROFFTIMEOUTENABLED			    = 0x8124


//    // CAP_ENHANCEDSEPARATION
//    // Type:        TWTY_BOOL
//    // Container:   OneValue
//    // Allowed:     TRUE / FALSE
//    // Default:     TRUE
//    // Notes:       Allows the user to turn “Separation” on/off. If true, then
//    //              the initial document in the stack will feed slowly to avoid
//    //				slug feeding.
//#define CAP_ENHANCEDSEPARATION						0x8141


//    // CAP_PRINTERDATE
//    // Type:        TWTY_STR255
//    // Container:   OneValue
//    // Allowed:     Text
//    // Default:     ""
//    // Notes:       This will set the scanner to a specific date prior to printing.
//    //              The scanner will be returned to the original date afterwards.
//    //		        Set to "" to disable.
//    //		        Format:		YYYY/MM/DD		(YYYY - year, MM - month, DD - day)
//#define CAP_PRINTERDATE                    = 0x80BC


//    // CAP_PRINTERDATEDELIMITER
//    // Type:        TWTY_UINT16
//    // Container:   Enumeration
//    // Allowed:     (see list below)
//    // Default:     typically TWPD_NONE
//    // Notes:       Selects the delimiter to be used in the date
//    //              (not the time, though, time always uses a
//    //              delimiter of colon ':').
//#define CAP_PRINTERDATEDELIMITER           = 0x801C
//#define TWPD_NONE              =           0
//#define TWPD_FORWARDSLASH       =          1
//#define TWPD_HYPHEN              =         2
//#define TWPD_PERIOD               =        3
//#define TWPD_BLANK                 =       4


//    // CAP_PRINTERDATEFORMAT
//    // Type:        TWTY_UINT16
//    // Container:   Enumeration
//    // Allowed:     typically TWPE_MMDDYYYY, TWPE_DDMMYYYY, TWPE_YYYYMMDD, TWPE_DDD, TWPE_YYYYDDD
//    // Default:     typically TWPE_YYYYMMDD
//    // Notes:       Selects the format to be used to display
//    //              the date (not the time, though).
//#define CAP_PRINTERDATEFORMAT              = 0x8033
//#define TWPE_MMDDYYYY           =          0
//#define TWPE_DDMMYYYY            =         1
//#define TWPE_YYYYMMDD             =        2
//#define TWPE_DDD                   =       3
//#define TWPE_YYYYDDD                =      4
//#define TWPE_DDMMYY                  =     5
//#define TWPE_MMDDYY                   =    6
//#define TWPE_YYDDD                     =   7
//#define TWPE_YYMMDD                     =  8


//    // CAP_PRINTERFONT
//    // Type:        TWTY_UINT16
//    // Allowed:     typically  TWPN_LARGECOMIC,TWPN_LARGECINE,TWPN_LARGECOMIC180,TWPN_LARGECINE180,
//    //                      TWPN_SMALLCOMIC,TWPN_SMALLCINE,TWPN_SMALLCOMIC180,TWPN_SMALLCINE180,
//    //                      TWPN_BOLDLARGECOMIC,TWPN_BOLDLARGECINE,TWPN_BOLDLARGECOMIC180,TWPN_BOLDLARGECINE180
//    // Default:     typically TWPN_SMALLCOMIC or TWPN_LARGECOMIC
//    //              
//    //              
//    // Notes:       elects the printer font to be used.
//    //				Small also means 'Normal'; Large also means 'Bold'; BoldLarge also means 'ExtraBold'
//#define CAP_PRINTERFONT                    = 0x8044
//#define TWPN_LARGECOMIC       =            0
//#define TWPN_LARGECINE         =           1
//#define TWPN_LARGECOMIC180      =          2
//#define TWPN_LARGECINE180        =         3
//#define TWPN_SMALLCOMIC           =        4
//#define TWPN_SMALLCINE             =       5
//#define TWPN_SMALLCOMIC180          =      6
//#define TWPN_SMALLCINE180            =     7
//#define TWPN_BOLDLARGECOMIC           =    8
//#define TWPN_BOLDLARGECINE             =   9
//#define TWPN_BOLDLARGECOMIC180          =  10
//#define TWPN_BOLDLARGECINE180            = 11
//#define TWPN_BOLDSMALLCOMIC               =12
//#define TWPN_BOLDSMALLCINE               = 13
//#define TWPN_BOLDSMALLCOMIC180            =14
//#define TWPN_BOLDSMALLCINE180             =15


//    // CAP_PRINTERFONTFORMAT
//    // Type:        TWTY_UINT16
//    // Allowed:     TWPFF_NORMAL, TWPFF_BLOCK
//    // Default:     TWPFF_NORMAL
//    //              
//    // Notes:       elects the printer font format to be used
//#define CAP_PRINTERFONTFORMAT            = 0x80BE
//#define TWPFF_NORMAL             =         0
//#define TWPFF_BLOCK              =         1


//    // CAP_PRINTERFONTRESIZE
//    // Type:        TWTY_INT32
//    // Container:   Range
//    // Allowed:     -5 to 5 step 1
//    // Default:     0
//    // Notes:       Allows you to adjust the width of the font.
//    //              This option only affects what is printed on the
//    //              physical sheet of paper.
//    //              This feature is not available for all models.
//#define CAP_PRINTERFONTRESIZE            = 0x8138


//    // CAP_PRINTERIMAGEADDRESSFORMAT
//    // Type:        TWTY_UINT16
//    // Container:   Enumeration
//    // Allowed:     (see list below)
//    // Default:     typically TWPI_SUPPRESSLEADINGZEROS
//    // Notes:       Selects the print format of leading zeros
//    //              in the image address.
//#define CAP_PRINTERIMAGEADDRESSFORMAT      = 0x8045
//#define TWPI_DISPLAYLEADINGZEROS    =      0
//#define TWPI_SUPPRESSLEADINGZEROS  =       1
//#define TWPI_COMPRESSLEADINGZEROS   =      2


//    // CAP_PRINTERIMAGEADDRESSLEVEL
//    // Type:        TWTY_UINT16
//    // Container:   Enumeration
//    // Allowed:     typically TWPL_LEVEL1, TWPL_LEVEL2, TWPL_LEVEL3,
//    //                     TWPL_ALLLEVELS
//    // Default:     TWPL_ALLLEVELS
//    // Notes:       Selects the image address level that printing
//    //              will occur on.  A value of TWPL_ALLLEVELS
//    //              overrides any of the others.
//#define CAP_PRINTERIMAGEADDRESSLEVEL       = 0x8047
//#define TWPL_LEVEL0           =            0
//#define TWPL_LEVEL1            =           1
//#define TWPL_LEVEL2             =          2
//#define TWPL_LEVEL3              =         3
//#define TWPL_ALLLEVELS            =        4
//#define TWPL_NONE                  =       5


//    // CAP_PRINTERINDEXDIGITS
//    // Type:        TWTY_UINT16
//    // Container:   Range
//    // Allowed:     1 - 9
//    // Default:     9
//    // Notes:       Sets the number of digits of the counter to be
//    //              printed.  Note that the data will be truncated
//    //              if the number of digits in the count exceeds
//    //              this value.
//#define CAP_PRINTERINDEXDIGITS             = 0x801B


//    // CAP_PRINTERINDEXFORMAT
//    // Type:        TWTY_UINT16
//    // Container:   Enumeration
//    // Allowed:     (see CAP_PRINTERIMAGEADDRESSFORMAT)
//    // Default:     typically TWPI_DISPLAYLEADINGZEROS
//    // Notes:       Selects the use of leading zeros or spaces when
//    //              printing the counter value.
//#define CAP_PRINTERINDEXFORMAT             = 0x801A


//    // CAP_PRINTERINDEXINCREMENT
//    // Type:        TWTY_UINT16
//    // Container:   Enumeration
//    // Allowed:     all
//    // Default:     TWPII_EVERYSHEET
//    // Notes:       Allows the user to choose when the
//    //              counter is incremented.
//#define CAP_PRINTERINDEXINCREMENT          = 0x8127
//#define TWPII_EVERYSHEET         =         0
//#define TWPII_PATCHTYPE1          =        1
//#define TWPII_PATCHTYPE2           =       2
//#define TWPII_PATCHTYPE3            =      3
//#define TWPII_PATCHTRANSFER          =     4
//#define TWPII_PATCHTYPE6              =    5


//    // CAP_PRINTERINDEXRESET
//    // Type:        TWTY_UINT16
//    // Container:   Enumeration
//    // Allowed:     all
//    // Default:     TWPIR_NEVER
//    // Notes:       Allows the user to choose when the
//    //              counter is reset.
//#define CAP_PRINTERINDEXRESET              = 0x8128
//#define TWPIR_NEVER            =           0
//#define TWPIR_PATCHTYPE1        =          1
//#define TWPIR_PATCHTYPE2         =         2
//#define TWPIR_PATCHTYPE3          =        3
//#define TWPIR_PATCHTRANSFER        =       4
//#define TWPIR_PATCHTYPE6            =      5


//    // CAP_PRINTERINDEXRESETVALUE
//    // Type:        TWTY_UINT32
//    // Container:   Range
//    // Allowed:     0 to 999,999,999
//    // Default:     0
//    // Notes:       Allows the user to choose what value the
//    //              counter is reset to, when it gets reset.
//    //              Limited by CAP_PRINTERINDEXDIGITS.
//#define CAP_PRINTERINDEXRESETVALUE         = 0x8129


//    // CAP_PRINTERPOSITION
//    // Type:        TWTY_FIX32
//    // Container:   Range
//    // Allowed:     Scanner specific
//    // Default:     Scanner specific
//    // Notes:       Selects the printer position (y-offset, in ICAP_UNITS)
//    //              to be used as the starting position for printing.
//#define CAP_PRINTERPOSITION                = 0x8046


//    // CAP_PRINTERTIME
//    // Type:        TWTY_STR255
//    // Container:   OneValue
//    // Allowed:     Text
//    // Default:     ""
//    // Notes:       This will set the scanner to a specific time prior to printing.
//    //              The scanner will be returned to the original time afterwards.
//    //		        Set to "" to disable.
//    //		        Format:		HH:MM		(HH - hour (0-23), MM - minutes (0-59),
//    //              i.e. 00:00->23:59)
//#define CAP_PRINTERTIME                    = 0x80BD


//    // CAP_PRINTERTIMEFORMAT
//    // Type:        TWTY_UINT16
//    // Container:   Enumeration
//    // Allowed:     all
//    // Default:     TWPTF_HHMM24
//    // Notes:       Selects the format to be used to print
//    //              the time.
//#define CAP_PRINTERTIMEFORMAT              = 0x8126
//#define TWPTF_HHMM24         =             0
//#define TWPTF_HHMMSS24        =            1
//#define TWPTF_HHMMSSXX24       =           2
//#define TWPTF_HHMM12            =          3
//#define TWPTF_HHMMSS12           =         4
//#define TWPTF_HHMMSSXX12          =        5
//#define TWPTF_HHMMTT               =       6
//#define TWPTF_HHMMSSTT              =      7
//#define TWPTF_HHMMSSXXTT             =     8


//    // CAP_PRINTERWRITESEQUENCE
//    // Type:        TWTY_UINT16
//    // Allowed:     All the stuff below (sheesh)...
//    // Notes:       Selects the write sequence.
//#define CAP_PRINTERWRITESEQUENCE           = 0x8049
//#define TWPW_NONE                 =        0
//#define TWPW_FULLIAALLDELIMITERS   =       1
//#define TWPW_FULLIANODELIMITERS     =      2
//#define TWPW_FULLIAFIXEDDELIMITERS   =     3
//#define TWPW_DELIMITER                =    4
//#define TWPW_FIXEDIA                   =   5
//#define TWPW_INDEXIA                    =  6
//#define TWPW_CURRENTLEVELIA              = 7
//#define TWPW_DATE           =              8
//#define TWPW_DAY             =             9
//#define TWPW_TIME             =            10
//#define TWPW_DOCUMENTCOUNT     =           11
//#define TWPW_MESSAGE1           =          12
//#define TWPW_MESSAGE2            =         13
//#define TWPW_MESSAGE3             =        14
//#define TWPW_MESSAGE4              =       15
//#define TWPW_MESSAGE5               =      16
//#define TWPW_MESSAGE6                =     17
//#define TWPW_MESSAGE7                  =   18
//#define TWPW_MESSAGE8                   =  19
//#define TWPW_MESSAGE9   =                  20
//#define TWPW_SPACE       =                 21
//#define TWPW_TEXT         =                22
//#define TWPW_INDEX         =               23
//#define TWPW_MMDDYYYY       =              24
//#define TWPW_DDMMYYYY        =             25
//#define TWPW_YYYYMMDD         =            26
//#define TWPW_IMAGEADDRESS_A    =           27
//#define TWPW_IMAGEADDRESS_B     =          28
//#define TWPW_IMAGEADDRESS_C      =         29
//#define TWPW_IMAGEADDRESS_D       =        30


//    // CAP_PRINTERWRITESEQUENCEINDEX
//    // Type:        TWTY_UINT16
//    // Allowed:     1 - 7
//    // Notes:       Selects the write sequence index.
//#define CAP_PRINTERWRITESEQUENCEINDEX      = 0x8048


//    // CAP_PRINTERWRITESEQUENCEMESSAGE1 - 12
//    // Type:        TWTY_STR255
//    // Container:   OneValue
//    // Allowed:     A2O2/Falcon/Panther only has one message
//    //              Prism/Phoenix/Wildfire/Inferno: 1 to 6
//    // Default:     typically 111
//    // Notes:       5000/7000 only...selects the write sequence
//    //              messages (1 - 9).  i800 only...selects the
//    //              write sequence messages 1-6 if the levels
//    //              are independent and 7-12 for 'all' levels.
//#define CAP_PRINTERWRITESEQUENCEMESSAGE1   = 0x800C
//#define CAP_PRINTERWRITESEQUENCEMESSAGE2   = 0x800D
//#define CAP_PRINTERWRITESEQUENCEMESSAGE3   = 0x800E
//#define CAP_PRINTERWRITESEQUENCEMESSAGE4   = 0x800F
//#define CAP_PRINTERWRITESEQUENCEMESSAGE5   = 0x8010
//#define CAP_PRINTERWRITESEQUENCEMESSAGE6   = 0x8011
//#define CAP_PRINTERWRITESEQUENCEMESSAGE7   = 0x8012
//#define CAP_PRINTERWRITESEQUENCEMESSAGE8   = 0x8013
//#define CAP_PRINTERWRITESEQUENCEMESSAGE9   = 0x8014
//#define CAP_PRINTERWRITESEQUENCEMESSAGE10  = 0x8034
//#define CAP_PRINTERWRITESEQUENCEMESSAGE11  = 0x8035
//#define CAP_PRINTERWRITESEQUENCEMESSAGE12  = 0x8036


//    // CAP_PRINTERWRITESEQUENCEMESSAGEINDEX
//    // Type:        TWTY_UINT16
//    // Container:   OneValue
//    // Allowed:     typically 1 or 1 - 6
//    // Default:     1
//    // Notes:       Selects the write sequence messages.
//#define CAP_PRINTERWRITESEQUENCEMESSAGEINDEX = 0x808A


//    // CAP_PRINTERWRITESEQUENCESPACE
//    // Type:        TWTY_UINT16
//    // Allowed:     Number of blanks...
//    // Notes:       5000/7000 only.  Blank count for the write sequence.
//#define CAP_PRINTERWRITESEQUENCESPACE      = 0x800A


//    // CAP_PRINTERWRITESEQUENCESPACESTRING
//    // Type:        TWTY_STR255
//    // Allowed:     The WriteSequenceSpace string...
//    // Notes:       5000/7000 only.  Selects the write sequence
//    //              count of spaces.
//#define CAP_PRINTERWRITESEQUENCESPACESTRING= 0x800B


//    // CAP_PRINTERWRITESEQUENCESTRING
//    // Type:        TWTY_STR255
//    // Allowed:     The WriteSequence string...
//    // Notes:       5000/7000 only.  Selects the write sequence.
//#define CAP_PRINTERWRITESEQUENCESTRING     = 0x8009


//    // CAP_PRINTONIMAGEFRONT
//    // Type:        TWTY_BOOL
//    // Container:   OneValue
//    // Allowed:     TRUE / FALSE
//    // Default:     FALSE
//    // Notes:       Allows the user to turn the “digital printing” feature
//    //              On and Off for the Front image.
//#define CAP_PRINTONIMAGEFRONT              = 0x812A


//    // CAP_PRINTONIMAGEREAR
//    // Type:        TWTY_BOOL
//    // Container:   OneValue
//    // Allowed:     TRUE / FALSE
//    // Default:     FALSE
//    // Notes:       Allows the user to turn the “digital printing” feature
//    //              On and Off for the Rear image.
//#define CAP_PRINTONIMAGEREAR               = 0x812B


//    // CAP_PRINTONIMAGEPOSITIONX
//    // Type:        TWTY_FIX32
//    // Container:   Range
//    // Allowed:     Scanner specific
//    // Default:     Scanner specific
//    // Notes:       Allows the user to choose the x-offset (in ICAP_UNITS) from
//    //              the left edge of the image to place the digital print string.
//#define CAP_PRINTONIMAGEPOSITIONX          = 0x812C


//    // CAP_PRINTONIMAGEPOSITIONY
//    // Type:        TWTY_FIX32
//    // Container:   Range
//    // Allowed:     Scanner specific
//    // Default:     Scanner specific
//    // Notes:       Allows the user to choose the y-offset (in ICAP_UNITS)
//    //              from the top of the image to place the digital print string.
//#define CAP_PRINTONIMAGEPOSITIONY          = 0x812D


//    // CAP_PROFILES
//    // Type:        TWTY_UINT16
//    // Container:   Enumeration
//    // Allowed:     (see list below)
//    // Default:     TWPO_DEFAULT
//    // Notes:       THIS IS DEPRECATED TWAIN 10.X+. DAT_PROFILES SHOULD BE USED INSTEAD.
//    //              Selects the current profile. This set the current settings from
//    //              the selected profile to the driver.
//    //              Or see the CUSTOMDSDATA that works the same as profile.
//    //              See the MSG_SETUPDS on how to download the settings to the scanner
//    //              without enable the scanning session.
//    //              Also refer to DAT_PROFILES later in this file.
//#define CAP_PROFILES                       = 0x809F
//#define TWPO_UNKNOWN =                    -1
//#define TWPO_DEFAULT  =                   0
//#define TWPO_FILE01    =                  1
//#define TWPO_FILE02     =                 2
//#define TWPO_FILE03      =                3
//#define TWPO_FILE04       =               4
//#define TWPO_FILE05        =              5
//#define TWPO_FILE06         =             6
//#define TWPO_FILE07          =            7
//#define TWPO_FILE08           =           8
//#define TWPO_FILE09            =          9
//#define TWPO_FILE10             =         10
//#define TWPO_FILE11              =        11
//#define TWPO_FILE12               =       12
//#define TWPO_FILE13                =      13
//#define TWPO_FILE14                 =     14
//#define TWPO_FILE15                  =    15
//#define TWPO_FILE16                   =   16
//#define TWPO_FILE17                    =  17
//#define TWPO_FILE18                     = 18
//#define TWPO_FILE19                      =19
//#define TWPO_FILE20 =                     20
//#define TWPO_FILE21  =                    21
//#define TWPO_FILE22   =                   22
//#define TWPO_FILE23    =                  23
//#define TWPO_FILE24     =                 24
//#define TWPO_FILE25      =                25
//#define TWPO_FILE26       =               26
//#define TWPO_FILE27        =              27
//#define TWPO_FILE28         =             28
//#define TWPO_FILE29          =            29
//#define TWPO_FILE30           =           30
//#define TWPO_FILE31            =          31
//#define TWPO_FILE32             =         32
//#define TWPO_FILE33              =        33
//#define TWPO_FILE34               =       34
//#define TWPO_FILE35                =      35
//#define TWPO_FILE36                 =     36
//#define TWPO_FILE37                  =    37
//#define TWPO_FILE38                   =   38
//#define TWPO_FILE39                    =  39
//#define TWPO_FILE40                     = 40
//#define TWPO_FILE41                      =41
//#define TWPO_FILE42     =                 42
//#define TWPO_FILE43      =                43
//#define TWPO_FILE44       =               44
//#define TWPO_FILE45        =              45
//#define TWPO_FILE46         =             46
//#define TWPO_FILE47          =            47
//#define TWPO_FILE48           =           48
//#define TWPO_FILE49            =          49
//#define TWPO_FILE50             =         50
//#define TWPO_FILE51              =        51
//#define TWPO_FILE52               =       52
//#define TWPO_FILE53                =      53
//#define TWPO_FILE54                 =     54
//#define TWPO_FILE55                  =    55
//#define TWPO_FILE56                   =   56
//#define TWPO_FILE57                    =  57
//#define TWPO_FILE58                     = 58
//#define TWPO_FILE59                      =59
//#define TWPO_FILE60                     = 60


//    // CAP_SIDESDIFFERENT
//    // Type:        TWTY_BOOL
//    // Container:   OneValue (per camera)
//    // Allowed:     TRUE / FALSE
//    // Default:     FALSE
//    // Notes:       When this is TRUE the user can set different values for the
//    //              front and rear camera.
//    //              Setting this to FALSE will copy all the front settings to the
//    //              rear for the current camera.
//    //              This will automatically change to TRUE when the front and
//    //              rear no longer match.  Note: a value of TRUE does NOT imply
//    //              that the sides are different (e.g. if everything matches and
//    //              this is set to TRUE)
//#define CAP_CAMERALINK	                   = 0x80B7 // deprecated after v7.55
//#define CAP_SIDESDIFFERENT                 = 0x80B7 // available since v7.56


//    // CAP_SIMULATING
//    // Type:        TWTY_BOOL
//    // Container:   OneValue
//    // Allowed:     TRUE / FALSE
//    // Default:     FALSE
//    // Notes:       Simulate the scanner.
//#define CAP_SIMULATING                     = 0x810B


//    // CAP_SLEEVEDOCUMENT
//    // Type:        TWTY_UINT16
//    // Container:   Enumeration
//    // Allowed:     (Scanner specific) none, frontonbottom, frontonleft, frontonright,
//    //				frontontop, onesidedfront, onesidedrear, twosided
//    // Default:     none
//    // Notes:       For scanners that support scanning documents in a custom sleeve. The sleeve
//    //				may be intermixed with other documents in a batch. Sleeve may be used to scan
//    //				folded A3 documents, or delicate documents (without forcing a merge of front/
//    //				rear images). If enabled with an option, scanner will not report a multifeed.
//#define CAP_SLEEVEDOCUMENT					0x8144
//#define TWSLD_NONE			=				0
//#define TWSLD_FOLDED		=				1
//#define TWSLD_ONESIDEDFRONT	=				2
//#define TWSLD_ONESIDEDREAR	=				3
//#define TWSLD_TWOSIDED		=				4


//    // CAP_SNAPTOSIZEENABLED
//    // Type:        TWTY_BOOL
//    // Container:   OneValue
//    // Allowed:     TRUE / FALSE
//    // Default:     FALSE
//    // Notes:       Enables/disables the “snap to size” feature. If a scanned document’s
//    //              dimensions are close to a known ISO paper size, the image will either
//    //              stretch or shrink the document dimensions to be exactly the known ISO
//    //              paper size. The list of ISO paper sizes to check can be specified using
//    //              CAP_SNAPTOSIZE.
//#define CAP_SNAPTOSIZEENABLED		=		0x814B


//    // CAP_SNAPTOSIZE
//    // Type:        TWTY_UINT16
//    // Container:   TWON_ARRAY
//    // Allowed:     Scanner specific. Typically, TWSS_A3, TWSS_A4, TWSS_A5, TWSS_A6,
//    //              TWSS_A7, TWSS_C4, TWSS_C5, TWSS_C6, TWSS_C7, TWSS_ISOB4, TWSS_ISOB5,
//    //              TWSS_ISOB6, TWSS_ISOB7, TWSS_JISB4, TWSS_JISB5, TWSS_JISB6, TWSS_JISB7,
//    //              TWSS_JISB8, TWSS_NONE, TWSS_USEXECUTIVE, TWSS_USLEDGER, TWSS_USLEGAL,
//    //              TWSS_USLETTER, TWSS_USSTATEMENT
//    // Default:     Typically, TWSS_USLETTER and TWSS_USLEDGER (11x17) for PCs with US units
//    //              of measure, and TWSS_A3 and TWSS_A4 for PCs with Metric units of measure.
//    // Notes:       Contains the list of ISO “snap to size” paper sizes. If a scanned document’s
//    //              dimensions are close to one of these sizes, the image will either
//    //              stretch or shrink the document dimensions to be exactly the matched ISO
//    //              paper size.
//#define CAP_SNAPTOSIZE				=		0x814C


//    // CAP_SPLITDOCUMENTCOUNT
//    // Type:        TWTY_UINT16
//    // Container:   Enumeration
//    // Allowed:     (Scanner specific) none, intotwoimages, imtothreeimages
//    // Default:     none
//    // Notes:       Indicates that images will be split into a certain amount
//    //				of images if they fall into the length mode ranges.
//#define CAP_SPLITDOCUMENTCOUNT				0x8145
//#define TWSDC_NONE				=			0
//#define TWSDC_INTOTWOIMAGES		=			1
//#define TWSDC_INTOTHREEIMAGES		=		2


//    // CAP_SPLITDOCUMENTLENGTHMODE
//    // Type:        TWTY_UINT16
//    // Container:   Enumeration
//    // Allowed:     (Scanner specific) lessthan, greaterthan, between
//    // Default:     lessthan
//    // Notes:       Indicates the length mode being used to make split document decisions.
//    //				The length mode only has meaning if CAP_SPLITDOCUMENTCOUNT is not NONE.
//#define CAP_SPLITDOCUMENTLENGTHMODE			0x8146
//#define TWSDLM_LESSTHAN				=		0
//#define TWSDLM_GREATERTHAN		=			1
//#define TWSDLM_BETWEEN			=			2


//    // CAP_SPLITDOCUMENTLENGTH1
//    // Type:        TWTY_FIX32
//    // Container:   Range
//    // Allowed:     Scanner-specific
//    // Default:     Scanner-specific (min range value)
//    // Notes:       Split Document length1 (in ICAP_UNITS).
//    //              If CAP_SPLITDOCUMENTLENGTHMODE is "less than", then any image shorter
//    //              than this value will be split into another image.
//    //              If CAP_SPLITDOCUMENTLENGTHMODE is "greater than", then any image longer
//    //              than this value will be split into another image.
//    //              If CAP_SPLITDOCUMENTLENGTHMODE is "between", then any images longer than
//    //              this value and shorter than CAP_SPLITDOCUMENTLENGTH2 will be split into
//    //				another image.
//    //              Only valid if CAP_SPLITDOCUMENTCOUNT is not NONE
//    //              The min/max is determined by the scanner, so an application
//    //              may want to ask for those values.
//#define CAP_SPLITDOCUMENTLENGTH1			0x8147


//    // CAP_SPLITDOCUMENTLENGTH2
//    // Type:        TWTY_FIX32
//    // Container:   Range
//    // Allowed:     Scanner-specific
//    // Default:     Scanner-specific (min range value)
//    // Notes:       Split Document length2 (in ICAP_UNITS).
//    //              If CAP_SPLITDOCUMENTLENGTHMODE is "between", then any images longer than
//    //              CAP_SPLITDOCUMENTLENGTH1 and shorter than CAP_SPLITDOCUMENTLENGTH2 will be
//    //				split into another image.
//    //              Only valid if CAP_SPLITDOCUMENTCOUNT is not NONE and CAP_SPLITDOCUMENTLENGHMODE
//    //              is set to TWSDLM_BETWEEN.
//    //              The min/max is determined by the scanner, so an application
//    //              may want to ask for those values.
//#define CAP_SPLITDOCUMENTLENGTH2            = 0x8148


//    // CAP_SUPPORTEDSIZES
//    // Type:        TWTY_UINT16
//    // Container:   Enumeration
//    // Allowed:     (see list below)
//    // Default:     TWSS_A4
//    // Notes:       This list adds custom values to this standard TWAIN
//    //              capability.  The TWSS_USER* values may be set up by
//    //              an end-user through the CONST.INI and appropriate
//    //              language file(s) to add custom sizes to the existing
//    //              list.  See the CONST.INI file under the section
//    //              [SupportedSizes] for more info on how to do this.
//#define TWSS_6X5                           = 0x8001
//#define TWSS_12X12                         = 0x8002
//#define TWSS_3X5                           = 0x8003        // 3.5 x 5
//#define TWSS_4X6                           = 0x8004
//#define TWSS_5X7                           = 0x8005
//#define TWSS_8X10                          = 0x8006
//#define TWSS_4X7                           = 0x8007
//#define TWSS_4X10                          = 0x8008
//#define TWSS_100X150                       = 0x8009
//#define TWSS_127X177                       = 0x8010
//#define TWSS_90X130                        = 0x8011
//#define TWSS_57X88                         = 0x8012        // 57.17 x 88.9
//#define TWSS_5X3                           = 0x8013        // 3.5 x 5
//#define TWSS_6X4                           = 0x8014
//#define TWSS_7X5                           = 0x8015
//#define TWSS_7X4                           = 0x8016
//#define TWSS_150X100                       = 0x8017
//#define TWSS_177X127                       = 0x8018
//#define TWSS_130X90                        = 0x8019
//#define TWSS_88X57                         = 0x8020        // 57.17 x 88.9
//#define TWSS_USER0                         = 0x8100
//#define TWSS_USER1                         = 0x8101
//#define TWSS_USER2                         = 0x8102
//#define TWSS_USER3                         = 0x8103
//#define TWSS_USER4                         = 0x8104
//#define TWSS_USER5                         = 0x8105
//#define TWSS_USER6                         = 0x8106
//#define TWSS_USER7                         = 0x8107
//#define TWSS_USER8                         = 0x8108
//#define TWSS_USER9                         = 0x8109


//    // CAP_TOGGLEPATCH
//    // Type:        TWTY_UINT16
//    // Container:   Enumeration
//    // Allowed:     (see list below)
//    // Default:     TWTP_DISABLED
//    // Notes:       Controls recognition of the color patch.
//#define CAP_TOGGLEPATCH                    = 0x806D
//#define TWTP_DISABLED    =                 0
//#define TWTP_BOTHSIDE      =               1
//#define TWTP_FRONTSIDE    =                2
//#define TWTP_SAMESIDE      =               4
//#define TWTP_DETECTONLY      =             7


//    // CAP_TRANSPORTAUTOSTART
//    // Type:        TWTY_BOOL
//    // Container:   OneValue
//    // Allowed:     TRUE (readonly) or TRUE / FALSE
//    // Default:     if not readonly, then FALSE; otherwise TRUE
//    // Notes:       A value of TRUE will cause the scanner transport to
//    //              start up when the MSG_ENABLEDS command is issued.
//#define CAP_TRANSPORTAUTOSTART             = 0x8029


//    // CAP_TRANSPORTTIMEOUT
//    // Type:        TWTY_INT32
//    // Container:   Range
//    // Allowed:     typically 0-120
//    // Default:     typically 0, 2 or 5
//    // Notes:       Number of seconds before transport times out.
//#define CAP_TRANSPORTTIMEOUT               = 0x8003


//    // CAP_TRANSPORTTIMEOUTRESPONSE
//    // Type:        TWTY_UINT16
//    // Container:   Enumeration
//    // Allowed:     typically TWTR_ENDOFJOB or TWTR_STOPFEEDER, TWTR_ENDOFJOB
//    // Default:     typically TWTR_STOPFEEDER, uf not supported then TWTR_ENDOFJOB
//    // Notes:       Selects action taken when the transport times out.
//    //              If the transport timeout is disabled, then this
//    //              capability is ignored.
//#define CAP_TRANSPORTTIMEOUTRESPONSE       = 0x8028
//#define TWTR_STOPFEEDER     =             0
//#define TWTR_ENDOFJOB       =             1
//#define TWTR_WAITFORPAPER    =            2


//    // CAP_ULTRASONICSENSITIVITY
//    // Type:        TWTY_UINT16
//    // Container:   Enumeration
//    // Allowed:     See below...
//    // Default:     TWUS_DISABLED
//    // Notes:       Controls the sensitivity of the ultrasonic multifeed
//    //              detector.
//    //
//    //              Please note that there is a conflict with version 2.2 of the
//    //              TWAIN Spec.  Previous versions of kds_cust.h defined TWUS_*
//    //              values.  This behavior is still supported if used with
//    //              a TWAIN 2.1 twain.h or earlier.
//    //
//    //              Applications must change to use TWUSS_* with CAP_ULTRASONICSENSITIVITY,
//    //              this will work with any version of the driver.
//    //
//    //              Only use TWUS_* with the standard CAP_DOUBLEFEEDDETECTIONSENSITIVITY
//    //              capability.
//#define CAP_ULTRASONICSENSITIVITY          = 0x8027
//# ifndef CAP_DOUBLEFEEDDETECTIONSENSITIVITY
//#define TWUS_DISABLED       =             0
//#define TWUS_LOW             =            1
//#define TWUS_MEDIUM          =            2
//#define TWUS_HIGH             =           3
//#endif
//#define TWUSS_DISABLED            =           0
//#define TWUSS_LOW                 =           1
//#define TWUSS_MEDIUM              =           2
//#define TWUSS_HIGH                =           3


//    // CAP_ULTRASONICSENSOR*
//    // Type:        TWTY_UINT16
//    // Container:   Enumeration
//    // Allowed:     See below...
//    // Default:     TWUO_ENABLED
//    // Notes:       Controls the individual ultrasonic sensor
//    //              detector.
//#define CAP_ULTRASONICSENSORCENTER         = 0x808F
//#define CAP_ULTRASONICSENSORLEFT           = 0x8090
//#define CAP_ULTRASONICSENSORRIGHT          = 0x8091
//#define CAP_ULTRASONICSENSORLEFTCENTER     = 0x8105
//#define CAP_ULTRASONICSENSORRIGHTCENTER    = 0x8106
//#define TWUO_DISABLED            =        0
//#define TWUO_ENABLED             =        1
//#define TWUO_IGNOREZONE          =        2


//    // CAP_ULTRASONICSENSORZONEHEIGHT
//    // Type:        TWTY_FIX32
//    // Container:   Range
//    // Allowed:     Scanner specific
//    // Default:     Scanner specific
//    // Notes:       Height of zone for the CAP_ULTRASONICSENSOR* that
//    //              are set to TWUO_IGNOREZONE
//#define CAP_ULTRASONICSENSORZONEHEIGHT     = 0x8107


//    // CAP_WINDOW
//    // Type:        TWTY_UINT16
//    // Container:   Enumeration
//    // Allowed:     See below..
//    // Default:     TWWW_BASE
//    // Notes:       Deprecated, use CAP_WINDOWCAMERA or DAT_FILESYSTEM.
//#define CAP_WINDOW                         = 0x80AD
//#define TWWW_BASE     =                   0
//#define TWWW_1        =                   1
//#define TWWW_2        =                   2
//#define TWWW_3        =                   3
//#define TWWW_4         =                  4
//#define TWWW_5        =                   5
//#define TWWW_6        =                   6
//#define TWWW_7               =            7
//#define TWWW_8          =                 8
//#define TWWW_9          =                 9
//#define TWWW_10          =                10


//    // CAP_WINDOWCAMERA
//    // Type:        TWTY_UINT16
//    // Container:   Enumeration
//    // Allowed:     See below..
//    // Default:     TWWC_BASE_BITONAL_FRONT
//    // Notes:       Allows for direct addressing of windows.  Does not
//    //				change CAP_SIDESDIFFERENT like DAT_FILESYSTEM.
//#define CAP_WINDOWCAMERA                   = 0x80B4
//#define TWWC_DELETEALL            =       -1
//#define TWWC_BASE_BITONAL_FRONT    =      0
//#define TWWC_BASE_BITONAL_REAR    =       1
//#define TWWC_BASE_COLOR_FRONT      =      2
//#define TWWC_BASE_COLOR_REAR      =       3
//#define TWWC_1_BITONAL_FRONT     =        4
//#define TWWC_1_BITONAL_REAR       =       5
//#define TWWC_1_COLOR_FRONT         =      6
//#define TWWC_1_COLOR_REAR            =    7
//#define TWWC_2_BITONAL_FRONT      =       8
//#define TWWC_2_BITONAL_REAR        =      9
//#define TWWC_2_COLOR_FRONT          =     10
//#define TWWC_2_COLOR_REAR            =    11
//#define TWWC_3_BITONAL_FRONT          =   12
//#define TWWC_3_BITONAL_REAR            =  13
//#define TWWC_3_COLOR_FRONT              = 14
//#define TWWC_3_COLOR_REAR=                15
//#define TWWC_4_BITONAL_FRONT=             16
//#define TWWC_4_BITONAL_REAR  =            17
//#define TWWC_4_COLOR_FRONT    =           18
//#define TWWC_4_COLOR_REAR      =          19
//#define TWWC_5_BITONAL_FRONT    =         20
//#define TWWC_5_BITONAL_REAR      =        21
//#define TWWC_5_COLOR_FRONT        =       22
//#define TWWC_5_COLOR_REAR          =      23
//#define TWWC_6_BITONAL_FRONT        =     24
//#define TWWC_6_BITONAL_REAR          =    25
//#define TWWC_6_COLOR_FRONT            =   26
//#define TWWC_6_COLOR_REAR              =  27
//#define TWWC_7_BITONAL_FRONT            = 28
//#define TWWC_7_BITONAL_REAR =             29
//#define TWWC_7_COLOR_FRONT   =            30
//#define TWWC_7_COLOR_REAR     =           31
//#define TWWC_8_BITONAL_FRONT   =          32
//#define TWWC_8_BITONAL_REAR     =         33
//#define TWWC_8_COLOR_FRONT       =        34
//#define TWWC_8_COLOR_REAR         =       35
//#define TWWC_9_BITONAL_FRONT       =      36
//#define TWWC_9_BITONAL_REAR         =     37
//#define TWWC_9_COLOR_FRONT           =    38
//#define TWWC_9_COLOR_REAR             =   39
//#define TWWC_10_BITONAL_FRONT          =  40
//#define TWWC_10_BITONAL_REAR      =       41
//#define TWWC_10_COLOR_FRONT      =        42
//#define TWWC_10_COLOR_REAR       =        43


//    // CAP_WINDOWPOSITION
//    // Type:        TWTY_FRAME
//    // Container:   OneValue
//    // Allowed:     Anything
//    // Default:     0,0 (top left of screen)
//    // Notes:       Left and Top position of dialog (Width and Height are
//    //              ignored).  Use this to select the location of the
//    //              Source's GUI when it is displayed to the user.
//#define CAP_WINDOWPOSITION                 = 0x8004



//    ////////////////////////////////////////////////////////////////////////////////
//    //                      ICAP Section
//    ////////////////////////////////////////////////////////////////////////////////



//    // ICAP_ADDBORDER
//    // Type:        TWTY_BOOL
//    // Container:   OneValue (per camera)
//    // Allowed:     TRUE / FALSE
//    // Default:     FALSE
//    // Notes:       Adds a black border around a bitonal document.
//#define ICAP_ADDBORDER                     = 0x8023


//#define ICAP_ANSELBRIGHTNESS               = 0x80A0
//#define ICAP_ANSELCONTRAST                 = 0x80A1
//#define ICAP_ANSELHIGHLIGHT                = 0x80A2
//#define ICAP_ANSELMIDTONE                  = 0x80A3


//    // ICAP_ANSELREMOVEREDEYE
//    // Type:        TWTY_BOOL
//    // Container:   OneValue (per camera)
//    // Allowed:     TRUE / FALSE
//    // Default:     FALSE
//    // Notes:       Controls red-eye removal.
//#define ICAP_ANSELREMOVEREDEYE             = 0x80A4


//    // ICAP_ANSELRESTORECOLOR
//    // Type:        TWTY_BOOL
//    // Container:   OneValue (per camera)
//    // Allowed:     TRUE / FALSE
//    // Default:     FALSE
//    // Notes:       Adds a black border around a bitonal document.
//#define ICAP_ANSELRESTORECOLOR             = 0x80A5


//#define ICAP_ANSELSATURATECOLORS           = 0x80A6
//#define ICAP_ANSELSHADOW                   = 0x80A7


//    // ICAP_ANSELSHARPENIMAGE
//    // Type:        TWTY_UINT16
//    // Container:   Enumeration (per camera)
//    // Allowed:     (see below)
//    // Default:     TWASP_DISABLE
//    // Notes:       Controls picture sharpening.
//#define ICAP_ANSELSHARPENIMAGE             = 0x80A8
//#define TWASP_DISABLE          =           0
//#define TWASP_NORMAL           =           1
//#define TWASP_HIGH             =          2
//#define TWASP_EXAGGERATED       =          3


//    // ICAP_ANSELSHASTA
//    // Type:        TWTY_UINT16
//    // Container:   Enumeration (per camera)
//    // Allowed:     (see below)
//    // Default:     TWASH_DISABLE
//    // Notes:       TBD
//#define ICAP_ANSELSHASTA                   = 0x80A9
//#define TWASH_DISABLE          =           0
//#define TWASH_AUTO             =           1
//#define TWASH_MANUAL           =           2


//    // ICAP_AUTOCOLORAMOUNT
//    // Type:        TWTY_INT32
//    // Container:   Range (per camera)
//    // Allowed:     1 to 200
//    // Default:     1
//    // Notes:       The amount of color that needs to be present in a document
//    //              before it will be saved as either a color or grayscale image.
//#define ICAP_AUTOCOLORAMOUNT               = 0x8092


//    // ICAP_AUTOCOLORCONTENT
//    // Type:        TWTY_UINT16
//    // Container:   Enumeration (per camera)
//    // Allowed:     TWCL_NONE,TWCL_LOW,TWCL_MEDIUM,TWCL_HIGH,TWCL_CUSTOM
//    // Default:     TWCL_NONE
//    // Notes:       Preset values for AUTOCOLORAMOUNT and AUTOCOLORTHRESHOLD.
//    //              NONE turns autocolor detection off.
//    //              CUSTOM allows amount and threshold to be set.
//    //              When this is not NONE, CAMERAENABLE has no effect on output
//    //              color (rgb/gray/bw).  Rather, CAMERAENABLE dictates which
//    //				sides should be scanned (front/rear).
//    //              Enabling both color and bitonal for a side indicates both are
//    //              desired as output, and therefore AUTOCOLORCONTENT will be set
//    //              to TWCL_NONE.
//    //              If both color and bitonal are enabled on a side when
//    //              AUTOCOLORCONTENT is turned on, CAMERAENABLED will be set to
//    //              FALSE for the bitonal camera on that side.
//#define ICAP_AUTOCOLORCONTENT              = 0x8093
//#define TWCL_NONE            =             0
//#define TWCL_LOW              =            1
//#define TWCL_MEDIUM           =            2
//#define TWCL_HIGH             =            3
//#define TWCL_CUSTOM             =          4


//    // ICAP_AUTOCOLORTHRESHOLD
//    // Type:        TWTY_INT32
//    // Container:   Range (per camera)
//    // Allowed:     0 to 100
//    // Default:     typically 20 or 50
//    // Notes:       The color threshold or intensity (i.e. pale blue vs. dark blue)
//    //              at which a given a color will be included in the Color Amount
//    //              calculation . A higher value indicates that a more intense color
//    //              is required.
//#define ICAP_AUTOCOLORTHRESHOLD            = 0x8094


//    // ICAP_BACKGROUNDADJUSTAGGRESSIVENESS
//    // Type:        TWTY_INT32
//    // Container:   Range (per color camera)
//    // Allowed:     -10 to 10
//    // Default:     0
//    // Notes:       The background color adjustment aggressiveness
//#define ICAP_BACKGROUNDADJUSTAGGRESSIVENESS   = 0x80B0


//    // ICAP_BACKGROUNDADJUSTAPPLYTO
//    // Type:        TWTY_UINT16
//    // Container:   Enumeration (per color camera)
//    // Allowed:     TWBA_ALL,TWBA_NEUTRAL,TWBA_PREDOMINATE
//    // Default:     TWBA_PREDOMINATE
//    // Notes:       The background color adjustment apply to 
//#define ICAP_BACKGROUNDADJUSTAPPLYTO       = 0x80AF
//#define TWBA_ALL               =           0
//#define TWBA_NEUTRAL            =          1
//#define TWBA_PREDOMINATE        =          2


//    // ICAP_BACKGROUNDADJUSTMODE
//    // Type:        TWTY_UINT16
//    // Container:   Enumeration (per color camera)
//    // Allowed:     TWBS_NONE,TWBS_AUTO,TWBS_CHANGETOWHITE, TWBS_AUTOMATICBASIC
//    // Default:     TWCL_NONE
//    // Notes:       The background smoothing mode
//#define ICAP_BACKGROUNDADJUSTMODE          = 0x80AE
//#define TWBS_NONE               =          0
//#define TWBS_AUTOMATIC          =          1
//#define TWBS_CHANGETOWHITE       =         2
//#define TWBS_AUTOMATICBASIC      =         3


//    // ICAP_BARCODECOUNT
//    // Type:        TWTY_INT32
//    // Container:   Range (per side)
//    // Allowed:     1 to n (Scanner-specific)
//    // Default:     1
//    // Notes:       Indicates how many barcodes to detect.
//    //              This is only available when ICAP_BARCODEDETECTIONENABLED 
//    //              is set to TRUE.
//#define ICAP_BARCODECOUNT                  = 0x811E


//    // ICAP_BARCODEENHANCEMENT
//    // Type:        TWTY_BOOL
//    // Container:   OneValue (per camera)
//    // Allowed:     TRUE / FALSE
//    // Default:     FALSE
//    // Notes:       Allows the user to turn on barcode cleanup (i.e. identify
//    //              barcodes and maximize their readability). 
//#define ICAP_BARCODEENHANCEMENT            = 0x811F


//    // ICAP_BARCODESEARCHAREA
//    // Type:        TWTY_UINT16
//    // Container:   Enumeration (per side)
//    // Allowed:     TWBCSA_ENTIREDOCUMENT, TWBCSA_PARTIALDOCUMENT
//    // Default:     TWBCSA_ENTIREDOCUMENT
//    // Notes:       The area on the page to look for barcodes. This setting only has
//    //              meaning if ICAP_BARCODEDETECTIONENABLED is set to TRUE.
//#define ICAP_BARCODESEARCHAREA             = 0x8120
//#define TWBCSA_ENTIREDOCUMENT    =        0
//#define TWBCSA_PARTIALDOCUMENT     =      1


//    // ICAP_BARCODESEARCHREGION
//    // Type:        TWTY_FRAME
//    // Container:   Enumeration (per side)
//    // Allowed:     0,0 - ICAP_PHYSICALWIDTH,ICAP_PHYSICALHEIGHT
//    // Default:     value of ICAP_SUPPORTEDSIZE
//    // Notes:       If ICAP_BARCODESEARCHAREA is set to TWBCSA_PARTIALDOCUMENT
//    //              then this contains the area on the page to search for bar
//    //              codes (origin, width, height). The minimum size shall be
//    //              1 inch by 1 inch.
//    //              This setting only has meaning if ICAP_BARCODEDETECTIONENABLED
//    //              is set to TRUE, and ICAP_BARCODESEARCHAREA is set to
//    //              TWBCSA_PARTIALDOCUMENT.
//#define ICAP_BARCODESEARCHREGION           = 0x8121


//    // ICAP_COLORBALANCEAUTOMATICAGGRESSIVENESS
//    // Type:        TWTY_INT32
//    // Container:   Range (per color camera)
//    // Allowed:     -2 to 2
//    // Default:     0
//    // Notes:       Indicates how aggressive the automatic white balance will be.
//    //              This is only available when ICAP_COLORBALANCEMODE set to 
//    //              TWCBM_AUTOMATICADVANCED
//#define ICAP_COLORBALANCEAUTOMATICAGGRESSIVENESS  = 0x810A


//    // ICAP_COLORBALANCEMODE
//    // Type:        TWTY_UINT16
//    // Container:   Enumeration (per color camera)
//    // Allowed:     typically TWCBM_NONE, TWCBM_MANUAL, TWCBM_AUTOMATIC, 
//    //                      TWCBM_AUTOMATICBASIC 
//    // Default:     typically TWCBM_AUTOMATICBASIC, if not supported then TWCBM_NONE
//    // Notes:       Allows the user to select the method for adjusting the color 
//    //              balance of a color image.
//    //              TWCBM_NONE means no adjustment is made.
//    //              TWCBM_MANUAL means the user can adjust Red, Green and Blue  
//    //              (see ICAP_COLORBALANCEREAD/GREEN/BLUE).
//    //              TWCBM_AUTOMATICBASIC means the scanner will automatically  
//    //              adjust the balance to be white.
//    //              TWCBM_AUTOMATIC is the same as TWCBM_AUTOMATICBASIC but 
//    //              the user can also adjust the aggressiveness of the balance 
//    //              (see ICAP_COLORBALANCEAUTOMATICAGRESSIVENESS).
//#define ICAP_COLORBALANCEMODE              = 0x8109
//#define TWCBM_NONE             =          0
//#define TWCBM_MANUAL            =         1
//#define TWCBM_AUTOMATICBASIC       =      2
//#define TWCBM_AUTOMATIC           =       3


//    // ICAP_COLORBALANCEBLUE
//    // ICAP_COLORBALANCEGREEN
//    // ICAP_COLORBALANCERED
//    // Type:        TWTY_INT32
//    // Container:   Range (per camera)
//    // Allowed:     -50 to 50 step 1 for the GUI
//    //		        -1000 to 1000 step 20 for programmatic
//    // Default:     0
//    // Notes:       Allow the user to adjust the color balance. This is ignored 
//    //              if ICAP_COLORBALANCEMODE is not set to TWCBM_MANUAL.
//#define ICAP_COLORBALANCEBLUE              = 0x80B1
//#define ICAP_COLORBALANCEGREEN             = 0x80B2
//#define ICAP_COLORBALANCERED               = 0x80B3


//    // CAP_COLORBRIGHTNESSMODE
//    // Type:        TWTY_UINT16
//    // Container:   Enumeration (per color camera)
//    // Allowed:     typically TWCBR_NONE, TWCBR_MANUAL, TWCBR_AUTOMATIC
//    // Default:     typicaly TWCBR_AUTOMATIC, if not supported then TWCBR_NONE
//    // Notes:       Allows the user to select the method for adjusting the  
//    //              brightness and contrast of a color or grayscale image.
//    //              TWCBR_NONE means no adjustment is made.
//    //              TWCBR_MANUAL means the user can adjust Brightness and  
//    //              Contrast (see ICAP_BRIGHTNESS and ICAP_CONTRAST).
//    //              TWCBR_AUTOMATICBASIC means the scanner will  
//    //              automatically adjust the image.
//#define ICAP_COLORBRIGHTNESSMODE           = 0x8108
//#define TWCBR_NONE                 =      0
//#define TWCBR_MANUAL               =      1
//#define TWCBR_AUTOMATICBASIC       =      2


//    // ICAP_COLORSHARPEN
//    // Type:        TWTY_UINT32
//    // Container:   Range  (per output stream)
//    // Allowed:     0 - 3
//    // Default:     typically 1
//    // Notes:       Apply sharpening to image - 0 indicates no sharpening.
//    //				1 is normal, 2 is more sharpening, and  a value of 3
//    //				applies a lot of sharpening.
//#define ICAP_COLORSHARPEN		=			0x8102


//    // ICAP_COLORSHARPENING
//    // Type:        TWTY_INT16
//    // Container:   Enumeration (per camera)
//    // Allowed:     TWCS_NONE, TWCS_3X3FIRFILTER
//    // Default:     TWCS_3X3FIRFILTER
//    // Notes:       Color image sharpening.  This setting only has
//    //              meaning if ICAP_COMPRESSION is set to TWCP_JPEG.
//#define ICAP_COLORSHARPENING               = 0x8041
//#define TWCS_NONE               =          0
//#define TWCS_3X3FIRFILTER        =         1


//    // ICAP_COLORTABLE
//    // Type:        TWTY_UINT16
//    // Container:   Enumeration
//    // Allowed:     (see list below)
//    // Default:     (as discovered in scanner)
//    // Notes:       Selects the color table to use.  This capability
//    //              is like ICAP_HALFTONES in that there is no
//    //              programmatic way to guarantee the results of a
//    //              given selection.  The best tactic is to present
//    //              the data to the user 'as is' and let them select
//    //              what they want.
//#define ICAP_COLORTABLE                    = 0x8020
//#define TWCT_UNKNOWN  =                   -1
//#define TWCT_DEFAULT  =                   0
//#define TWCT_FILE01   =                   1
//#define TWCT_FILE02   =                   2
//#define TWCT_FILE03   =                   3
//#define TWCT_FILE04   =                   4
//#define TWCT_FILE05   =                   5
//#define TWCT_FILE06   =                   6
//#define TWCT_FILE07   =                   7
//#define TWCT_FILE08   =                   8
//#define TWCT_FILE09   =                   9
//#define TWCT_FILE10   =                   10
//#define TWCT_FILE11   =                   11
//#define TWCT_FILE12   =                   12
//#define TWCT_FILE13   =                   13
//#define TWCT_FILE14   =                   14
//#define TWCT_FILE15   =                   15
//#define TWCT_FILE16   =                   16
//#define TWCT_FILE17   =                   17
//#define TWCT_FILE18   =                   18
//#define TWCT_FILE19   =                   19
//#define TWCT_FILE20   =                   20
//#define TWCT_FILE21   =                   21
//#define TWCT_FILE22   =                   22
//#define TWCT_FILE23   =                   23
//#define TWCT_FILE24   =                   24
//#define TWCT_FILE25   =                   25
//#define TWCT_FILE26   =                   26
//#define TWCT_FILE27   =                   27
//#define TWCT_FILE28   =                   28
//#define TWCT_FILE29   =                   29
//#define TWCT_FILE30   =                   30
//#define TWCT_FILE31   =                   31
//#define TWCT_FILE32   =                   32
//#define TWCT_FILE33   =                   33
//#define TWCT_FILE34   =                   34
//#define TWCT_FILE35   =                   35
//#define TWCT_FILE36   =                   36
//#define TWCT_FILE37   =                   37
//#define TWCT_FILE38   =                   38
//#define TWCT_FILE39   =                   39
//#define TWCT_FILE40   =                   40
//#define TWCT_FILE41   =                   41
//#define TWCT_FILE42   =                   42
//#define TWCT_FILE43   =                   43
//#define TWCT_FILE44   =                   44
//#define TWCT_FILE45   =                   45
//#define TWCT_FILE46   =                   46
//#define TWCT_FILE47   =                   47
//#define TWCT_FILE48   =                   48
//#define TWCT_FILE49   =                   49
//#define TWCT_FILE50   =                   50
//#define TWCT_FILE51   =                   51
//#define TWCT_FILE52   =                   52
//#define TWCT_FILE53   =                   53
//#define TWCT_FILE54   =                   54
//#define TWCT_FILE55   =                   55
//#define TWCT_FILE56   =                   56
//#define TWCT_FILE57   =                   57
//#define TWCT_FILE58   =                   58
//#define TWCT_FILE59   =                   59
//#define TWCT_FILE60   =                   60

//    // ICAP_CROPPINGMODE
//    // Type:        TWTY_UINT16
//    // Container:   Enumeration (per camera)
//    // Allowed:     See below...
//    // Default:     TWCR_AUTOMATICBORDERDETECTION
//    // Notes:       Selects the mode of cropping.  This capability is
//    //              tied to ICAP_AUTOMATICBORDERDETECTION, where FALSE
//    //              equals TWCR_TRANSPORT and TRUE equals
//    //              TWCR_AUTOMATICBORDERDETECTION.
//    //              Continuous cropping mode is also known as Long Paper mode.    
//    //              If the user set one of the camera to TWCR_CONTIUOUS
//    //              all the camera force to set cropping to TWCR_CONTIUOUS
//    //              and if all camera in TWCR_CONTIUOUS cropping mode, the 
//    //              user change one of the camera to other cropping mode
//    //              then all the camera will force to set the same cropping mode
//#define ICAP_CROPPINGMODE                  = 0x8022
//#define TWCR_AUTOMATICBORDERDETECTION =   0
//#define TWCR_TRANSPORT                =   1
//#define TWCR_DOCUMENT                 =   2
//#define TWCR_AGGRESSIVEAUTOCROP       =   3
//#define TWCR_CONTINUOUS               =   4
//#define TWCR_MULTIPLEAGGRESSIVE       =   5
//#define TWCR_PHOTO                    =   6
//#define TWCR_PHOTOINROI               =   7


//    // ICAP_DOCUMENTTYPE
//    // Type:        TWTY_UINT16
//    // Container:   Enumeration (per camera)
//    // Allowed:     See below
//    // Default:     TWDT_TEXTWITHGRAPHIC
//    //		        Oasis: TWDT_PHOTO
//    // Notes:       Allows user to select the type of document being scanned.
//#define ICAP_DOCUMENTTYPE                  = 0x80AC
//#define TWDT_PHOTO                     =  0
//#define TWDT_TEXTWITHGRAPHICS          =  1
//#define TWDT_TEXTWITHPHOTO             =  2
//#define TWDT_TEXT                      =  3


//    // ICAP_ECDO
//    // Type:        TWTY_UINT16
//    // Container:   Enumeration
//    // Allowed:     (see list below)
//    // Default:     None
//    // Notes:       Allows user to select the ECDO color for bitonal/gray camera.
//    //              Also refer to DAT_ECDO later in this file.
//#define ICAP_ECDO		                   = 0x80B8
//#define TWCD_UNKNOWN  =                   -1
//#define TWCD_NONE	  =                  0
//#define TWCD_FILE01   =                   1
//#define TWCD_FILE02   =                   2
//#define TWCD_FILE03   =                   3
//#define TWCD_FILE04   =                   4
//#define TWCD_FILE05   =                   5
//#define TWCD_FILE06   =                   6
//#define TWCD_FILE07   =                   7
//#define TWCD_FILE08   =                   8
//#define TWCD_FILE09   =                   9
//#define TWCD_FILE10   =                   10
//#define TWCD_FILE11   =                   11
//#define TWCD_FILE12   =                   12
//#define TWCD_FILE13   =                   13
//#define TWCD_FILE14   =                   14
//#define TWCD_FILE15   =                   15
//#define TWCD_FILE16   =                   16
//#define TWCD_FILE17   =                   17
//#define TWCD_FILE18   =                   18
//#define TWCD_FILE19   =                   19
//#define TWCD_FILE20   =                   20
//#define TWCD_FILE21   =                   21
//#define TWCD_FILE22   =                   22
//#define TWCD_FILE23   =                   23
//#define TWCD_FILE24   =                   24
//#define TWCD_FILE25   =                   25
//#define TWCD_FILE26   =                   26
//#define TWCD_FILE27   =                   27
//#define TWCD_FILE28   =                   28
//#define TWCD_FILE29   =                   29
//#define TWCD_FILE30   =                   30
//#define TWCD_FILE31   =                   31
//#define TWCD_FILE32   =                   32
//#define TWCD_FILE33   =                   33
//#define TWCD_FILE34   =                   34
//#define TWCD_FILE35   =                   35
//#define TWCD_FILE36   =                   36
//#define TWCD_FILE37   =                   37
//#define TWCD_FILE38   =                   38
//#define TWCD_FILE39   =                   39
//#define TWCD_FILE40   =                   40
//#define TWCD_FILE41   =                   41
//#define TWCD_FILE42   =                   42
//#define TWCD_FILE43   =                   43
//#define TWCD_FILE44   =                   44
//#define TWCD_FILE45   =                   45
//#define TWCD_FILE46   =                   46
//#define TWCD_FILE47   =                   47
//#define TWCD_FILE48   =                   48
//#define TWCD_FILE49   =                   49
//#define TWCD_FILE50   =                   50
//#define TWCD_FILE51   =                   51
//#define TWCD_FILE52   =                   52
//#define TWCD_FILE53   =                   53
//#define TWCD_FILE54   =                   54
//#define TWCD_FILE55   =                   55
//#define TWCD_FILE56   =                   56
//#define TWCD_FILE57   =                   57
//#define TWCD_FILE58   =                   58
//#define TWCD_FILE59   =                   59
//#define TWCD_FILE60   =                   60


//    // ICAP_ECDOAGGRESSIVENESS
//    // Type:        TWTY_INT32
//    // Container:   Range (per output stream, bitonal only)
//    // Allowed:     -10 to 10
//    // Default:     0
//    // Notes:       Change the amount of multi-color dropout applied to
//    //				a bitonal image.
//#define ICAP_ECDOAGGRESSIVENESS				0x8103


//    // ICAP_ECDOINCLUDENONDROPPED
//    // Type:		TWTY_BOOL
//    // Container:	OneValue (per camera)
//    // Allowed:		TRUE / FALSE
//    // Default:		FALSE
//    // Notes:		Allows you to turn the inclusion of a non-dropout version of the image
//    //				On and Off. The default is Off.
//    //				This is not available unless ECDO is supported and is not set to (none).
//    //				This feature is not available for all models.
//#define ICAP_ECDOINCLUDENONDROPPED        = 0x812E


//    // ICAP_ECDOTREATASCOLOR
//    // Type:        TWTY_BOOL
//    // Container:   OneValue (per camera)
//    // Allowed:     TRUE / FALSE
//    // Default:     FALSE
//    // Notes:       Allows you to indicate that a color other than black or
//    //              dark blue ink was used for the data entered on the form.
//    //              This is not available when ECDO is set to (none).
//    //              This feature is not available for all models.
//#define ICAP_ECDOTREATASCOLOR             = 0x80C3


//    // ICAP_FILTERBACKGROUND
//    // Type:        TWTY_UINT16
//    // Container:   Range
//    // Allowed:     0 - 255
//    // Default:     245
//    // Notes:       Selects the grayscale color to replace the dropout
//    //              color when capturing bitonal images...
//#define ICAP_FILTERBACKGROUND              = 0x8026


//    // ICAP_FILTERENUM
//    // Type:        TWTY_UINT16
//    // Container:   Enumeration
//    // Allowed:     See ICAP_FILTER
//    // Default:     TWFT_NONE
//    // Notes:       Tied to ICAP_FILTER...
//    //              ICAP_FILTER is an array...and we need an enum (sigh)...
//#define ICAP_FILTERENUM                    = 0x8024


//    // ICAP_FILTERPROCESSING
//    // Type:        TWTY_UINT16
//    // Container:   Enumeration
//    // Allowed:     TWFP_NORMAL, TWFP_LOWRES
//    // Default:     TWFP_NORMAL
//    // Notes:       If color dropout at low resolutions results in
//    //              unwanted artifacts, try changing this capability
//    //              to TWFP_LOWRES.
//#define ICAP_FILTERPROCESSING              = 0x8088
//#define TWFP_NORMAL                         0
//#define TWFP_LOWRES                         1


//    // ICAP_FILTERTHRESHOLD
//    // Type:        TWTY_UINT16
//    // Container:   Range
//    // Allowed:     0 - 255
//    // Default:     175
//    // Notes:       Selects the threshold point of the color data when
//    //              capturing bitonal images...
//#define ICAP_FILTERTHRESHOLD               = 0x8025


//    // ICAP_FLIPBACKGROUNDCOLOR
//    // Type:        TWTY_BOOL
//    // Container:   OneValue (per camera)
//    // Allowed:     TRUE / FALSE
//    // Default:     FALSE
//    // Notes:       5000/7000 only.  This is Border Reduction.  A feature
//    //              that changes the borders on the left and the right to
//    //              white the opposite pixel flavor 'color'.  A value of
//    //              TRUE does the change, a value of FALSE leaves it as is...
//#define ICAP_FLIPBACKGROUNDCOLOR           = 0x8043


//    // ICAP_FORCECOMPRESSION
//    // Type:        TWTY_UINT16
//    // Container:   Enumeration (per camera)
//    // Allowed:     same rules as ICAP_COMPRESSION
//    // Default:     TWCP_NONE
//    // Notes:       A throughput efficiency mechanism.  If an application
//    //              requires uncompressed data, but the size of the image
//    //              is more than SCSI can manage, then use this capability
//    //              to force the scanner to compress the data, and the
//    //              Source to decompress in software before transferring
//    //              it to the application.  Note that with the Prism
//    //              this value is always TWCP_JPEG for the color cameras.
//#define ICAP_FORCECOMPRESSION              = 0x8008


//    // ICAP_FOREGROUNDBOLDNESSAGGRESSIVENESS
//    // Type:        TWTY_INT32
//    // Container:   Range (per color camera)
//    // Allowed:     -10 to 10
//    // Default:     0
//    // Notes:       The foreground boldness aggressiveness setting.
//    //              This setting only has meaning if
//    //              ICAP_FOREGROUNDBOLDNESSMODE is TWFB_AUTOMATIC.
//#define ICAP_FOREGROUNDBOLDNESSAGGRESSIVENESS   = 0x810E


//    // ICAP_FOREGROUNDBOLDNESSMODE
//    // Type:        TWTY_UINT16
//    // Container:   Enumeration (per color camera)
//    // Allowed:     TWFB_NONE, TWFB_AUTOMATICBASIC, TWFB_AUTOMATIC
//    // Default:     TWFB_NONE
//    // Notes:       The foreground boldness mode
//#define ICAP_FOREGROUNDBOLDNESSMODE        = 0x810F
//#define TWFB_NONE              =           0
//#define TWFB_AUTOMATICBASIC    =           1
//#define TWFB_AUTOMATIC         =           2


//    // ICAP_FRAMELENGTHCONTROL
//    // Type:        TWTY_BOOL
//    // Container:   OneValue
//    // Allowed:     TRUE / FALSE
//    // Default:     TRUE
//    // Notes:       5000/7000 only.  Controls the way the scanner detects
//    //              the end of the document.  A value of TRUE reflects the
//    //              way all other scanners work.  A value of FALSE should
//    //              be used for documents with ragged bottom edges...
//#define ICAP_FRAMELENGTHCONTROL            = 0x8042


//    // ICAP_FRAMESANGLE
//    // Type:        TWTY_FRAMEANGLE
//    // Container:   Enumeration
//    // Allowed:     0,0 - ICAP_PHYSICALWIDTH,ICAP_PHYSICALHEIGHT
//    // Default:     value of ICAP_SUPPORTEDSIZE
//    // Notes:       With the support of angles it becomes necessary to
//    //              provide a way to specify the coordinates and the
//    //              angle simultaneously, otherwise it's impossible to
//    //              provide proper validation.  So if you are working
//    //              with non-zero angles, then use this capability
//    //              instead of ICAP_FRAMES or DAT_IMAGELAYOUT.
//#define ICAP_FRAMESANGLE                   = 0x80BB


//    // ICAP_GAMMAENABLED
//    // Type:        TWTY_BOOL
//    // Container:   OneValue
//    // Allowed:     TRUE / FALSE
//    // Default:     TRUE
//    // Notes:       A value of TRUE causes the scanner to apply
//    //              its gamma table to the image.  This only has
//    //              meaning for grayscale output.
//#define ICAP_GAMMAENABLED                  = 0x8074


//    // ICAP_GRAYSCALE
//    // Type:        TWTY_BOOL
//    // Container:   OneValue
//    // Allowed:     TRUE / FALSE
//    // Default:     FALSE
//    // Notes:       If set to TRUE then the color output will be
//    //              converted to grayscale.  You can also get to
//    //              this mode by setting ICAP_PIXELTYPE to
//    //              TWPT_GRAY, though if you do it that way you
//    //              will get grayscale output for both the front
//    //              and the rear images...
//#define ICAP_GRAYSCALE                     = 0x802E


//    // ICAP_HALFTONESQUALITY (3590/4500)
//    // Type:        TWTY_UINT16
//    // Container:   Enumeration
//    // Allowed:     TWHQ_SOFTWAREFAST and TWHQ_SOFTWAREBEST or
//    //              TWHQ_HARDWAREBEST
//    // Default:     TWHQ_SOFTWAREFAST or TWHQ_HARDWAREBEST
//    // Notes:       Selects the quality/performance of the 
//    //              ChromaTHR(tm) software quality settings for
//    //              making bitonal images from color data.  If
//    //              a hardware card is present, than it is the
//    //              only option available; otherwise the two
//    //              software options are made available...
//#define ICAP_HALFTONESQUALITY              = 0x801F
//#define TWHQ_NONE                        0
//#define TWHQ_SOFTWAREFAST                1
//#define TWHQ_SOFTWAREBEST                2
//#define TWHQ_HARDWAREBEST                3


//    // ICAP_HOLEFILLENABLED
//    // Type:        TWTY_BOOL
//    // Container:   OneValue (per output stream)
//    // Allowed:     TRUE / FALSE
//    // Default:     FALSE
//    // Notes:       Hole Fill enabled/disabled.
//#define ICAP_HOLEFILLENABLED           	   = 0x8104


//    // ICAP_IMAGEEDGEFILL
//    // Type:        TWTY_UINT16
//    // Container:   Enumeration (per camera)
//    // Allowed:     (see list below)
//    // Default:     TWIE_AUTOMATIC if the scanner is supported. 
//    //              Otherwise TWIE_NONE is the default
//    // Notes:       Fills in each edge of the image with the selected color. 
//    //              The TWIE_AUTOMATIC and TWIE_AUTOMATICWITHTEAR are not available
//    //              for all scanners.
//#define ICAP_IMAGEEDGEFILL                 = 0x8095
//#define TWIE_NONE        =              0
//#define TWIE_WHITE       =              1
//#define TWIE_BLACK       =              2
//#define TWIE_AUTOMATIC    =             3
//#define TWIE_AUTOMATICWITHTEAR=         4


//    // ICAP_IMAGEEDGEFILLALLSIDES
//    // Type:        TWTY_BOOL
//    // Container:   OneValue
//    // Allowed:     TRUE / FALSE
//    // Default:     TRUE
//    // Notes:       Indicates if all of the sides for image edge fill are the same
//    //              value, based on ICAP_IMAGEEDGETOP
//#define ICAP_IMAGEEDGEFILLALLSIDES         = 0x80B9
//#define ICAP_IMAGEEDGEFILLALLSIZE          = 0x80B9	// Deprecated TWAIN 10.x+	


//    // ICAP_IMAGEEDGE*
//    // Type:        TWTY_FIX32
//    // Container:   Range (per camera)
//    // Allowed:     0 to ICAP_PHYSICALWIDTH for left and right
//    //              0 to ICAP_PHYSICALHEIGHT for the the top and bottom
//    // Default:     0
//    // Notes:       Amount of fill for the left/right/top/bottom edge of the image
//#define ICAP_IMAGEEDGELEFT                 = 0x8096
//#define ICAP_IMAGEEDGERIGHT                = 0x8097
//#define ICAP_IMAGEEDGETOP                  = 0x8098
//#define ICAP_IMAGEEDGEBOTTOM               = 0x8099


//    // ICAP_IMAGEFILEFORMAT
//    // Type:        TWTY_UINT16
//    // Container:   Enumeration
//    // Allowed:     TWFF_BMP, TWFF_JFIF, TWFF_TIFF, TWFF_RAW...
//    // Default:     TWFF_BMP
//    // Notes:       This is a standard TWAIN capability, we're just
//    //              adding a custom argument to it
//#define TWFF_RAW                           = 0x8001
//#define TWFF_RAWBMP                        = 0x8002


//    // CAP_IMAGEMAGNIFICATIONFACTOR
//    // Type:        TWTY_UINT16
//    // Container:   Range
//    // Allowed:     0 - 255
//    // Default:     0
//    // Notes:       Helps the scanner determine the 'real' size of images
//    //              coming from the P-Card.  This information is used to
//    //              optimize buffer thresholding.
//    //              This capability is not available at this time.
//#define CAP_IMAGEMAGNIFICATIONFACTOR       = 0x806B


//    // ICAP_IMAGEROTATEORTHOGONALCHARSET
//    // Type:        TWTY_UINT16
//    // Container:   Array
//    // Allowed:     (see list below)
//    // Default:     Typically, all but Arabic
//    // Notes:       The list of character sets to consider for auto orientation analysis.
//#define ICAP_IMAGEROTATEORTHOGONALCHARSET   = 0x814D
//#define TWIROCS_NONE           =         0
//#define TWIROCS_LATIN           =        1
//#define TWIROCS_NUMBERS          =       2
//#define TWIROCS_CHINESE_JAPANESE  =      3
//#define TWIROCS_KOREAN             =     4
//#define TWIROCS_ARABIC              =    5


//    // CAP_INDEXINGDOCUMENT
//    // Type:        TWTY_UINT32
//    // Container:   OneValue
//    // Allowed:     0 - 999999999
//    // Default:     1
//    // Notes:       The ‘Document’ value used for Indexing formats (valid when CAP_INDEXINGFORMAT
//    //              is TWINDFMT_SINGLEPAGE, TWINDFMT_MULTIPLEPAGE, or TWINDFMT_BATESSTAMP). 
//    //              This value shall not be saved in the profile.
//    //              The value shall be retained between scan sessions (i.e. while the driver
//    //              remains loaded by the application), so that the next scan session will
//    //              continue from where the previous scan left off, unless the application
//    //              sets this value.
//    //              When set, CAP_INDEXINGSHEET is automatically set to 0.
//    //              This feature is not available for all models.
//#define CAP_INDEXINGDOCUMENT               = 0x8135


//    // CAP_INDEXINGFORMAT
//    // Type:        TWTY_UINT16
//    // Container:   Enumeration
//    // Allowed:     Scanner Model Specific
//    // Default:     TWINDFMT_NONE
//    // Notes:       Selects the Indexing Format, this determines the image addressing
//    //              settings that are available for negotiation.
//#define CAP_INDEXINGFORMAT                 = 0x811C
//#define TWINDFMT_NONE           =         0
//#define TWINDFMT_SINGLEPAGE      =        1
//#define TWINDFMT_MULTIPLEPAGE     =       2
//#define TWINDFMT_BATESSTAMP        =      3
//#define TWINDFMT_IMAGEADDRESS       =     4


//    // CAP_INDEXINGPRINTONPATCH
//    // Type:        TWTY_BOOL
//    // Container:   OneValue
//    // Allowed:     TRUE / FALSE
//    // Default:     FALSE
//    // Notes:       Indicates whether printing occurs on patch sheets or not.
//    //              NOTE: what is actually printed is determined by the printer settings.
//    //              Only valid if CAP_INDEXINGFORMAT is TWINDFMT_MULTIPLEPAGE or 
//    //              TWINDFMT_BATESSTAMP.
//    //              This value shall be saved in the profile.
//    //              This feature is not available for all models.
//#define CAP_INDEXINGPRINTONPATCH           = 0x8137


//    // CAP_INDEXINGSHEET
//    // Type:        TWTY_UINT32
//    // Container:   OneValue
//    // Allowed:     0 - 999999999
//    // Default:     0
//    // Notes:       The ‘Sheet’ value used for Indexing formats (valid when CAP_INDEXINGFORMAT is 
//    //              TWINDFMT_MULTIPLEPAGE or TWINDFMT_BATESSTAMP).
//    //              NOTE: while not visible to the user for Bates Stamp, this is used by the
//    //              scanner (i.e. 0 means ‘new job’, and any other value means it is a
//    //              continuation of the previous job).
//    //              This value shall not be saved in the profile.
//    //              The value shall be retained between scan sessions (i.e. while the driver
//    //              remains loaded by the application), so that the next scan session will
//    //              continue from where the previous scan left off, unless the application
//    //              sets this value.
//    //              This feature is not available for all models.
//#define CAP_INDEXINGSHEET                  = 0x8136


//    // ICAP_LAMPSAVER
//    // Type:        TWTY_BOOL
//    // Container:   OneValue
//    // Allowed:     TRUE / FALSE
//    // Default:     TRUE
//    // Notes:       If TRUE the scanner's lamps will automatically turn off
//    //              after ten minutes of non-use; saving power and extending
//    //              the life of the lamps.
//#define ICAP_LAMPSAVER                     = 0x8005


//    // ICAP_LAMPTIMEOUT
//    // Type:        TWTY_UINT16
//    // Container:   Range
//    // Allowed:     typically 0,10 or 0-30 (minutes)
//    // Default:     10 or 20
//    // Notes:       Controls the lamp saver option.  Please note that this
//    //              capability should be used instead of ICAP_LAMPSAVER.
//#define ICAP_LAMPTIMEOUT                   = 0x802A


//    // ICAP_MEDIATYPE
//    // Type:        TWTY_UINT16
//    // Container:   Enumeration (per camera)
//    // Allowed:     See below
//    // Default:     TWMT_PLAINPAPER
//    // Notes:       Allows user to select type of media being scanned.
//    //              The front and rear camera setting must be the same.
//#define ICAP_MEDIATYPE                     = 0x80B6
//#define TWMT_CARDSTOCK      =            0
//#define TWMT_GLOSSYPAPER     =           1
//#define TWMT_MAGAZINE         =          2
//#define TWMT_PLAINPAPER        =         3
//#define TWMT_THINPAPER          =        4


//    // ICAP_NOISEFILTER
//    // Type:        TWTY_UINT16
//    // Container:   Enumeration
//    // Allowed:     TWNF_NONE, TWNF_LONEPIXEL, TWNF_MAJORITYRULE,
//    //              TWNF_BACKGROUND
//    // Default:     typically TWNF_LONEPIXEL
//    // Notes:       This list adds custom values to this standard TWAIN
//    //              capability.  
//    //              Capability is only available for /Camera_Bitonal_Both, 
//    //              /Camera_Bitonal_Top and /Camera_Bitonal_Bottom
//    //              (ICAP_PIXELTYPE == TWPT_BW).
//    //              Not all options are available for all models.
//#define TWNF_BACKGROUND                    = 0x8001


//    // ICAP_ORTHOGONALROTATE
//    // Type:        TWTY_UINT16
//    // Container:   Enumeration (per camera)
//    // Allowed:     (see below)
//    // Default:     TWOROT_NONE
//    // Notes:       Orthogonal rotation
//#define ICAP_ORTHOGONALROTATE              = 0x80D5
//#define TWOROT_NONE        =              0
//#define TWOROT_AUTOMATIC    =             1
//#define TWOROT_90            =            2
//#define TWOROT_180            =           3
//#define TWOROT_270             =          4
//#define TWOROT_AUTOMATIC_90     =         5
//#define TWOROT_AUTOMATIC_180     =        6
//#define TWOROT_AUTOMATIC_270      =       7


//    // ICAP_OVERSCANX
//    // Type:        TWTY_FIX32
//    // Container:   Range (per camera)
//    // Allowed:     typically 0-0.375"
//    // Default:     typically 0.375"
//    // Notes:       Amount of overscan (in ICAP_UNITS) on the left and
//    //              right sides of the cropping region.
//#define ICAP_OVERSCANX                     = 0x8006


//    // ICAP_OVERSCANY
//    // Type:        TWTY_FIX32
//    // Container:   Range (per camera)
//    // Allowed:     typically 0-0.375"
//    // Default:     typically 0.375"
//    // Notes:       Amount of overscan (in ICAP_UNITS) on the top and
//    //              bottom sides of the cropping region.
//#define ICAP_OVERSCANY                     = 0x8007


//    // ICAP_PADDING
//    // Type:        TWTY_UINT16
//    // Container:   Enumeration
//    // Allowed:     (see list below)
//    // Default:     TWPG_AUTO
//    // Notes:       Selects the padding to force the bytes-per-row
//    //              (or the stride) to always land on a specific
//    //              boundry...
//#define ICAP_PADDING                       = 0x80AA
//#define TWPG_AUTO             =            0
//#define TWPG_NONE              =           1
//#define TWPG_BYTE               =          2
//#define TWPG_WORD                =         3
//#define TWPG_LONGWORD             =        4
//#define TWPG_OCTAWORD              =       5


//    // CAP_PATCHTYPE*
//    // Type:        TWTY_UINT16
//    // Container:   Enumeration
//    // Allowed:     Scanner specific
//    // Default:     TWSP_NONE
//    // Notes:       Allows the user to select what action to take when a scanner patch is detected.
//    //	            This feature is not available for all models.
//    //	            Not all values are supported on all scanners.
//#define CAP_PATCHTYPE10                    = 0x812F
//#define CAP_PATCHTYPE11                    = 0x8130
//#define CAP_PATCHTYPE12                    = 0x8131
//#define CAP_PATCHTYPE13                    = 0x8132
//#define CAP_PATCHTYPE14                    = 0x8133
//#define CAP_PATCHTYPE15                    = 0x8134
//#define TWSP_NONE                  =      0
//#define TWSP_MULTIFEEDOFFONESHEET   =     1
//#define TWSP_MULTIFEEDOFFBETWEEN     =    2
//#define TWSP_ENDJOB                   =   3


//    // ICAP_PHYSICALHEIGHTADJUST
//    // Type:        TWTY_FIX32
//    // Container:   Range
//    // Allowed:     Scanner specific
//    // Default:     Scanner specific
//    // Notes:       Adjusts the value of ICAP_PHYSICALHEIGHT.  Applications must
//    //              set this value to have access to the full scan length of the
//    //              ADF.
//#define ICAP_PHYSICALHEIGHTADJUST          = 0x8101


//    // ICAP_SKEWANGLE
//    // Type:        TWTY_UINT16
//    // Container:   Range
//    // Allowed:     -360000 - 360000
//    // Default:     0
//    // Notes:       Selects the deskew angle for fixed cropping.
//#define ICAP_SKEWANGLE                     = 0x80B5


//    // ICAP_STREAKREMOVALAGGRESSIVENESS
//    // Type:        TWTY_INT32
//    // Container:   Range
//    // Allowed:     -2 to 2
//    // Default:     0
//    // Notes:       Streak removal aggressiveness level. -2 is least aggressive
//    //              while 2 is most aggressive. The aggressiveness level is
//    //              meaningless if streak removal ‘enabled’ is FALSE.
//#define ICAP_STREAKREMOVALAGGRESSIVENESS    = 0x80C7


//    // ICAP_STREAKREMOVALENABLED
//    // Type:        TWTY_BOOL
//    // Container:   OneValue (per output stream)
//    // Allowed:     TRUE / FALSE
//    // Default:     Scanner specific
//    // Notes:       Streak Removal enabled/disabled. If TRUE, then the
//    //              streak removal ‘aggressiveness level’ has meaning.
//#define ICAP_STREAKREMOVALENABLED          = 0x80C6


//    // ICAP_TEXTENHANCEMENT
//    // Type:        TWTY_BOOL
//    // Container:   OneValue (per camera)
//    // Allowed:     TRUE / FALSE
//    // Default:     FALSE
//    // Notes:       Allows the user to turn Text Enhancement On and Off. 
//    //              Only supported for bitonal cameras.
//#define ICAP_TEXTENHANCEMENT               = 0x8122


//    // ICAP_THINTHICKENAMOUNT
//    // Type:        TWTY_INT32
//    // Container:   Range (per camera)
//    // Allowed:     -4 to 4
//    // Default:     0
//    // Notes:       Allows the user to adjust the amount of thinning or thickening.
//    //              Negative values will give the effect of lines getting thinner,
//    //              and positive values will give the effect of lines getting thicker.
//    //              Only supported for bitonal cameras.
//#define ICAP_THINTHICKENAMOUNT             = 0x8123


//    // ICAP_VERTICALBLACKLINEREMOVAL (not implemented, ignore this for now)
//    // Type:        TWTY_BOOL
//    // Container:   OneValue (per camera)
//    // Allowed:     TRUE/FALSE
//    // Default:     TRUE
//    // Notes:       Controls vertical black line removal (VBLR).
//    //              Only supported for bitonal with ATP...
//#define ICAP_VERTICALBLACKLINEREMOVAL      = 0x8021



//    ////////////////////////////////////////////////////////////////////////////////
//    //                      DAT Section
//    ////////////////////////////////////////////////////////////////////////////////


//    //  auto color learning
//    //  (DG_CONTROL)...
//    //  Notes:  This utility will determine the proper ‘Color Amount’ value
//    //          to use with the current ‘Color Threshold’ value, in order to
//    //          save a representative stack of color documents as either color
//    //          or grayscale images...
//#define DAT_AUTOCOLORLEARN                 = 0x8006


//    //  Color Table Map (DG_CONTROL)...
//    //  Notes:  This data structure allows an application to
//    //          map the ICAP_COLORTABLE numeric values to
//    //          both the English and current language strings.
//    //          The call allocates the data structure.  The
//    //          application parses the items (a value of
//    //         = 0xFFFF for ColorTableValue indicates the end
//    //          of the array).
//#define DAT_COLORTABLEMAP                  = 0x8003
//    typedef struct
//    {
//        TW_UINT16 ColorTableValue;
//        TW_STR255 szEnglish;
//        TW_STR255 szCurrent;
//    }
//    TW_COLORTABLEMAP, *pTW_COLORTABLEMAP;


////  Consumable Meters (for scanners that support at least one such meter)
////
////  Notes:  Use this structure to explore and manage consumable meters.
////
////          This data structure lets an application get, set and reset the
////          consumable meter settings for the scanner.
////
////          To get the list of consumable meters along with their supported
////          and current values (for when an application wants to present the
////          list on its own user interface):
////          -----------------------------------------------------------------
////          1. Application calls DG_CONTROL / DAT_CONSUMABLEMETERS / MSG_GET
////             to get the array of meters with their values.  Pass in a
////             pointer to a handle (if the variable is TW_HANDLE h, then the
////             value passed in is &h)
////          2. Driver returns the array of meters, or TWRC_FAILURE /
////             TWCC_BADPROTOCOL if there are no consumable meters for this
////             scanner model
////          3. Application locks the handle to get a pointer to the
////             TW_CONSUMABLEMETERS structure
////          3. Application loops through the pTW_CONSUMABLEMETERS->ConsumableMeterInfo[]
////             array pTW_CONSUMABLEMETERS->Total number of times, only
////             looking at fields that have their TWCONMTER_FIELD_* bit set
////             in pTW_CONSUMABLEMETERS->ConsumableMeterInfo[].FieldFlags
////          4. Application unlocks and frees the handle
////
////          To set a consumable meter (for when an application needs to
////          restores prior settings):
////          -----------------------------------------------------------------
////          1. It's recommended that an application do a MSG_GET first to
////             know which meters and which fields are valid for the scanner
////          2. Application creates a TW_CONSUMABLEMETERS structure either on
////             the stack or the heap, a handle is not used with this call,
////             the memory for the structure should be set to zeros
////          3. Application sets TW_CONSUMABLEMETERS.Total to 1
////          4. Application memcpy's the meter settings of the desired meter
////             in the MSG_GET data, this guarantees that all of the data
////             is available if more is added in a later revision, it also
////             sets TW_CONSUMABLEMETERS.ConsumableMeterInfo[0].MeterType
////             to the correct TWCONMTR_* value
////          5. Application sets TW_CONSUMABLEMETERS.ConsumableMeterInfo[0].FieldFlags
////             to the TWCONMTR_FIELD_* bits it wants to set
////          6. Application sets the TW_CONSUMABLEMETERS.ConsumableMeterInfo[0]
////             fields indicated by the selected FieldFlags to the desired values
////          7. Application uses DG_CONTROL / DAT_CONSUMABLEMETERS / MSG_SET
////             to send the new meter settings to the scanner.
////
////          To reset a consumable meter (for when the user has cleaned or
////          replaced a component):    
////          -----------------------------------------------------------------
////          1. It's recommended that an application do a MSG_GET first to
////             know which meters and which fields are valid for the scanner
////          2. Application creates a TW_CONSUMABLEMETERS structure either on
////             the stack or the heap, a handle is not used with this call,
////             the memory for the structure should be set to zeros
////          3. Application sets TW_CONSUMABLEMETERS.Total to 1
////          4. Application sets TW_CONSUMABLEMETERS.ConsumableMeterInfo[0].MeterType
////             to the TWCONMTR_* value it wants to set, all over fields are ignored
////          5. Application uses DG_CONTROL / DAT_CONSUMABLEMETERS / MSG_RESET
////             to send the new meter settings to the scanner.

//#define DAT_CONSUMABLEMETERS                       = 0x8010
//#define 	TWCONMTR_NONE                  =         0
//#define 	TWCONMTR_CLEANING             =          1
//#define 	TWCONMTR_FEEDMODULE              =       2
//#define 	TWCONMTR_FEEDMODULETIRES           =     3
//#define 	TWCONMTR_SEPARATIONMODULE        =       4
//#define 	TWCONMTR_SEPARATIONMODULETIRES      =    5
//#define 	TWCONMTR_SEPARATIONPAD             =     6

//#define 	TWCONMTR_FIELD_FREQUENCY               = 0x0001 // Frequency is filled in
//#define 	TWCONMTR_FIELD_LASTRESET               = 0x0002 // LastReset is filled in
//#define 	TWCONMTR_FIELD_REMINDER                = 0x0004 // Reminder is filled in

//typedef struct
//{
//        TW_UINT16 MeterType;     // TWCONMTR_* value identifying the meter type.
//        TW_UINT32 FieldFlags;    // Bit mask of TWCONMTR_FIELD_* values, if a bit is present it means
//                                 // that the associated field contains valid data for a MSG_GET or a
//                                 // MSG_SET operation
//        TW_UINT32 Frequency;     // How often (in pages) maintenance should be performed.
//        TW_UINT32 LastReset;     // The value of the page count meter when maintenance was last performed.
//        TW_UINT32 Reminder;      // How many pages prior to maintenance being required that the user
//                                 // should be reminded.  This interval also drives how often the user
//                                 // is reminded after the maintenance deadline is passed.
//        TW_UINT8 Reserved[512]; // Reserved
//    }
//    TW_CONSUMABLEMETERINFO, *pTW_CONSUMABLEMETERINFO;

//typedef struct
//{
//        TW_UINT32 Total;                  // Number of TW_CONSUMABLEMETERINFO structures.
//        TW_CONSUMABLEMETERINFO ConsumableMeterInfo[1]; // First item of an array of Total
//                                                       // TW_CONSUMABLEMETERINFO structures.
//    }
//    TW_CONSUMABLEMETERS, *pTW_CONSUMABLEMETERS;


////  Device Information
////  Notes:  This data structure provides additional
////          information about the device that may be
////          useful with some system message, such
////          as WM_DEVICECHANGE.  The dwFields value
////          indicates how many fields are supported
////          by the driver (the value doesn't include
////          the dwFields, itself)...
////
////          dwModelNumber  - ex: 200, 990, 3520...
////          szModelName    - ex: i200, 990...
////          szProtocol     - ex: ASPI, SCSISCAN...
////          dwFirmware     - ex: 10427 (1.4.27)
////
////          Only if szProtocol is SCSISCAN
////          szDeviceName   - \\.\Scanner# style
////          szDeviceChange - \\?\SBP2... style
////
////          Only if szProtocol is ASPI
////          dwHostAdapter
////          dwTarget
////
////          We're putting additional inquiry data here,
////          rather than creating "supported" capability
////          arrays.  This reduces the roundtrips needed
////          to collect information.
////
////          Note that zero (0) always has to be the
////          default for any new fields!
////
//#define DAT_DEVICEINFO                     = 0x8005
//// Sorter Flags...
//#define TW_DEVICEINFO_SORTERFLAG_NONE      = 0x0000
//#define TW_DEVICEINFO_SORTERFLAG_BARCODE   = 0x0001
//#define TW_DEVICEINFO_SORTERFLAG_MULTIFEED = 0x0002
//#define TW_DEVICEINFO_SORTERFLAG_PATCHCODE = 0x0004
//#define TW_DEVICEINFO_SORTERFLAG_SIZE      = 0x0008
//// The structure, and the maximum supported fields...
//#define TWCNST_DEVICEINFOFIELDS             10
//typedef struct
//{
//        TW_UINT32 dwFields;
//        TW_UINT32 dwModelNumber;             // field 01
//        TW_STR255 szModelName;               // field 02
//        TW_STR255 szProtocol;                // field 03
//        TW_STR255 szDeviceName;              // field 04
//        TW_UINT32 dwHostAdapter;             // field 05
//        TW_UINT32 dwTarget;                  // field 06
//                                             // put new fields here...
//        TW_STR255 szDeviceChange;            // field 07  + 256 =  256
//        TW_UINT32 dwFirmware;                // field 08  +  32 =  288
//        TW_STR255 szDriverFilename;         // field 09  + 256 =  544
//                                            // added Jun 14th, 2016
//        TW_UINT32 dwSorterFlags;                // field 10  +   4 =  548
//                                                // always reduce this whenever adding new fields!!!
//        TW_UINT8 reserved[65536 - 548];
//    }
//    TW_DEVICEINFO, *pTW_DEVICEINFO;


////  Driver Electronic Color Dropout (for drivers that support ICAP_ECDO)
////
////  Notes:  Use this structure to explore and manage dropout colors.
////
////          This data structure allows an application to map the ICAP_ECDO
////          numeric values to both the English and current language strings.
////          ICAP_ECDO is used to select a dropout color for the current camera.
////
////          The driver will allocate the returned data structure.
////
////          To get the list of dropout choices (for when an application wants
////          to present the list on its own user interface):
////          -----------------------------------------------------------------
////          1. Application calls DG_CONTROL / DAT_ECDO / MSG_GET to get
////             the list of all the choices.
////          2. Driver returns the list of choices (i.e. fills in the
////             TW_ECDO structure for each choice).
////          3. Application loops through the returned list until both szEnglish
////             and szCurrent are blank (which indicates the end of the list).
////
////          To find a dropout choice (for when an application needs to find
////          the TWCD_* for use with ICAP_ECDO):
////          -----------------------------------------------------------------
////          1. Application calls DG_CONTROL / DAT_ECDO / MSG_GET to get
////             the list of all the choices.
////          2. Driver returns the list of choices (i.e. fills in the
////             TW_ECDO structure for each choice).
////          3. Application loops through the returned list until it finds the
////             desired English dropout name (use szEnglish because this will
////             always be consistent no matter what the language of the driver
////             is; where szCurrrent will be based on the driver's current
////             language, which may be different then the last time the list
////             was returned).
////          4. Application uses the EcdoValue of the desired dropout choice
////             as the setting for ICAP_ECDO. This means the EcdoValue
////             will be one of the TWCD_* defines (e.g. TWCD_FILE01).
////
//#define DAT_ECDO                          = 0x800A
//typedef struct
//{
//        TW_UINT16 EcdoValue;
//        TW_STR255 szEcdo;
//        TW_STR255 szText;
//        TW_UINT8 Reserved[1024];            // Room for more stuff
//    }
//    TW_ECDO, *pTW_ECDO;


//// Driver Logs (DG_CONTROL / DAT_LOG / MSG_GET)
////
//// This will get a log and save it in the provided file. There are text based logs and XML based
//// logs. Some logs are scanner specific, so the content will not be common among all scanner
//// families, and some are common so the content can be common among all scanners.
////
//// Text based logs are ones that can be easily viewed in something like Notepad, each log entry
//// will be on its own line. These logs contain the same information as is shown on the driver UI
//// on the Log tab. The language for the translated text will be based on the current language
//// selected for the driver.
////
//// The XML based logs will contain data in a XML format. For details on the XML format for
//// a log, refer to the TWAIN_Features.htm in the Intergrator’s Guide.
////
//// For devices that support the Flatbed as an accessory (e.g. i1300, i1400), the application
//// will need to make a second call to get the flatbed’s information (see DeviceType below). This
//// is necessary because the flatbed is a separate device.
////
//// To generate an EKLOG specify a LogType of TWGL_EKLOG.  The DeviceType is ignored.  The
//// Filename specifies the full path and file for the log, and must end in .eklog.zip if
//// CAP_KAEKLOGUSESZIP exists and reports TRUE.  Otherwise use .eklog.
////
//// The Description is stored with the EKLOG.  Use SaveImages to specify if .tif and .jpg
//// files should be included (including them may result in a very large EKLOG file).
////
//#define DAT_LOG						0x800C
//typedef struct {
//        TW_UINT16 LogType;          // log to get (see TWGL_*)
//        TW_UINT16 DeviceType;           // ADF or Flatbed (see TWDV_*)
//        TW_STR255 Filename;         // full path and name to store log into
//        TW_STR255 Description;      // Reason for log (use with TWLG_EKLOG)
//        TW_BOOL SaveImages;         // Save images (use with TWLG_EKLOG)
//        TW_UINT8 Reserved[254];     // Room for future expansion
//    }
//    TW_LOG, *pTW_LOG;

//// different logs that can be retrieved via DAT_LOG. The comment indicate whether the
//// log is text based or XML base, and whether it is common among all scanner families or not.
//#define    TWGL_GENERAL				=	0	// text, not common
//#define    TWGL_OPERATOR			=	1	// text, not common
//#define    TWGL_GENERAL_XML			=	2	// XML, common
//#define    TWGL_EKLOG				=	3	// EKLOG (TWDV_* value is ignored)
//#define    TWGL_CUSTOM1				=	4	// for internal Alaris use only


//// different devices, which can be used by multiple CAPs/ICAPs/DATs
//#define    TWDV_UNKNOWN				=	0	// unknown/reserved
//#define    TWDV_ADF					=	1	// base scanner
//#define    TWDV_FLATBED			=		2	// flatbed scanner


//// OCP buttons (DG_CONTROL / DAT_OCPBUTTONS / MSG_SET)
//// OCP buttons (DG_CONTROL / DAT_OCPBUTTONS / MSG_GET)
////
//// Max number of buttons - typically 9 or 20
////
//// This feature allows the application to configure what is shown on the
//// scanner's Operator Control Panel (OCP).
////
//// Since not all items can be configured on all scanners, the application
//// can use MSG_GET to determine which items can be configured. The
//// NumDataFields field is a bit mask (see TWOCPS_*) that represents the
//// configurable items that vary from scanner to scanner.
//// The configurable items are:
////    Description                 MSG_GET's NumDataFields bit
////    -------------------------   ----------------------------
////    1. Number of Choices        n/a (all scanners that support
////                                     this DAT can do this)
////    2. Text to Display          n/a (all scanners that support
////                                     this DAT can do this)
////    3. Paper Source indicator   has TWOCPS_PAPERSOURCE bit set
////    4. User Supplied Graphic    has TWOCPS_GRAPHIC bit set
////
//// NOTE: For older Falcon and Piranha2 drivers, MSG_GET is not supported.
////       For older Falcon drivers, the configurable items are:
////          'Number of Choices', 'Text to Display' and 'Paper Source'.
////       For older Piranha2 drivers, the configurable items are:
////          'Number of Choices' and 'Text to Display'
////
////
//// Number of Choices
//// -----------------
//// The number of choices the user can scroll through depends on how many
//// TW_OCPBUTTONS structures are included in the MSG_SET. The application
//// sends an array of TW_OCPBUTTONS structures, one for each choice, plus
//// an extra one that has Text field blank. For example, if the application
//// wants to configure the OCP for 3 choices then it would define an array
//// with 4 TW_OCPBUTTONS structures. It would configure items in the first
//// 3 structures and then set the Text field in the 4th structure to blank.
////
//// The order the choices are displayed on the OCP is the same order of the
//// TW_OCPBUTTONS structures in the array.
////
////
//// Text to Display
//// ---------------
//// The Text field in TW_OCPBUTTONS indicates the text to display.
//// The Ansi code assciated with the current CAP_LANGUAGE setting is used
//// to convert the text.
////
//// NOTE: because blank indicates the end of the array, the application
////       should put in a space character if it does not want to display
////       any text
////
////
//// Paper Source indicator
//// ----------------------
//// The PaperSource field in TW_OCPBUTTONS indicates which paper source
//// the application will use when the user starts a scan with that choice.
//// The value for the field must be on of the TWPU_* defines associated
//// with CAP_PAPERSOURCE. For example, if the application will scan
//// strictly from the ADF, then the value for the field must be TWPU_ADF.
////
//// For this field to be read by the driver, NumDataFields must have the
//// TWOCPS_PAPERSOURCE bit set.
////
//// NOTE: If the scanner supports this indicator but the application
////       does not set this field, then no paper source indicator will
////       appear on the scanner.
////
////
//// User Supplied Graphic
//// ---------------------
//// The szGraphicFilename and GraphicLocation fields define what user
//// graphic to use and where to place it on the OCP.
////
//// The szGraphicFilename field is the complete path and file name
//// of the graphic to display.
////
//// The GraphicLocation field determines how the graphic is drawn in
//// relationship to the text being displayed. If both the Text and
//// GraphicLocation fields are provided, then this field must be
//// set to one of the following values:
////    TWOCPG_LEFT    - graphic is drawn to the left of text
////    TWOCPG_ABOVE   - graphic is drawn above text
////
//// For these fields to be read by the driver, NumDataFields must have
//// the TWOCPS_GRAPHIC bit set.
////
////
//// NOTES
//// -----
//// The scanner may not remember this information after it has been powered
//// off, so we recommend that the application send this information after
//// a successful MSG_OPENDS.
////
//// The Reserved field must be initialized to zero.
////
////
//// Example 1: text is "Color PDF", paper source is
////            "Document Feeder", no graphic
//// ------------------------------------------------
////   Text = "Color PDF"
////   NumDataFields = TWOCPS_PAPERSOURCE
////   PaperSource = TWPU_ADF
////
//// Example 2: text is "Color PDF", paper source is
////            "Document Feeder", graphic located left of text
//// ----------------------------------------------------------
////   Text = "Color PDF"
////   NumDataFields = (TWOCPS_PAPERSOURCE | TWOCPS_GRAPHIC)
////   PaperSource = TWPU_ADF
////   szGraphicFilename = "C:\Graphics\colorpdf.ico"
////   GraphicLocation = TWOCPG_LEFT
////
//#define DAT_OCPBUTTONS					0x800E
//typedef struct {
//        TW_STR255 Text;             // Displayed text on OCP for a button
//        TW_UINT32 NumDataFields;        // Bit mask indicating what fields have
//                                        //    been filled in for configuring
//                                        //    the OCP (see TWOCPS_* defines)
//        TW_UINT32 PaperSource;      // TWPU_* enum from CAP_PAPERSOURCE
//        TW_STR255 szGraphicFilename;    // Displayed graphic on OCP for a button
//        TW_UINT32 GraphicLocation;  // How graphic and text are drawn on the
//                                    //    the OCP (see TWOCPG_* defines)
//        TW_UINT8 Reserved[244];     // Room for future expansion (MUST be zero)
//    }
//    TW_OCPBUTTONS, *pTW_OCPBUTTONS;

//// NumDataFields field values for TW_OCPBUTTONS structure. The field is a bit
//// mask, so 'OR' these together. For example, if configuring both paper source
//// and graphic, the field would be set to (TWOCPS_PAPERSOURCE | TWOCPS_GRAPHIC)
//#define TWOCPS_TEXT            = 0x0000  // only Text field is filled in
//#define TWOCPS_PAPERSOURCE     = 0x0001	// PaperSource field is filled in
//#define TWOCPS_GRAPHIC         = 0x0002	// szGraphicFilename and
//					//    GraphicLocation are filled in
//// Location of OCP Graphic
//#define TWOCPG_LEFT	=	0		// graphic is drawn left of the text
//#define TWOCPG_ABOVE=		1		// graphic is drawn above the text



////
////  Alien Personality Card (DG_CONTROL)...
////  Notes:  These represent the common commands that pcards
////          may support.  Other commands documented by the
////          manufacturer of the card may be accessed using
////          the DAT_PASSTHRU operation...
//#define DAT_PCARD                          = 0x8002
//typedef struct
//{
//        TW_UINT32 StructSize;
//        TW_UINT32 Action;
//        TW_UINT32 DataSize;
//        TW_MEMREF Data;
//    }
//    TW_PCARD, *pTW_PCARD;

//// Additional return codes...
//#define TWRC_PCARD_CHECKSTATUS             = 0x8002  // something interesting has happened
//#define TWRC_PCARD_FATAL                   = 0x8003  // the card is dead
//#define TWRC_PCARD_RETRYIMAGE              = 0x8004  // the image failed a quality test
//#define TWRC_PCARD_NOCARD                  = 0x8005  // no card installed

//// Supported actions...
//#define TWPCD_ACTION_INQUIRY         =       0
//#define TWPCD_ACTION_STATUS          =       1
//#define TWPCD_ACTION_ATTRIBUTES     =        2
//#define TWPCD_ACTION_DIAGNOSTIC     =        3

//// Support structures for the various actions...
//typedef struct
//{
//        TW_INT8 StructSize[4];             // 0-3
//        TW_INT8 VendorId[8];               // 4-11
//        TW_INT8 ProductId[16];             // 12-27
//        TW_INT8 RevisionNumber[4];         // 28-31
//        TW_INT8 BuildNumber[2];            // 32-33
//        TW_INT8 Reserved[2048 - 34];         // 34-2048
//    }
//    TW_PCARD_INQUIRY, FAR* pTW_PCARD_INQUIRY;

//    typedef struct
//    {
//        TW_INT8 StructSize[4];             // 0-3
//        TW_INT8 Code[4];                   // 4-7
//        TW_INT8 Severity;                  // 8
//        TW_INT8 Text[1011];                // 9-1019
//        TW_INT8 Reserved[2048 - 1020];       // 1020-2048
//    }
//    TW_PCARD_STATUS, *pTW_PCARD_STATUS;

//typedef struct
//{
//        TW_INT8 StructSize[4];             // 0-3
//    }
//    TW_PCARD_ATTRIBUTES, *pTW_PCARD_ATTRIBUTES;

//typedef struct
//{
//        TW_INT8 StructSize[4];             // 0-3
//    }
//    TW_PCARD_HEADER, *pTW_PCARD_HEADER;


////  Driver Profiles (for drivers that support CAP_PROFILES)
////
////  Notes:  Use this structure to explore and manage profiles. These profiles
////          are compatible with DAT_CUSTOMDSDATA.
////
////          This data structure allows an application to map the CAP_PROFILES
////          numeric values to both the English and current language strings.
////
////          To get the list of profiles (for when an application wants to
////          present the list on its own user interface):
////          -----------------------------------------------------------------
////          1. Application calls DG_CONTROL / DAT_PROFILES / MSG_GET to get
////             the list of all the profiles.
////          2. Driver returns the list of profiles (i.e. fills in the
////             TW_PROFILES structure for each profile)
////          3. Application loops through the returned list until both szEnglish
////             and szName are blank (which indicates the end of the list)
////
////          To find a profile (for when an application needs to find the
////          TWPO_* for use with CAP_PROFILES):
////          -----------------------------------------------------------------
////          1. Application calls DG_CONTROL / DAT_PROFILES / MSG_GET to get
////             the list of all the profiles.
////          2. Driver returns the list of profiles (i.e. fills in the
////             TW_PROFILES structure for each profile)
////          3. Application loops through the returned list until it finds the
////             desired English profile name (use szEnglish because this will
////             always be consistent no matter what the language of the driver
////             is; where szName will be based on the driver's current
////             language, which may be different then the last time the list
////             was returned) OR ID. The application should use szEnglish name
////             if they want to always find a specific profile (i.e. Black and
////             White Doc) OR use ID when it doesn't care about specific names,
////             but wants to use unique IDs to get the same profile even if the
////             user renames it.
////          4. Application uses the ProfilesValue of the desired profile as
////             the setting for CAP_PROFILES. This means the ProfilesValue
////             will be one of the TWPO_* defines (e.g. TWPO_FILE01).
////
////		    Unless otherwise specified, start with a structure set to all zeros
////          (i.e. memset to 0), then fill in all required fields, and then fill
////          in any optional fields as desired    
////
////          To create a new profile (version 10.x+):
////          -----------------------------------------------------------------
////          - Application calls DG_CONTROL / DAT_PROFILES / MSG_PROFILECREATE
////          - Required:
////               szName       - Name of the new profile
////          - Optional:
////               szFilename   - Graphic filename associate with a new profile
////          - Errors:
////               If the new profile name is already existed then the driver 
////               driver will return TWCC_BADVALUE
////
////          To save the current driver settings (version 10.x+):
////          -----------------------------------------------------------------
////          - Application calls DG_CONTROL / DAT_PROFILES / MSG_PROFILESAVE
////          - Required: (none)
////          - Optional: (none)
////          - Errors: (none)
////
////          To delete the current profile (version 10.x+):
////          -----------------------------------------------------------------
////          - Application calls DG_CONTROL / DAT_PROFILES / MSG_PROFILEDELETE
////          - Required: (none)
////          - Optional:
////               szEnglish    - English name of profile that will be selected
////                              after deletion. If szEnglish is not specified,
////                              the driver will determine which profile to
////                              select. If you are deleting the last profile,
////                              then szEnglish should be blank
////          - Error:
////               If the profile is readonly or the profile state is 
////               TWPRF_PROFILESTATE_MODIFIED, the driver will return TWCC_DENIED 
////
////          To rename the current profile (version 10.x+):
////          -----------------------------------------------------------------
////          - Application calls DG_CONTROL / DAT_PROFILES / MSG_PROFILERENAME
////          - Required: At least specify one of the option below
////          - Optional: (can specify szCurrent or szFilename or both)
////               szName       - Name of the profile; if not supplied, the name
////                              will not be changed
////               szFilename   - Graphic filename associate with a new profile;
////                              if not supplied, the graphic will not be changed
////          - Error:
////               If the profile is readonly or the profile state is 
////               TWPRF_PROFILESTATE_MODIFIED, the driver will return TWCC_DENIED 
////
////          To restore all the supplied profiles to what was installed (v10.x+):
////          -----------------------------------------------------------------
////          - Application calls DG_CONTROL / DAT_PROFILES / MSG_PROFILERESTORE
////          - Required:
////               blSharedSettings    - Include settings shared across profiles
////                                     (e.g. Power Saver)
////          - Optional: (none)
////          - Error:
////               If profile state is TWPRF_PROFILESTATE_MODIFIED for one of the 
////               profiles, the driver will return TWCC_DENIED
////
////          To export profiles (version 10.x+):
////          -----------------------------------------------------------------
////          - Application calls DG_CONTROL / DAT_PROFILES / MSG_PROFILEEXPORT
////          - Required:
////               szFilename    - Name of the file to export
////          - Optional: (none)
////          - Error:
////               If profile state is TWPRF_PROFILESTATE_MODIFIED for one of the 
////               profiles, the driver will return TWCC_DENIED
////
////          To import profiles (version 10.x+):
////          -----------------------------------------------------------------
////          - Application calls DG_CONTROL / DAT_PROFILES / MSG_PROFILEIMPORT
////          This will remove all profiles that have been configured and
////          replace them with the imported profiles.
////          - Required:
////               szFilename    - Name of the file to import
////          - Optional: (none)
////          - Error:
////               If profile state is TWPRF_PROFILESTATE_MODIFIED for one of the 
////               profiles, the driver will return TWCC_DENIED
////
////          To set current profile (version 10.x+):
////          -----------------------------------------------------------------
////          - Application calls DG_CONTROL / DAT_PROFILES / MSG_PROFILESET
////          - Required:
////               szEnglish    - English name of the profile to be selected
////          - Optional: (none)
////          - Error: (none)
////
//#define DAT_PROFILES                       = 0x8007
//typedef struct
//{
//        TW_UINT16 ProfilesValue;          // CAP_PROFILES TWPO_* value
//        TW_STR255 szFamily;               // Deprecated TWAIN 10.x+
//        TW_STR255 szId;                   // unique profile ID
//        TW_STR255 szEnglish;              // profile name in English
//        TW_STR255 szCurrent;              // Deprecated TWAIN 10.x+
//        TW_UINT32 Group;                    // group type (see TWPRF_GROUP_*)
//        TW_BOOL Readonly;               // cannot be modifed or deleted?
//        TW_BOOL Default;                // a default profile?
//        TW_UINT32 DriverVersion;          // Deprecated TWAIN 10.x+
//        TW_STR255 szMethod;               // Deprecated TWAIN 10.x+

//        // the following are valid version 10.x+

//        TW_STR255 szName;                 // profile name in the current language.
//                                          // Uses the Ansi code page. The
//                                          // language is based on CAP_LANGUAGE

//        TW_STR255 szFilename;             // Full path and filename to a file	
//                                          // The filename is either graphic filename
//                                          // or profile filename based on the MSG
//                                          // See the description above for more details

//        TW_BOOL blSharedSettings;       // Indicates whether the shared profile
//                                        // settings are to be reset as well. 
//        TW_UINT16 ProfileState;           // Profile state (see TWPRF_PROFILESTATE_*)

//        TW_UINT8 Reserved[508];          // Room for more stuff, always set to 0.

//    }
//    TW_PROFILES, *pTW_PROFILES;


//// group types for TW_PROFILES
//#define TWPRF_GROUP_ALL                =     0


//// The profile state. There can only be one profile in the
//// profile list that is not normal.
//#define TWPRF_PROFILESTATE_NORMAL        =   0   // Not selected or modified
//#define TWPRF_PROFILESTATE_CURRENT      =    1   // Currently selected profile
//#define TWPRF_PROFILESTATE_MODIFIED    =     2   // Currently selected and has been modified


////  Notes:  This operation is used by the application to
////		DG_CONTROL / DAT_QUERYSUPPORT/ MSG_GET  or MSG_GETCURRENT or
////		MSG_GETDEFAULT.  This allows the application to find out if the DAT
////		capability is supported or not.
//#define DAT_QUERYSUPPORT                  = 0x800B

//typedef struct {
//        TW_UINT32 DG;
//        TW_UINT16 DAT;
//        TW_UINT16 MSG[64];      //Return the array of supported MSG
//    }
//    TW_QUERYSUPPORT, FAR* pTW_QUERYSUPPORT;


//    //
//    //  Gemini/Viper RAW Status (DG_CONTROL)...
//    //  Notes:  This command may be issued at any time. It reports
//    //          the raw data for the last error status reported by
//    //          the scanner.  These are device dependent values
//    //          which may be reported for servicing issues, but
//    //          should not be used to drive code...
//    //
//#define DAT_STATUSRAW                      = 0x8001
//    typedef struct
//    {
//        TW_INT32 LastToolkitStatus;
//        TW_INT32 LastSenseData[3];
//        TW_STR255 LastText;
//        TW_INT32 CurrentState;
//        TW_INT32 LastKDSStatus;
//    }
//    TW_STATUSRAW, *pTW_STATUSRAW;


////
////  Window Management
////  Notes:  Use this structure to add and remove windows.
////			A window is an index to a set of cameras, such
////			as front_bitonal, front_color, etc...
////
//#define DAT_WINDOW                         = 0x8008
//typedef struct
//{
//        TW_UINT16 WindowCamera;              // CAP_WINDOWCAMERA value
//        TW_UINT8 Reserved[1024];            // Room for more stuff
//    }
//    TW_WINDOW, *pTW_WINDOW;


//#define TWTY_FRAMEANGLE                    = 0x8001
//typedef struct {
//        TW_FIX32 Left;      // same as TW_FRAME.Left
//        TW_FIX32 Top;       // same as TW_FRAME.Top
//        TW_FIX32 Right; // same as TW_FRAME.Right
//        TW_FIX32 Bottom;    // same as TW_FRAME.Bottom
//        TW_INT32 Angle; // -3600000 to +3600000
//    }
//    TW_FRAMEANGLE, FAR* pTW_FRAMEANGLE;



//    ////////////////////////////////////////////////////////////////////////////////
//    //                      MSG Section
//    ////////////////////////////////////////////////////////////////////////////////



//    //
//    //  All Disable/Enable UI...
//    //  Notes:  This message is added to DG_CONTROL / DAT_USERINTERFACE
//    //          to allow the application to temporarily disable access
//    //          to the Source's GUI.
//    //
//#define MSG_DISABLEUI                      = 0x8003
//#define MSG_ENABLEUI                       = 0x8004


//    //
//    //  All Enable Scanner...
//    //  Notes:  This message is added to DG_CONTROL / DAT_USERINTERFACE
//    //          to allow the user to enable the scanner.  The main use
//    //          for this command is to allow a filter writer to split
//    //          a MSG_ENABLEDS into a MSG_SETUPDS followed by a
//    //          MSG_ENABLESCANNER, allowing the filter to interrogate
//    //          the scanner about its current setting before moving paper.
//    //          This command is only permitted in State 4, and if ShowUI
//    //          is set to FALSE...
//    //
//#define MSG_ENABLESCANNER                  = 0x8006


//    //
//    //  All Special Get...
//    //  Notes:  Used to get data out of sequence with the specification.
//    //          The only example at this time is use with DG_IMAGE / 
//    //          DAT_EXTIMAGEINFO...
//    //
//#define MSG_GETSPECIAL                     = 0x8005


//    //
//    //  Profile messages...
//    //  Notes:  Use these with DG_CONTROL / DAT_PROFILES.
//    //
//#define MSG_SAVEPROFILE                    = 0x8008 // Deprecated TWAIN 10.x+
//#define MSG_DELETEPROFILE                  = 0x8009 // Deprecated TWAIN 10.x+
//#define MSG_PROFILECREATE                  = 0x8015
//#define MSG_PROFILEDELETE                  = 0x8016
//#define MSG_PROFILESAVE                    = 0x8017
//#define MSG_PROFILERENAME                  = 0x8018
//#define MSG_PROFILERESTORE                 = 0x8019
//#define MSG_PROFILEEXPORT                  = 0x801A
//#define MSG_PROFILEIMPORT                  = 0x801B
//#define MSG_PROFILESET                     = 0x801C


//    //
//    //  PASSTHRU messages...
//    //  Notes:  Use these with DG_CONTROL / DAT_PASSTHRU.
//    //
//#define MSG_GETINQUIRY                     = 0x801D
//#define MSG_RESOURCEBEGIN                  = 0x801F
//#define MSG_RESOURCEEND                    = 0x8020


//    //
//    //  Special message to check for 'endofsheet' and 'appinputneeded' statuses...
//    //  Notes:  Use these with DG_CONTROL / DAT_PENDINGXFERS.
//    //
//#define MSG_ENDXFERSPECIAL                 = 0x801E


//    //
//    //  All Setup DS...
//    //  Notes:  This message is added to DG_CONTROL / DAT_USERINTERFACE
//    //          to allow the user download the current settings without
//    //          initiating a scanning session.  The state remains at 4,
//    //          no matter what the outcome of the command.
//    //          To select the current settings see CAP_PROFILES or CUSTOMDSDATA
//    //
//#define MSG_SETUPDS                        = 0x8002


//    //
//    //  Window messages...
//    //  Notes:  Use these with DG_CONTROL / DAT_WINDOW.
//    //
//#define MSG_ADDWINDOW                      = 0x8011
//#define MSG_DELETEWINDOW                   = 0x8012


//    // OBS_JPEGQUALITY
//    // Notes:       Same as standard ICAP_JPEGQUALITY, do not use.
//#define OBS_JPEGQUALITY                    = 0x8040


//    //
//    //  All Stop Feeder...
//    //  Notes:  This message is added to DG_CONTROL / DAT_PENDINGXFERS
//    //          to allow the user to turn off the transport.
//    //          Do not use this message, use MSG_STOPFEEDER...
//    //
//#define OBS_STOPFEEDER                     = 0x8001



//    ////////////////////////////////////////////////////////////////////////////////
//    //                      TW Section
//    ////////////////////////////////////////////////////////////////////////////////



//    // Filter...
//#define TWRC_FILTER_CONTINUE               = 0x8010


//    //
//    //  Patchcode extensions...
//    //  Notes:  This section extends the patch codes.  Note that
//    //          a transfer patch is interpreted to be a level 2 or
//    //          a level three, so even though it can be set, a
//    //          transfer patch is never received as part of the
//    //          extended image info data...
//    //
//#define TWPCH_PATCHT2                      = 0x8001
//#define TWPCH_PATCHT3                      = 0x8002
//#define TWEJ_PATCHT2                       = 0x8001
//#define TWEJ_PATCHT3                       = 0x8002
//    //
//    //  Blaze extensions...
//    //  Notes:  This section extends the job control values to include an
//    //          'endofsheet' and 'appinput needed' value. These values
//    //          may be returned in the EOJ field of the TW_PENDINGXFERS
//    //          struct, only when the command:
//    //              DAT_PENDINGXFERS / MSG_ENDXFERSPECIAL
//    //          is issued.
//#define TWEJ_ENDOFSHEET                    = 0x0001
//#define TWEJ_APPINPUTNEEDED                = 0x0002


//    //
//    //  QuerySupport extensions...
//    //
//#define TWQC_MACHINE                       = 0x1000
//#define TWQC_BITONAL                       = 0x2000
//#define TWQC_COLOR                         = 0x4000
//#define TWQC_WINDOW                        = 0x8000


//    // Device Events
//    //
//    // The following are the device event supported by all drivers
//    // prior to version 9.3: TWDE_PAPERDOUBLEFEED and TWDE_PAPERJAM
//    //
//    // For version 9.3 drivers and up, the following is a custom
//    // CAP_DEVICEEVENT the application can ask the driver to send
//    // it when the lamps need to warmup prior to scanning. This
//    // event will be issued after a MSG_ENABLEDS if the lamps
//    // are not warmed up. The number of seconds before the lamps
//    // are ready will be in the TimeBeforeFirstCapture field of
//    // the TW_DEVICEVENT structure.
//    //
//    // NOTE: The number of seconds may be longer than what it
//    //       actually take. This could happen because an error
//    //       occurred (e.g. opening cover, cancelling) or for
//    //       models that do not have an accurate warmup value.
//    //       Because of this, if your application is displaying
//    //       a “please wait” message for the user, the message
//    //       needs to be closed when MSG_XFERREADY is received.
//#define TWDE_LAMPWARMUP     =   	0x8002


//    // TWEI_HDR_BINARIZATIONQUALITY
//    //
//    // This conveys the quality level of the binarized image
//    // Some binarization methods can detect if the  binarization
//    // resulted in a noisy (or otherwise suspect) output.
//    // For those binarization method that don't detect this,
//    // 'normal' is returned.
//#define TWBQ_NORMAL             0
//#define TWBQ_NOISY  =            1

