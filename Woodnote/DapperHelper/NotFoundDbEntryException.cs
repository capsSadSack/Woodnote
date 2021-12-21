using System;

namespace DapperHelper
{
    public class NotFoundDbEntryException<T> : Exception
    {
        public NotFoundDbEntryException()
            : base() { }

        public NotFoundDbEntryException(string message)
            : base(message) { }

        public NotFoundDbEntryException(string message, Exception innerException)
            : base(message, innerException) { }
    }
}
