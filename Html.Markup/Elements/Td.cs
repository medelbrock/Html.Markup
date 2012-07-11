namespace Html.Markup
{
    public sealed class Td : Markup
    {
        protected override string Tag { get { return "td"; } }

        public Td(string id = null, StyleAttributes style = null, string cssClass = null, string text = null)
            : base()
        {
            Style = style;
            Class = cssClass;
            ID = id;
            Text = text;
        }
    }
}