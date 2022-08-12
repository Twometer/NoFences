namespace NoFences.DataModel
{
    public class FenceOptions
    {
        public string Title { get; set; } = "New Fence";

        public bool Locked { get; set; } = false;

        public bool Minify { get; set; } = false;

        public bool Animated { get; set; } = false;

        public int TitleHeight { get; set; } = 32;

        public Color TitleColor { get; set; } = Color.White;

        public FontFamily TitleFont { get; set; } = new FontFamily("Segoe UI");

        public int IconSize { get; set; } = 32;

        public double Opacity { get; set; } = 1.0;

        public Color BackgroundColor { get; set; } = Color.FromArgb(64, 0, 0, 0);
    }
}
