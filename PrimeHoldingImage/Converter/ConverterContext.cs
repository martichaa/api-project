using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeHoldingImage.Converter
{
    class ConverterContext
    {
        private IConvert converter;

        public ConverterContext(IConvert converter)
        {
            this.converter = converter;
        }

        public void Convert(Image sourceImage, string destinationPath)
        {
            this.converter.Convert(sourceImage, destinationPath);
        }
    }
}
