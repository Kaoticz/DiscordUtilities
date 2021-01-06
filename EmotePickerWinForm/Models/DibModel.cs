using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmotePickerWinForm.Models
{
    // TODO: Make a constructor for this monster
    public struct DibModel
    {
        public uint Size;
        public long Width;
        public long Height;
        public ushort Planes;
        public ushort BitCount;
        public uint Compression;
        public uint SizeImage;
        public long XPelsPerMeter;
        public long YPelsPerMeter;
        public uint ClrUsed;
        public uint ClrImportant;
        public uint RedMask;
        public uint GreenMask;
        public uint BlueMask;
        public uint AlphaMask;
        public uint CSType;
        public CIEXYZTRIPLE Endpoints;
        public uint GammaRed;
        public uint GammaGreen;
        public uint GammaBlue;
        //public uint Intent;
        //public uint ProfileData;
        //public uint ProfileSize;
        //public uint Reserved;

        public DibModel(Bitmap image, long imageBytes)
        {
            Size = (uint)System.Runtime.InteropServices.Marshal.SizeOf(typeof(DibModel));
            Width = image.Width;
            Height = image.Height;
            Planes = 1;
            BitCount = 24; // 1, 4, 8, or 24
            Compression = 0; // 0, 1, 2 or 3 == BI_RGB, BI_RLE8, BI_RLE4, or BI_BITFIELDS
            SizeImage = (uint)imageBytes;
            XPelsPerMeter = (long)image.HorizontalResolution;
            YPelsPerMeter = (long)image.VerticalResolution;
            ClrUsed = 0;
            ClrImportant = 0;
            RedMask = 0xFF0000;
            GreenMask = 0x00FF00;
            BlueMask = 0x0000FF;
            AlphaMask = 0;
            CSType = 0;
            Endpoints = new CIEXYZTRIPLE(255, 255, 255);
            GammaRed = 0;
            GammaGreen = 0;
            GammaBlue = 0;
            //Intent = 0;
            //ProfileData = 0;
            //ProfileSize = 0;
            //Reserved = 0;
        }
    }

    public struct CIEXYZTRIPLE
    {
        public CIEXYZ ciexyzRed;
        public CIEXYZ ciexyzGreen;
        public CIEXYZ ciexyzBlue;

        public CIEXYZTRIPLE(byte R, byte G, byte B)
        {
            ciexyzRed = new CIEXYZ(R, 0, 0);
            ciexyzGreen = new CIEXYZ(0, G, 0);
            ciexyzBlue = new CIEXYZ(0, 0, B);
        }
    }

    public struct CIEXYZ
    {
        public FXPT2DOT30 ciexyzX;
        public FXPT2DOT30 ciexyzY;
        public FXPT2DOT30 ciexyzZ;

        public CIEXYZ(byte R, byte G, byte B)
        {


            ciexyzX = new FXPT2DOT30(R, 0, 0, 0);
            ciexyzY = new FXPT2DOT30(G, 0, 0, 0);
            ciexyzZ = new FXPT2DOT30(B, 0, 0, 0);
        }
    }

    public struct FXPT2DOT30
    {
        public byte intfracPart;
        public byte fractionalPart1;
        public byte fractionalPart2;
        public byte fractionalPart3;

        public FXPT2DOT30(byte intPart, byte frac1, byte frac2, byte frac3)
        {
            intfracPart = intPart;
            fractionalPart1 = frac1;
            fractionalPart2 = frac2;
            fractionalPart3 = frac3;
        }
    }
}
