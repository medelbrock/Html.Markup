namespace Html.Markup
{
    public sealed class Ol : Markup
    {
        protected override string Tag { get { return "ol"; } }

        public Ol(string id = null, StyleAttributes style = null, string cssClass = null, string text = null)
            : base()
        {
            Style = style;
            Class = cssClass;
            ID = id;
            Text = text;
        }
    }
}