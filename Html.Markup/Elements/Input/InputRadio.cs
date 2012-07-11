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
    }
}