namespace Html.Markup
{
    public sealed class MarkupMetric
    {
        private readonly string _attr;

        private MarkupMetric(string attr)
        {
            _attr = attr;
        }

        public static implicit operator string(MarkupMetric m)
        {
            return m.ToString();
        }

        public override string ToString()
        {
            return _attr;
        }

        public static readonly MarkupMetric Pixels = new MarkupMetric("px");
        public static readonly MarkupMetric Percent = new MarkupMetric("%");
        public static readonly MarkupMetric Em = new MarkupMetric("em");
        public static readonly MarkupMetric Points = new MarkupMetric("pt");
        public static readonly MarkupMetric Number = new MarkupMetric(string.Empty);
    }
}