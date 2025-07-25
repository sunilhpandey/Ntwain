﻿using NTwain.Data;
using System;
using System.Runtime.InteropServices;

namespace NTwain.Native
{
  static class ImageTools
  {
    // this is modified from twain cs sample
    // http://sourceforge.net/projects/twainforcsharp/?source=typ_redirect

    public static bool IsDib(IntPtr data)
    {
      // a quick check not guaranteed correct,
      // compare first 2 bytes to size of struct (which is also the first field)
      var test = Marshal.ReadInt16(data);
      // should be 40
      return test == BITMAPINFOHEADER.GetByteSize();
    }
    public static bool IsTiff(IntPtr data)
    {
      var test = Marshal.ReadInt16(data);
      // should be II
      return test == 0x4949;
    }

    public static unsafe BufferedData? GetBitmapData(IntPtr data)
    {
      var infoHeader = Marshal.PtrToStructure<BITMAPINFOHEADER>(data);
      if (infoHeader.Validate())
      {
        var fileHeaderSize = Marshal.SizeOf(typeof(BITMAPFILEHEADER));

        var fileHeader = new BITMAPFILEHEADER
        {
          bfType = 0x4D42, // "BM"
          bfOffBits = (uint)fileHeaderSize +
            infoHeader.biSize +
            (infoHeader.biClrUsed * 4)
        };
        fileHeader.bfSize = fileHeader.bfOffBits + infoHeader.biSizeImage;

        var dataCopy = BufferedData.MemPool.Rent((int)fileHeader.bfSize); // new byte[fileHeader.bfSize];

        // TODO: run benchmark on which one is faster

        // write file header
        //IntPtr tempPtr = Marshal.AllocHGlobal(fileHeaderSize);
        //Marshal.StructureToPtr(fileHeader, tempPtr, true);
        //Marshal.Copy(tempPtr, dataCopy, 0, fileHeaderSize);
        //Marshal.FreeHGlobal(tempPtr);

        // would this be faster?
        fixed (byte* p = dataCopy)
        {
          Marshal.StructureToPtr(fileHeader, (IntPtr)p, false);
        }

        // write image
        Marshal.Copy(data, dataCopy, fileHeaderSize, (int)fileHeader.bfSize - fileHeaderSize);
        return new BufferedData(dataCopy, (int)fileHeader.bfSize, true);
      }
      return default;
    }

    public static BufferedData? GetTiffData(IntPtr data)
    {
      // Find the size of the image so we can turn it into a memory stream...
      var headerSize = Marshal.SizeOf(typeof(TIFFHEADER));
      var tagSize = Marshal.SizeOf(typeof(TIFFTAG));
      var tiffSize = 0;
      var tagPtr = data.ToInt64() + headerSize;
      for (int i = 0; i < 999; i++)
      {
        tagPtr += (tagSize * i);
        var tag = Marshal.PtrToStructure<TIFFTAG>((IntPtr)tagPtr);

        switch (tag.u16Tag)
        {
          case 273: // StripOffsets...
          case 279: // StripByteCounts...
            tiffSize += (int)tag.u32Value;
            break;
        }
      }

      if (tiffSize > 0)
      {
        var dataCopy = BufferedData.MemPool.Rent(tiffSize);// new byte[tiffSize];
        Marshal.Copy(data, dataCopy, 0, tiffSize);
        return new BufferedData(dataCopy, tiffSize, true);
      }
      return default;
    }

    //internal static Bitmap ReadBitmapImage(IntPtr data)
    //{
    //    Bitmap finalImg = null;
    //    Bitmap tempImg = null;
    //    try
    //    {
    //        var header = (BITMAPINFOHEADER)Marshal.PtrToStructure(data, typeof(BITMAPINFOHEADER));

    //        if (header.Validate())
    //        {
    //            PixelFormat format = header.GetDrawingPixelFormat();
    //            tempImg = new Bitmap(header.biWidth, Math.Abs(header.biHeight), header.GetStride(), format, header.GetScan0(data));
    //            ColorPalette pal = header.GetDrawingPalette(data);
    //            if (pal != null)
    //            {
    //                tempImg.Palette = pal;
    //            }
    //            float xdpi = header.GetXDpi();
    //            float ydpi = header.GetYDpi();
    //            if (xdpi != 0 && ydpi == 0)
    //            {
    //                ydpi = xdpi;
    //            }
    //            else if (ydpi != 0 && xdpi == 0)
    //            {
    //                xdpi = ydpi;
    //            }
    //            if (xdpi != 0)
    //            {
    //                tempImg.SetResolution(xdpi, ydpi);
    //            }
    //            if (header.IsBottomUpImage)
    //            {
    //                tempImg.RotateFlip(RotateFlipType.RotateNoneFlipY);
    //            }
    //            finalImg = tempImg;
    //            tempImg = null;
    //        }
    //    }
    //    finally
    //    {
    //        if (tempImg != null)
    //        {
    //            tempImg.Dispose();
    //        }
    //    }
    //    return finalImg;
    //}
  }
}
