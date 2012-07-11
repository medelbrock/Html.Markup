namespace Html.Markup
{
    public sealed class Font
    {
        public string Family { get; set; }

        public double? Size { get; set; }

        public MarkupMetric Metric { get; set; }

        public double? Weight { get; set; }

        public FontStyle Style { get; set; }

        public Font(double? size = null, double? weight = null, FontStyle style = null, MarkupMetric metric = null, string family = null)
        {
            if (size.HasValue)
                Size = size;
            if (weight.HasValue)
                Weight = weight;
            if (style != null)
                Style = style;
            if (metric != null)
                Metric = metric;
            if (!string.IsNullOrEmpty(family))
                Family = family;
        }
    }
}