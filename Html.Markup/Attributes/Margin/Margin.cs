namespace Html.Markup
{
    public sealed class Margin
    {
        public Margin() { }

        public Margin(double? all) { All = all; }

        public Margin(double? top = null, double? right = null, double? bottom = null, double? left = null)
        {
            Top = top;
            Right = right;
            Bottom = bottom;
            Left = left;
        }

        public MarkupMetric Metric { get; set; }

        public double? Top { get; set; }

        public double? Bottom { get; set; }

        public double? Left { get; set; }

        public double? Right { get; set; }

        public double? All { get; set; }

        public static readonly Margin None = new Margin { Top = 0, Left = 0, Bottom = 0, Right = 0 };
    }
}