namespace Html.Markup
{
    public sealed class InputRadio : Input
    {
        public bool Checked { get; set; }

        public InputRadio()
            : base()
        {
            Type = InputType.Radio;
         
        }
        public override string ToString()
        {
            AttrList.Add(new AttributePair { Set = "type", Value = Type });
            if (!string.IsNullOrEmpty(Value))
                AttrList.Add(new AttributePair { Set = "value", Value = Value });
            if (Checked)
                AttrList.Add(new AttributePair { Set = "checked", Value = "checked" });
            return base.ToString();
        }
    }
}