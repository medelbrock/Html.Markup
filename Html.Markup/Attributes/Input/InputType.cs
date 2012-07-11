namespace Html.Markup
{
    public sealed class InputType
    {
        private readonly string _attr;

        private InputType(string attr)
        {
            _attr = attr;
        }

        public static implicit operator string(InputType n)
        {
            return n.ToString();
        }

        public override string ToString()
        {
            return _attr;
        }

        public static readonly InputType Text = new InputType("text");
        public static readonly InputType Radio = new InputType("radio");
        public static readonly InputType Checkbox = new InputType("checkbox");
        public static readonly InputType Submit = new InputType("submit");
        public static readonly InputType Hidden = new InputType("hidden");
        public static readonly InputType Button = new InputType("button");
    }
}