namespace Html.Markup
{
    public sealed class BackgroundRepeat
    {
        private readonly string _attr;

        private BackgroundRepeat(string attr)
        {
            _attr = attr;
        }

        public static implicit operator string(BackgroundRepeat n)
        {
            return n.ToString();
        }

        public override string ToString()
        {
            return _attr;
        }

        public static readonly BackgroundRepeat RepeatX = new BackgroundRepeat("repeat-x");
        public static readonly BackgroundRepeat RepeatY = new BackgroundRepeat("repeat-y");
        public static readonly BackgroundRepeat NoRepeat = new BackgroundRepeat("no-repeat");
        public static readonly BackgroundRepeat Repeat = new BackgroundRepeat("repeat");
        public static readonly BackgroundRepeat Inherit = new BackgroundRepeat("inherit");
    }
}