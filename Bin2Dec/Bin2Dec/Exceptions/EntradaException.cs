using System.Runtime.Serialization;

namespace Bin2Dec.Exceptions
{
    internal class EntradaException : Exception
    {
        public EntradaException()
        {
        }

        public EntradaException(string? message) : base(message)
        {
        }

        public EntradaException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected EntradaException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
