using System;
using System.Runtime.Serialization;

namespace Forma1.myExceptions
{
    [Serializable]
    internal class F1Exception : Exception
    {
        public F1Exception()
        {
        }

        public F1Exception(string message) : base(message)
        {
        }

        public F1Exception(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected F1Exception(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}