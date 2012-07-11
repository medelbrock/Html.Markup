namespace Html.Markup
{
    public sealed class ContentFlow
    {
        private readonly string _attr;

        private ContentFlow(string attr)
        {
            _attr = attr;
        }

        public static implicit operator string(ContentFlow n)
        {
            return n.ToString();
        }

        public override string ToString()
        {
            return _attr;
        }

        public static readonly ContentFlow Visible = new ContentFlow("visible");
        public static readonly ContentFlow Hidden = new ContentFlow("hidden");
        public static readonly ContentFlow Scroll = new ContentFlow("scroll");
        public static readonly ContentFlow Auto = new ContentFlow("auto");
        public static readonly ContentFlow NoDisplay = new ContentFlow("no-display");
        public static readonly ContentFlow NoContent = new ContentFlow("no-content");
    }
}