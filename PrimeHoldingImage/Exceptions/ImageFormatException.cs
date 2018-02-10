using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeHoldingImage.Exceptions
{
    public class ImageFormatException : Exception
    {
        public ImageFormatException()
        {
        }

        public ImageFormatException(string message) : base(message)
        {
        }

        public ImageFormatException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
