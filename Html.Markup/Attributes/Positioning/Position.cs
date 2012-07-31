namespace Html.Markup
{
    public sealed class Position
    {
        private readonly string _attr;
       
        private Position(string attr)
        {
            _attr = attr;
        }

        public static implicit operator string(Position n)
        {
            return n.ToString();
        }

        public override string ToString()
        {
            return _attr;
        }

        public static readonly Position Static = new Position("static");
        public static readonly Position Absolute = new Position("absolute");
        public static readonly Position Fixed = new Position("fixed");
        public static readonly Position Relative = new Position("relative");
        public static readonly Position Inherit = new Position("inherit");
    }
}