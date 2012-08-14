namespace Html.Markup
{
    public sealed class BorderProperties
    {
        public BorderProperties(double? width = null, LineStyle style = null, string color = null, MarkupMetric metric = null)
        {
            Width = width;
            Style = style;
            Color = color;
            Metric = metric;
        }

        public BorderProperties(double? width = null, LineStyle style = null, string color = null)
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