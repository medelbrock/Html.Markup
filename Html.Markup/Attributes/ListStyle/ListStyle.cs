namespace Html.Markup
{
    public sealed class ListStyle
    {
        public string Image { get; set; }

        public ListPosition Position { get; set; }

        public ListStyleType Type { get; set; }

        public static readonly ListStyle None = new ListStyle { Type = ListStyleType.None };
    }
}