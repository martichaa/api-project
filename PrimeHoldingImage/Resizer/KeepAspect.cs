using PrimeHoldingImage.Exceptions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeHoldingImage.Resizer
{
    class KeepAspect : IResize
    {
        public void Resize(Image sourceImage, string destinationPath, int width, int height)
        {            
            double sourceRatio = (double)sourceImage.Width / sourceImage.Height;
            double destinationRatio = (double)width / height;

            if (Math.Round(sourceRatio, 2) != Math.Round(destinationRatio, 2))
            {
                throw new InvalidAspectRatioException("Source and destination aspect ratios must be same!");
            }

            using (Bitmap destinationImage = new Bitmap(sourceImage, width, height))
            {
                destinationImage.Save(destinationPath, sourceImage.RawFormat);
            }
        }
    }
}
