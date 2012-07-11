namespace Html.Markup
{
    public sealed class FontStyle
    {
        private readonly string _attr;

        private FontStyle(string attr)
        {
            _attr = attr;
        }

        public static implicit operator string(FontStyle n)
        {
            return n.ToString();
        }

        public override string ToString()
        {
            return _attr;
        }

        public static readonly FontStyle Normal = new FontStyle("normal");
        public static readonly FontStyle Italic = new FontStyle("italic");
        public static readonly FontStyle Oblique = new FontStyle("oblique");
        public static readonly FontStyle Inherit = new FontStyle("inherit");
    }
}