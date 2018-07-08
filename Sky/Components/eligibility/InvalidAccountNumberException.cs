using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Sky.Components.eligibility
{
    public class InvalidAccountNumberException : Exception
    {
        public InvalidAccountNumberException()
        {
        }

        public InvalidAccountNumberException(string message)
            : base(message)
        {
        }

        public InvalidAccountNumberException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        public InvalidAccountNumberException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}
