using System;
using System.Runtime.Serialization;

namespace Html.Markup
{
    public class HandleException : Exception
    {
        public override string Message
        {
            get { return base.Message.ToString(); }
        }

        public HandleException(string message)
            : base(message) { }

        public HandleException(string message, Exception inner)
            : base(message, inner) { }

        public HandleException(SerializationInfo info, StreamingContext context)
            : base(info, context) { }
    }
}