namespace Html.Markup
{
    public sealed class EncodedType
    {
        private readonly string _attr;

        private EncodedType(string attr)
        {
            _attr = attr;
        }

        public static implicit operator string(EncodedType n)
        {
            return n.ToString();
        }

        public override string ToString()
        {
            return _attr;
        }

        public static readonly EncodedType ApplicationXFormUrlEncoded = new EncodedType("application/x-www-form-urlencoded");
        public static readonly EncodedType MultipartFormData = new EncodedType("multipart/form-data");
        public static readonly EncodedType TextPlain = new EncodedType("text/plain");
    }
}