namespace Html.Markup
{
    public sealed class Positioning
    {
        private readonly string _attr;

        private Positioning(string attr)
        {
            _attr = attr;
        }

        public static implicit operator string(Positioning n)
        {
            return n.ToString();
        }

        public override string ToString()
        {
            return _attr;
        }

        public static readonly Positioning Static = new Positioning("static");
        public static readonly Positioning Absolute = new Positioning("absolute");
        public static readonly Positioning Fixed = new Positioning("fixed");
        public static readonly Positioning Relative = new Positioning("relative");
        public static readonly Positioning Inherit = new Positioning("inherit");
    }
}