using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeHoldingImage.Exceptions
{
    public class InvalidAspectRatioException : Exception
    {
        public InvalidAspectRatioException()
        {
        }

        public InvalidAspectRatioException(string message) : base(message)
        {
        }

        public InvalidAspectRatioException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
