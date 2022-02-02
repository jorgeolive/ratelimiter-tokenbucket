using System.Runtime.Serialization;

namespace RateLimiter_tokenBucket
{
    [Serializable]
    internal class NoTokensAvailableException : Exception
    {
        public NoTokensAvailableException()
        {
        }

        public NoTokensAvailableException(string? message) : base(message)
        {
        }

        public NoTokensAvailableException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected NoTokensAvailableException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}