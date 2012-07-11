namespace Html.Markup
{
    public sealed class Padding
    {
        public Padding() { }

        public Padding(double? all)
        {
            All = all;
        }

        public Padding(double? top, double? right)
        {
            Top = top;
            Right = right;
            Left = right;
            Bottom = right;
        }

        public Padding(double? top, double? right, double? bottom)
        {
            Top = top;
            Right = right;
            Bottom = bottom;
            Left = bottom;
        }

        public Padding(double? top, double? right, double? bottom, double? left)
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

        public static readonly Padding None = new Padding { Top = 0, Left = 0, Bottom = 0, Right = 0 };
    }
}