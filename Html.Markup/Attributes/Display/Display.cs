namespace Html.Markup
{
    public sealed class Display
    {
        private readonly string _attr;

        private Display(string attr)
        {
            _attr = attr;
        }

        public static implicit operator string(Display n)
        {
            return n.ToString();
        }

        public override string ToString()
        {
            return _attr;
        }

        public static readonly Display None = new Display("none");
        public static readonly Display Block = new Display("block");
        public static readonly Display Inline = new Display("inline");
        public static readonly Display InlineBlock = new Display("inline-block");
        public static readonly Display ListItem = new Display("list-item");
        public static readonly Display RunIn = new Display("run-in");
        public static readonly Display Table = new Display("table");
        public static readonly Display TableCaption = new Display("table-caption");
        public static readonly Display TableCell = new Display("table-cell");
        public static readonly Display TableColumn = new Display("table-column");
        public static readonly Display TableColumnGroup = new Display("table-column-group");
        public static readonly Display TableFooterGroup = new Display("table-footer-group");
        public static readonly Display TableHeaderGroup = new Display("table-header-group");
        public static readonly Display TableRow = new Display("table-row");
        public static readonly Display TableRowGroup = new Display("table-row-group");
        public static readonly Display Inherit = new Display("inherit");
    }
}