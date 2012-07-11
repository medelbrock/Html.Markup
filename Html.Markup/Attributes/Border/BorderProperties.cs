namespace Html.Markup
{
    public sealed class BorderProperties
    {
        public BorderProperties() { }

        public BorderProperties(double? width, LineStyle style, string color, MarkupMetric metric)
        {
            Width = width;
            Style = style;
            Color = color;
            Metric = metric;
        }

        public BorderProperties(double? width, LineStyle style, string color)
        {
            Metric = MarkupMetric.Pixels;
            Width = width;
            Style = style;
            Color = color;
        }

        public double? Width { get; set; }

        public LineStyle Style { get; set; }

        public string Color { get; set; }

        public MarkupMetric Metric { get; set; }
    }
}