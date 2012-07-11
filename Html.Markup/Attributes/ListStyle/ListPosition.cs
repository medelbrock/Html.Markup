namespace Html.Markup
{
    public sealed class ListPosition
    {
        private readonly string _attr;

        private ListPosition(string attr)
        {
            _attr = attr;
        }

        public static implicit operator string(ListPosition n)
        {
            return n.ToString();
        }

        public override string ToString()
        {
            return _attr;
        }

        public static readonly ListPosition Inside = new ListPosition("inside");
        public static readonly ListPosition Outside = new ListPosition("outside");
        public static readonly ListPosition Inherit = new ListPosition("inherit");
    }
}