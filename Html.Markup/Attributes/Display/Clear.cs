namespace Html.Markup
{
    public class Clear
    {
        private readonly string _val;

        private Clear(string val)
        {
            _val = val;
        }

        public static implicit operator string(Clear n)
        {
            return n.ToString();
        }

        public override string ToString()
        {
            return _val;
        }

        public static readonly Clear Left = new Clear("left");
        public static readonly Clear Right = new Clear("right");
        public static readonly Clear Both = new Clear("both");
    }
}