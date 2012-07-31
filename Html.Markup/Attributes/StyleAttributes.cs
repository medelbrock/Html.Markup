using System.Collections.Generic;

namespace Html.Markup
{
    public class StyleAttributes
    {
        public Font Font { get; set; }

        public Background Background { get; set; }

        public Border Border { get; set; }

        public LineStyle OutlineStyle { get; set; }

        public ListStyle ListStyle { get; set; }

        public Overflow Overflow { get; set; }

        public Dimensions Dimensions { get; set; }

        public Margin Margin { get; set; }

        public Padding Padding { get; set; }

        public Float Float { get; set; }

        public Clear Clear { get; set; }

        public Cursor Cursor { get; set; }

        public Display Display { get; set; }

        public Visibility Visibility { get; set; }

        public Position Position { get; set; }

        public string Color { get; set; }

        public double? LineHeight { get; set; }

        public MarkupMetric LineHeightMetric { get; set; }

        public VerticalAlign VerticalAlign { get; set; }

        public double? Top { get; set; }

        public double? Left { get; set; }

        public double? Right { get; set; }

        public double? Bottom { get; set; }

        public int? ZIndex { get; set; }

        public Text Text { get; set; }

        public List<AttributePair> Collect { get; set; }

        public static implicit operator string(StyleAttributes n) { return n.ToString(); }

        public StyleAttributes() { Collect = new List<AttributePair>(); }

