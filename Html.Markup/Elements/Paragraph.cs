namespace Html.Markup
{
    public sealed class Paragraph : Markup
    {
        protected override string Tag { get { return "p"; } }

        public Paragraph(string id = null, StyleAttributes style = null, string cssClass = null, string text = null)
            : base()
        {
            Style = style;
            Class = cssClass;
            ID = id;
            Text = text;
        }
    }
}