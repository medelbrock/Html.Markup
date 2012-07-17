namespace Html.Markup
{
    public sealed class InputCheckbox : Input
    {
        public bool Checked { get; set; }

        public InputCheckbox()
            : base()
        {
            Type = InputType.Checkbox;
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