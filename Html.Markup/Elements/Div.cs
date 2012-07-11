namespace Html.Markup
{
    public sealed class Div : Markup
    {
        protected override string Tag { get { return "div"; } }

        public Div(string id = null, StyleAttributes style = null, string cssClass = null, string text = null)
            : base()
        {
            Style = style;
            Class = cssClass;
            ID = id;
            Text = text;
        }
    }
}