namespace Html.Markup
{
    public sealed class Form : Markup
    {
        protected override string Tag { get { return "form"; } }
        public string Action { get; set; }
        public string Method { get; set; }
        public string Accept { get; set; }
        public string AcceptCharset { get; set; }
        public EncodedType EncType { get; set; }
        public Form(string id = null, StyleAttributes style = null, string cssClass = null, string text = null)
            : base()
        {
            Style = style;
            Class = cssClass;
            ID = id;
            Text = text;
        }

        public override string ToString()
        {
            if (Action != null)
                AttrList.Add(new AttributePair { Set = "action", Value = Action });
            if (Method != null)
                AttrList.Add(new AttributePair { Set = "method", Value = Method });
            if (Accept != null)
                AttrList.Add(new AttributePair { Set = "accept", Value = Accept });
            if (AcceptCharset != null)
                AttrList.Add(new AttributePair { Set = "accept-charset", Value = AcceptCharset });
            if (EncType != null)
                AttrList.Add(new AttributePair { Set = "enctype", Value = EncType });
            return base.ToString();
        }
    }
}