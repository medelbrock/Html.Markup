namespace Html.Markup
{
    public class Input : Markup
    {
        public InputType Type { get; set; }

        protected override string Tag { get { return "input"; } }

        public string Value { get; set; }

        public Input(string id = null, StyleAttributes style = null, string cssClass = null, string text = null)
            : base()
        {
            Style = style;
            Class = cssClass;
            ID = id;
            Text = text;
        }

        public override string ToString()
        {
            AttrList.Add(new AttributePair { Set = "type", Value = Type });
            if (!string.IsNullOrEmpty(Value))
                AttrList.Add(new AttributePair { Set = "value", Value = Value });
            return base.ToString();
        }
    }
}