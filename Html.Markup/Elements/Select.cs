namespace Html.Markup
{
    public sealed class Select : Markup
    {
        protected override string Tag { get { return "select"; } }

        public Select(string id = null, StyleAttributes style = null, string cssClass = null, string text = null)
            : base()
        {
            Style = style;
            Class = cssClass;
            ID = id;
            Text = text;
        }
    }
}