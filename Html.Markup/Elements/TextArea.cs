namespace Html.Markup
{
    public sealed class TextArea : Markup
    {
        protected override string Tag { get { return "textarea"; } }

        public TextArea(string id = null, StyleAttributes style = null, string cssClass = null, string text = null)
            : base()
        {
            Style = style;
            Class = cssClass;
            ID = id;
            Text = text;
        }
    }
}