using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeHoldingImage.Converter
{
    class Gif : IConvert
    {
        public void Convert(Image sourceImage, string destinationPath)
        {
            sourceImage.Save(destinationPath, System.Drawing.Imaging.ImageFormat.Gif);
        }
    }
}
