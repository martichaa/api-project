using PrimeHoldingImage.Exceptions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeHoldingImage.Resizer
{
    class ResizerContext
    {
        private IResize resizer;

        public ResizerContext(IResize resizer)
        {
            this.resizer = resizer;
        }

        public void Resize(Image sourceImage, string destinationPath, int width, int height)
        {
            if (width <= 0 || height <= 0)
            {
                throw new InvalidImageDimensionsException("Destination dimensions must be non-zero values!");
            }

            this.resizer.Resize(sourceImage, destinationPath, width, height);
        }
    }
}
