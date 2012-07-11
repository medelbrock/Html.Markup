namespace Html.Markup
{
    public sealed class Float
    {
        private readonly string _attr;

        private Float(string attr)
        {
            _attr = attr;
        }

        public static implicit operator string(Float n)
        {
            return n.ToString();
        }

        public override string ToString()
        {
            return _attr;
        }

        public static readonly Float Left = new Float("left");
        public static readonly Float None = new Float("none");
        public static readonly Float Right = new Float("right");
    }
}