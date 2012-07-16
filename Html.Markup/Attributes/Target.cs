namespace Html.Markup
{
    public sealed class Target
    {
        private readonly string _attr;

        private Target(string attr)
        {
            _attr = attr;
        }

        public static implicit operator string(Target n)
        {
            return n.ToString();
        }

        public override string ToString()
        {
            return _attr;
        }

        public static readonly Target Blank = new Target("_blank");
        public static readonly Target Self = new Target("_self");
        public static readonly Target Parent = new Target("_parent");
        public static readonly Target Top = new Target("_top");
    }
}