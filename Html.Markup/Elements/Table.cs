namespace Html.Markup
{
    public sealed class Table : Markup
    {
        protected override string Tag { get { return "table"; } }

        public Table(string id = null, StyleAttributes style = null, string cssClass = null, string text = null)
            : base()
        {
            Style = style;
            Class = cssClass;
            ID = id;
            Text = text;
        }
    }
}