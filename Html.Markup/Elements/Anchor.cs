namespace Html.Markup
{
    public sealed class Anchor : Markup
    {
        public string Href { get; set; }

        protected override string Tag { get { return "a"; } }

        public Anchor(string id = null, StyleAttributes style = null, string cssClass = null, string text = null)
            : base()
        {
            Style = style;
            Class = cssClass;
            ID = id;
            Text = text;
        }

        public override string ToString()
        {
            AttrList.Add(new AttributePair { Set = "href", Value = Href });
            return base.ToString();
        }
    }
}