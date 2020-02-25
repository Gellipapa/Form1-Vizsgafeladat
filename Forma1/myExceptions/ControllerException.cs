using System;
using System.Runtime.Serialization;

namespace Forma1.myExceptions
{
    [Serializable]
    internal class ControllerException : Exception
    {
        public ControllerException()
        {
        }

        public ControllerException(string message) : base(message)
        {
        }

        public ControllerException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ControllerException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}