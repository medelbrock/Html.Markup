namespace Html.Markup
{
    public sealed class FontVariant
    {
        private readonly string _attr;

        private FontVariant(string attr)
        {
            _attr = attr;
        }

        public static implicit operator string(FontVariant n)
        {
            return n.ToString();
        }

        public override string ToString()
        {
            return _attr;
        }

        public static readonly FontVariant Normal = new FontVariant("normal");
        public static readonly FontVariant SmallCaps = new FontVariant("small-caps");
        public static readonly FontVariant Inherit = new FontVariant("inherit");
    }
}