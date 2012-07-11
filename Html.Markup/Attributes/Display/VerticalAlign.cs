namespace Html.Markup
{
    public class VerticalAlign
    {
        private readonly string _val;

        private VerticalAlign(string val)
        {
            _val = val;
        }

        public override string ToString()
        {
            return _val;
        }

        public static readonly VerticalAlign Baseline = new VerticalAlign("baseline");
        public static readonly VerticalAlign Sub = new VerticalAlign("sub");
        public static readonly VerticalAlign Super = new VerticalAlign("super");
        public static readonly VerticalAlign Top = new VerticalAlign("top");
        public static readonly VerticalAlign TextTop = new VerticalAlign("text-top");
        public static readonly VerticalAlign Middle = new VerticalAlign("middle");
        public static readonly VerticalAlign Bottom = new VerticalAlign("bottom");
        public static readonly VerticalAlign TextBottom = new VerticalAlign("text-bottom");
    }
}