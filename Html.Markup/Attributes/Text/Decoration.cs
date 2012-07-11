namespace Html.Markup
{
    public sealed class Decoration
    {
        private readonly string _attr;

        private Decoration(string attr)
        {
            _attr = attr;
        }

        public static implicit operator string(Decoration n)
        {
            return n.ToString();
        }

        public override string ToString()
        {
            return _attr;
        }

        public static readonly Decoration None = new Decoration("none");
        public static readonly Decoration Underline = new Decoration("underline");
        public static readonly Decoration Overline = new Decoration("overline");
    }
}