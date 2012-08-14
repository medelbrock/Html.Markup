namespace Html.Markup
{
    public sealed class Border
    {
        public Border(BorderProperties top = null, BorderProperties left = null, BorderProperties right = null, BorderProperties bottom = null, BorderProperties all = null)
        {
            if (all != null)
                All = all;
            if (all == null)
            {
                Top = top;
                Left = left;
                Right = right;
                Bottom = bottom;
            }
        }
        public BorderProperties Top { get; set; }

        public BorderProperties Left { get; set; }

        public BorderProperties Right { get; set; }

        public BorderProperties Bottom { get; set; }

        public BorderProperties All { get; set; }
    }
}