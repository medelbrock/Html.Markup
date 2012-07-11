using System;

namespace Html.Markup
{
    public sealed class Coordinate
    {
        private string X { get; set; }

        private string Y { get; set; }

        public static implicit operator string(Coordinate n)
        {
            return n.ToString();
        }

        public override string ToString()
        {
            return String.Format("{0} {1}", X, Y);
        }

        public Coordinate(double x, double y)
        {
            X = x + "px";
            Y = y + "px";
        }

        public Coordinate(string x, string y)
        {
            X = x + "px";
            Y = y + "px";
        }
    }
}