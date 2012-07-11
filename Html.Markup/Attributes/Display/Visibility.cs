namespace Html.Markup
{
    public sealed class Visibility
    {
        private readonly string _attr;

        private Visibility(string attr)
        {
            _attr = attr;
        }

        public static implicit operator string(Visibility n)
        {
            return n.ToString();
        }

        public override string ToString()
        {
            return _attr;
        }

        public static readonly Visibility Visible = new Visibility("visible");
        public static readonly Visibility Hidden = new Visibility("hidden");
        public static readonly Visibility Collapse = new Visibility("collapse");
        public static readonly Visibility Inherit = new Visibility("inherit");
    }
}