        public override string ToString()
        {
            if (Background != null)
            {
                if (!string.IsNullOrEmpty(Background.Color))
                    Collect.Add(new AttributePair { Set = "background-color", Value = Background.Color });
                if (!string.IsNullOrEmpty(Background.ImageUrl))
                    if (Background.ImageUrl.StartsWith("url("))
                        Collect.Add(new AttributePair { Set = "background-image", Value = Background.ImageUrl });
                    else
                        Collect.Add(new AttributePair { Set = "background-image", Value = string.Format("url({0})", Background.ImageUrl) });
                if (Background.Position != null)
                    Collect.Add(new AttributePair { Set = "background-position", Value = Background.Position.ToString() });
                if (Background.Repeat != null)
                    Collect.Add(new AttributePair { Set = "background-repeat", Value = Background.Repeat.ToString() });
            }
            if (Font != null)
            {
                if (!string.IsNullOrEmpty(Font.Family))
                    Collect.Add(new AttributePair { Set = "font-family", Value = Font.Family });
                if (Font.Size.HasValue)
                    Collect.Add(new AttributePair { Set = "font-size", Value = string.Format("{0}{1}", Font.Size, Font.Metric != null ? Font.Metric : "px") });
                if (Font.Style != null)
                    Collect.Add(new AttributePair { Set = "font-style:", Value = Font.Style.ToString() });
                if (Font.Weight.HasValue)
                    Collect.Add(new AttributePair { Set = "font-weight", Value = Font.Weight.ToString() });
            }
            if (Top.HasValue)
                Collect.Add(new AttributePair { Set = "top", Value = Top.ToString() });
            if (Left.HasValue)
                Collect.Add(new AttributePair { Set = "left", Value = Left.ToString() });
            if (Right.HasValue)
                Collect.Add(new AttributePair { Set = "right", Value = Right.ToString() });
            if (Bottom.HasValue)
                Collect.Add(new AttributePair { Set = "bottom", Value = Bottom.ToString() });
            if (ZIndex.HasValue)
                Collect.Add(new AttributePair { Set = "z-index", Value = ZIndex.ToString() });
            if (Dimensions != null)
            {
                if (Dimensions.Height.HasValue)
                    Collect.Add(new AttributePair { Set = "height", Value = string.Format("{0}{1}", Dimensions.Height, Dimensions.Metric != null ? Dimensions.Metric : "px") });
                if (Dimensions.MaxHeight.HasValue)
                    Collect.Add(new AttributePair { Set = "max-height", Value = string.Format("{0}{1}", Dimensions.MaxHeight, Dimensions.Metric != null ? Dimensions.Metric : "px") });
                if (Dimensions.MinHeight.HasValue)
                    Collect.Add(new AttributePair { Set = "min-height", Value = string.Format("{0}{1}", Dimensions.MinHeight, Dimensions.Metric != null ? Dimensions.Metric : "px") });
                if (Dimensions.Width.HasValue)
                    Collect.Add(new AttributePair { Set = "width", Value = string.Format("{0}{1}", Dimensions.Width, Dimensions.Metric != null ? Dimensions.Metric : "px") });
                if (Dimensions.MaxWidth.HasValue)
                    Collect.Add(new AttributePair { Set = "max-width", Value = string.Format("{0}{1}", Dimensions.MaxWidth, Dimensions.Metric != null ? Dimensions.Metric : "px") });
                if (Dimensions.MinWidth.HasValue)
                    Collect.Add(new AttributePair { Set = "min-width", Value = string.Format("{0}{1}", Dimensions.MinWidth, Dimensions.Metric != null ? Dimensions.Metric : "px") });
            }
            if (VerticalAlign != null)
                Collect.Add(new AttributePair { Set = "vertical-align", Value = VerticalAlign.ToString() });
            if (Border != null)
            {
                if (Border.Top != null && Border.Top.Width.HasValue)
                    Collect.Add(new AttributePair { Set = "border-top", Value = string.Format("{0}{3} {1} {2}", Border.Top.Width, Border.Top.Color, Border.Top.Style, Border.Top.Metric) });
                if (Border.Left != null && Border.Left.Width.HasValue)
                    Collect.Add(new AttributePair { Set = "border-left", Value = string.Format("{0}{3} {1} {2}", Border.Left.Width, Border.Left.Color, Border.Left.Style, Border.Left.Metric) });
                if (Border.Right != null && Border.Right.Width.HasValue)
                    Collect.Add(new AttributePair { Set = "border-right", Value = string.Format("{0}{3} {1} {2}", Border.Right.Width, Border.Right.Color, Border.Right.Style, Border.Right.Metric) });
                if (Border.Bottom != null && Border.Bottom.Width.HasValue)
                    Collect.Add(new AttributePair { Set = "border-bottom", Value = string.Format("{0}{3} {1} {2}", Border.Bottom.Width, Border.Bottom.Color, Border.Bottom.Style, Border.Bottom.Metric) });
                if (Border.All != null && Border.All.Width.HasValue)
                    Collect.Add(new AttributePair { Set = "border", Value = string.Format("{0}{3} {1} {2}", Border.All.Width, Border.All.Color, Border.All.Style, Border.All.Metric) });
            }
            if (OutlineStyle != null)
                Collect.Add(new AttributePair { Set = "outline", Value = OutlineStyle.ToString() });
            if (ListStyle != null)
            {
                if (ListStyle.Position != null)
                    Collect.Add(new AttributePair { Set = "list-style-position", Value = ListStyle.Position });
                if (ListStyle.Type != null)
                    Collect.Add(new AttributePair { Set = "list-style-type", Value = ListStyle.Type });
                if (!string.IsNullOrEmpty(ListStyle.Image))
                    Collect.Add(new AttributePair { Set = "list-style-image", Value = ListStyle.Image });
            }
            if (Overflow != null)
            {
                if (Overflow.X != null)
                    Collect.Add(new AttributePair { Set = "overflow-x", Value = Overflow.X.ToString() });
                if (Overflow.Y != null)
                    Collect.Add(new AttributePair { Set = "overflow-y", Value = Overflow.Y.ToString() });
            }
            if (Margin != null)
            {
                if (Margin.Top.HasValue)
                    Collect.Add(new AttributePair { Set = "margin-top", Value = string.Format("{0}{1}", Margin.Top, Margin.Metric != null ? Margin.Metric : "px") });
                if (Margin.Right.HasValue)
                    Collect.Add(new AttributePair { Set = "margin-right", Value = string.Format("{0}{1}", Margin.Right, Margin.Metric != null ? Margin.Metric : "px") });
                if (Margin.Left.HasValue)
                    Collect.Add(new AttributePair { Set = "margin-left", Value = string.Format("{0}{1}", Margin.Left, Margin.Metric != null ? Margin.Metric : "px") });
                if (Margin.Bottom.HasValue)
                    Collect.Add(new AttributePair { Set = "margin-bottom", Value = string.Format("{0}{1}", Margin.Bottom, Margin.Metric != null ? Margin.Metric : "px") });
                if (Margin.All.HasValue)
                    Collect.Add(new AttributePair { Set = "margin", Value = string.Format("{0}{1}", Margin.All, Margin.Metric != null ? Margin.Metric : "px") });
            }
            if (Padding != null)
            {
                if (Padding.Top.HasValue)
                    Collect.Add(new AttributePair { Set = "padding-top", Value = string.Format("{0}{1}", Padding.Top, Padding.Metric != null ? Padding.Metric : "px") });
                if (Padding.Right.HasValue)
                    Collect.Add(new AttributePair { Set = "padding-right", Value = string.Format("{0}{1}", Padding.Right, Padding.Metric != null ? Padding.Metric : "px") });
                if (Padding.Left.HasValue)
                    Collect.Add(new AttributePair { Set = "padding-left", Value = string.Format("{0}{1}", Padding.Left, Padding.Metric != null ? Padding.Metric : "px") });
                if (Padding.Bottom.HasValue)
                    Collect.Add(new AttributePair { Set = "padding-bottom", Value = string.Format("{0}{1}", Padding.Bottom, Padding.Metric != null ? Padding.Metric : "px") });
                if (Padding.All.HasValue)
                    Collect.Add(new AttributePair { Set = "padding", Value = string.Format("{0}{1}", Padding.All, Padding.Metric != null ? Padding.Metric : "px") });
            }
            if (Float != null)
                Collect.Add(new AttributePair { Set = "float", Value = Float });
            if (Clear != null)
                Collect.Add(new AttributePair { Set = "clear", Value = Clear });
            if (Cursor != null)
                Collect.Add(new AttributePair { Set = "cursor", Value = Cursor });
            if (Display != null)
                Collect.Add(new AttributePair { Set = "display", Value = Display });
            if (Position != null)            
                Collect.Add(new AttributePair { Set = "position", Value = Position });            
            if (LineHeight.HasValue)
                Collect.Add(new AttributePair { Set = "line-height", Value = string.Format("{0}{1}", LineHeight, LineHeightMetric != null ? LineHeightMetric : "px") });
            if (Text != null)
            {
                if (Text.Align != null)
                    Collect.Add(new AttributePair { Set = "text-align", Value = Text.Align });
                if (Text.Decoration != null)
                    Collect.Add(new AttributePair { Set = "text-decoration", Value = Text.Decoration });
            }
            if (!string.IsNullOrEmpty(Color))
                Collect.Add(new AttributePair { Set = "color", Value = Color });
            List<string> l = new List<string>();
            Collect.ForEach(x => l.Add(string.Format(x.Set + ":" + x.Value)));
            return string.Join(";", l.ToArray());
        }
    }
}