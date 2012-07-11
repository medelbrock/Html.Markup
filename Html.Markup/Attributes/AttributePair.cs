namespace Html.Markup
{
    public class AttributePair
    {
        public AttributePair() { }

        public AttributePair(string set, string value) { Set = set; Value = value; }

        public AttributePair(string set, int value) { Set = set; Value = value.ToString(); }

        public string Set { get; set; }

        public string Value { get; set; }
    }
}