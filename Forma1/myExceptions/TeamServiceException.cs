using System;
using System.Runtime.Serialization;

namespace Forma1.myExceptions

{
    [Serializable]
    internal class TeamServiceException : Exception
    {
        public TeamServiceException()
        {
        }

        public TeamServiceException(string message) : base(message)
        {
        }

        public TeamServiceException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected TeamServiceException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}