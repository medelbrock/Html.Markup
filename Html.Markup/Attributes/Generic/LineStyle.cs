namespace Html.Markup
{
    public sealed class LineStyle
    {
        private readonly string _attr;

        private LineStyle(string attr)
        {
            _attr = attr;
        }

        public static implicit operator string(LineStyle n)
        {
            return n.ToString();
        }

        public override string ToString()
        {
            return _attr;
        }

        public static readonly LineStyle None = new LineStyle("none");
        public static readonly LineStyle Hidden = new LineStyle("hidden");
        public static readonly LineStyle Dotted = new LineStyle("dotted");
        public static readonly LineStyle Dashed = new LineStyle("dashed");
        public static readonly LineStyle Solid = new LineStyle("solid");
        public static readonly LineStyle Double = new LineStyle("double");
        public static readonly LineStyle Groove = new LineStyle("groove");
        public static readonly LineStyle Ridge = new LineStyle("ridge");
        public static readonly LineStyle Inset = new LineStyle("inset");
        public static readonly LineStyle Outset = new LineStyle("outset");
        public static readonly LineStyle Inherit = new LineStyle("inherit");
    }
}