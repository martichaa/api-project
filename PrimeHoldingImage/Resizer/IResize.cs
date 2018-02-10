using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeHoldingImage.Resizer
{
    interface IResize
    {
        void Resize(Image sourceImage, string destinationPath, int width, int height);
    }
}
