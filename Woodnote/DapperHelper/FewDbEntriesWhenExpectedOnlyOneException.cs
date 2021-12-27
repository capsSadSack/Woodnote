using System;

namespace DapperHelper
{
    public class FewDbEntriesWhenExpectedOnlyOneException<T> : Exception
    {
        public FewDbEntriesWhenExpectedOnlyOneException()
            : base() { }

        public FewDbEntriesWhenExpectedOnlyOneException(string message)
            : base(message) { }

        public FewDbEntriesWhenExpectedOnlyOneException(string message, Exception innerException)
            : base(message, innerException) { }
    }
}
