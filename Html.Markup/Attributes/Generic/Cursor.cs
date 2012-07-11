namespace Html.Markup
{
    public sealed class Cursor
    {
        private readonly string _attr;

        private Cursor(string attr)
        {
            _attr = attr;
        }

        public static implicit operator string(Cursor n)
        {
            return n.ToString();
        }

        public override string ToString()
        {
            return _attr;
        }

        public static readonly Cursor Auto = new Cursor("auto");
        public static readonly Cursor Crosshair = new Cursor("crosshair");
        public static readonly Cursor Default = new Cursor("default");
        public static readonly Cursor EResize = new Cursor("e-resize");
        public static readonly Cursor Help = new Cursor("help");
        public static readonly Cursor Move = new Cursor("move");
        public static readonly Cursor NResize = new Cursor("n-resize");
        public static readonly Cursor NEResize = new Cursor("ne-resize");
        public static readonly Cursor NWResize = new Cursor("nw-resize");
        public static readonly Cursor Pointer = new Cursor("pointer");
        public static readonly Cursor Progress = new Cursor("progress");
        public static readonly Cursor SResize = new Cursor("s-resize");
        public static readonly Cursor SEResize = new Cursor("se-resize");
        public static readonly Cursor SWResize = new Cursor("sw-resize");
        public static readonly Cursor Text = new Cursor("text");
        public static readonly Cursor WResize = new Cursor("w-resize");
        public static readonly Cursor Wait = new Cursor("wait");
        public static readonly Cursor Inherit = new Cursor("inherit");
    }
}