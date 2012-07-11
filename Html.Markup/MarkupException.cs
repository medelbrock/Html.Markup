using System;
using System.Runtime.Serialization;

namespace Html.Markup
{
    public class MarkupException : HandleException
    {
        public MarkupException(string message)
            : base(message) { }

        public MarkupException(string message, Exception inner)
            : base(message, inner) { }

        public MarkupException(SerializationInfo info, StreamingContext context)
            : base(info, context) { }
    }
}