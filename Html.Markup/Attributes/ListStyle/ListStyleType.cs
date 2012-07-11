namespace Html.Markup
{
    public sealed class ListStyleType
    {
        private readonly string _attr;

        private ListStyleType(string attr)
        {
            _attr = attr;
        }

        public static implicit operator string(ListStyleType n)
        {
            return n.ToString();
        }

        public override string ToString()
        {
            return _attr;
        }

        public static readonly ListStyleType Armenian = new ListStyleType("armenian");
        public static readonly ListStyleType Circle = new ListStyleType("circle");
        public static readonly ListStyleType CjkIdeographic = new ListStyleType("cjk-ideographic");
        public static readonly ListStyleType Decimal = new ListStyleType("decimal");
        public static readonly ListStyleType DecimalLeadingZero = new ListStyleType("decimal-leading-zero");
        public static readonly ListStyleType Disc = new ListStyleType("disc");
        public static readonly ListStyleType Georgian = new ListStyleType("georgian");
        public static readonly ListStyleType Hebrew = new ListStyleType("hebrew");
        public static readonly ListStyleType Hiragana = new ListStyleType("hiragana");
        public static readonly ListStyleType HiraganaIroha = new ListStyleType("hiragana-iroha");
        public static readonly ListStyleType Katakana = new ListStyleType("katakana");
        public static readonly ListStyleType Inherit = new ListStyleType("inherit");
        public static readonly ListStyleType KatakanaIroha = new ListStyleType("katakana-iroha");
        public static readonly ListStyleType LowerAlpha = new ListStyleType("lower-alpha");
        public static readonly ListStyleType LowerGreek = new ListStyleType("lower-greek");
        public static readonly ListStyleType LowerLatin = new ListStyleType("lower-latin");
        public static readonly ListStyleType LowerRoman = new ListStyleType("lower-roman");
        public static readonly ListStyleType None = new ListStyleType("none");
        public static readonly ListStyleType Square = new ListStyleType("square");
        public static readonly ListStyleType UpperAlpha = new ListStyleType("upper-alpha");
        public static readonly ListStyleType UpperLatin = new ListStyleType("upper-latin");
        public static readonly ListStyleType UpperRoman = new ListStyleType("upper-roman");
    }
}