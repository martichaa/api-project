using PrimeHoldingImage.Exceptions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeHoldingImage.Resizer
{
    class Crop : IResize
    {
        private int x;
        private int y;

        public Crop(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void Resize(Image sourceImage, string destinationPath, int width, int height)
        {
            if (x > sourceImage.Width || y > sourceImage.Height ||
                    width + x > sourceImage.Width || height + y > sourceImage.Height)
            {
                throw new InvalidImageDimensionsException();
            }
            using (Bitmap bmp = new Bitmap(width, height, PixelFormat.Format24bppRgb))
            {
                bmp.SetResolution(80, 60);

                Rectangle rectangle = new Rectangle(0, 0, width, height);

                using (Graphics gfx = Graphics.FromImage(bmp))
                {
                    gfx.SmoothingMode = SmoothingMode.AntiAlias;
                    gfx.InterpolationMode = InterpolationMode.HighQualityBicubic;
                    gfx.PixelOffsetMode = PixelOffsetMode.HighQuality;
                    gfx.DrawImage(sourceImage, rectangle, x, y, width, height, GraphicsUnit.Pixel);

                    bmp.Save(destinationPath, sourceImage.RawFormat);
                }
            }
        }
    }
}
