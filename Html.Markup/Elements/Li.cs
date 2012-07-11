namespace Html.Markup
{
    public sealed class Li : Markup
    {
        protected override string Tag { get { return "li"; } }

        public Li(string id = null, StyleAttributes style = null, string cssClass = null, string text = null)
            : base()
        {
            Style = style;
            Class = cssClass;
            ID = id;
            Text = text;
        }
    }
}