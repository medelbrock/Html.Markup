namespace Html.Markup
{
    public sealed class Align
    {
        private readonly string _attr;

        private Align(string attr)
        {
            _attr = attr;
        }

        public static implicit operator string(Align n)
        {
            return n.ToString();
        }

        public override string ToString()
        {
            return _attr;
        }

        public static readonly Align Right = new Align("right");
        public static readonly Align Left = new Align("left");
        public static readonly Align Center = new Align("center");
    }
}