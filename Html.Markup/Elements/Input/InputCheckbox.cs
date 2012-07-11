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
    }
}