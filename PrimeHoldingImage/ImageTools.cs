using PrimeHoldingImage.Converter;
using PrimeHoldingImage.Exceptions;
using PrimeHoldingImage.Resizer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeHoldingImage
{
    public class ImageTools
    {
        private ConverterContext converter;

        private ResizerContext resizer;

        public void Convert(string sourcePath, string destinationPath, string type)
        {
            switch (type.ToLower())
            {
                case "jpg":
                case "jpeg":
                    converter = new ConverterContext(new Jpg());
                    break;

                case "png":
                    converter = new ConverterContext(new Png());
                    break;

                case "gif":
                    converter = new ConverterContext(new Gif());
                    break;

                default:
                    throw new ImageFormatException("Invalid image format!");
            }

            using (Image sourceImage = Image.FromFile(sourcePath))
            {
                converter.Convert(sourceImage, destinationPath);
            }
        }

        public void Resize(string sourcePath, string destinationPath, string type, int width, int height, int x = 0, int y = 0)
        {
            switch (type.ToLower())
            {
                case "crop":
                    resizer = new ResizerContext(new Crop(x, y));
                    break;

                case "skew":
                    resizer = new ResizerContext(new Skew());
                    break;

                case "keepaspect":
                    resizer = new ResizerContext(new KeepAspect());
                    break;

                default:
                    throw new InvalidParameterException();
            }

            using (Image sourceImage = new Bitmap(sourcePath))
            {
                resizer.Resize(sourceImage, destinationPath, width, height);
            }
        }
    }
}
