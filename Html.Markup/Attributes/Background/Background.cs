namespace Html.Markup
{
    public sealed class Background
    {
        public Background() { }

        public Background(string color)
        {
            Color = color;
        }

        public Background(string color, string imageurl)
        {
            Color = color;
            ImageUrl = imageurl;
        }

        public Background(string color, string imageurl, Coordinate position)
        {
            Color = color;
            ImageUrl = imageurl;
            Position = position;
        }

        public Background(string color, string imageurl, Coordinate position, BackgroundRepeat repeat)
        {
            Color = color;
            ImageUrl = imageurl;
            Position = position;
            Repeat = repeat;
        }

        public string ImageUrl { get; set; }

        public string Color { get; set; }

        public Coordinate Position { get; set; }

        public BackgroundRepeat Repeat { get; set; }
    }
}