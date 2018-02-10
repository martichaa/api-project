using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeHoldingImage.Exceptions
{
    public class InvalidImageDimensionsException : Exception
    {
        public InvalidImageDimensionsException()
        {
        }

        public InvalidImageDimensionsException(string message) : base(message)
        {
        }

        public InvalidImageDimensionsException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
