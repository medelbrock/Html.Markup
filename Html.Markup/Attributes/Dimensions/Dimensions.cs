namespace Html.Markup
{
    public sealed class Dimensions
    {
        public Dimensions() { }

        public Dimensions(double height, double width) { Height = height; Width = width; }

        public double? Height { get; set; }

        public double? MaxHeight { get; set; }

        public double? MinHeight { get; set; }

        public double? Width { get; set; }

        public double? MaxWidth { get; set; }

        public double? MinWidth { get; set; }

        public MarkupMetric Metric { get; set; }
    }
}