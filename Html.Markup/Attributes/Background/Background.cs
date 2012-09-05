namespace Html.Markup
{
    public sealed class Background
    {
        public Background(string color = null, string imageurl = null, Coordinate position = null, BackgroundRepeat repeat = null)
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