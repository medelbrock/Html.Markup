namespace Html.Markup
{
    public sealed class Option : Markup
    {
        protected override string Tag { get { return "option"; } }

        public string Value { get; set; }

        public bool Selected { get; set; }

        public Option(string id = null, StyleAttributes style = null, string cssClass = null, string text = null)
            : base()
        {
            Style = style;
            Class = cssClass;
            ID = id;
            Text = text;
        }

        public override string ToString()
        {
            LoadLists();
            if (!string.IsNullOrEmpty(Value))
                AttrList.Add(new AttributePair { Set = "value", Value = Value });
            if (Selected)
                AttrList.Add(new AttributePair { Set = "selected", Value = "selected" });
            return base.ToString();
        }
    }
}