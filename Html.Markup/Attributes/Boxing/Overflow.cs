namespace Html.Markup
{
    public sealed class Overflow
    {
        public ContentFlow X { get; set; }

        public ContentFlow Y { get; set; }

        public Overflow() { }

        public Overflow(ContentFlow set)
        {
            if (set != null)
            {
                X = set;
                Y = set;
            }
        }
    }
}