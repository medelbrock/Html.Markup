namespace Html.Markup
{
    public sealed class Span : Markup
    {
        protected override string Tag { get { return "span"; } }

        public Span(string id = null, StyleAttributes style = null, string cssClass = null, string text = null)
            : base()
        {
            Style = style;
            Class = cssClass;
            ID = id;
            Text = text;
        }
    }
}