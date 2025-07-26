using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFM.Application.Exceptions
{
    public class BusinessValidationException : Exception
    {
        public int ErrorCode { get; }

        public BusinessValidationException(string message, int errorCode = 440) : base(message)
        {
            ErrorCode = errorCode;
        }
    }
}
