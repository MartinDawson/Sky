using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Sky.Components.eligibility
{
    public class TechnicalServiceException : Exception
    {
        public TechnicalServiceException()
        {
        }

        public TechnicalServiceException(string message)
            : base(message)
        {
        }

        public TechnicalServiceException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        public TechnicalServiceException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}
