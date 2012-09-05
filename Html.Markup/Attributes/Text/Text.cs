namespace Html.Markup
{
    public sealed class Text
    {
        public Text(Align align = null, Decoration decoration = null)
        {
            Align = align;
            Decoration = decoration;
        }
        public Align Align { get; set; }

        public Decoration Decoration { get; set; }
    }
}