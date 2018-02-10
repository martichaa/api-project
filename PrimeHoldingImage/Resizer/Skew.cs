using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeHoldingImage.Resizer
{
    class Skew : IResize
    {
        public void Resize(Image sourceImage, string destinationPath, int width, int height)
        {
            using (Bitmap destinationImage = new Bitmap(sourceImage, width, height))
            {
                destinationImage.Save(destinationPath, sourceImage.RawFormat);
            }
        }
    }
}
