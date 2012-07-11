namespace Html.Markup
{
    public sealed class Ul : Markup
    {
        protected override string Tag { get { return "ul"; } }

        public Ul(string id = null, StyleAttributes style = null, string cssClass = null, string text = null)
            : base()
        {
            Style = style;
            Class = cssClass;
            ID = id;
            Text = text;
        }
    }
}