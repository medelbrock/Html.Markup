namespace Html.Markup
{
    public sealed class ParsedHtml : Markup
    {
        private string _html;

        public ParsedHtml(string html)
        {
            _html = html;
        }

        public override string ToString()
        {
            return _html;
        }
    }
}