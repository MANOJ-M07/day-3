using System;
using System.Runtime.Serialization;

namespace ConsoleAppExcercise
{
    [Serializable]
    internal class OverFlowException : Exception
    {
        public OverFlowException()
        {
        }

        public OverFlowException(string message) : base(message)
        {
        }

        public OverFlowException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected OverFlowException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}