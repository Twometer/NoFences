namespace NoFences.DataModel
{
    public class FenceInfo
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public Point Location { get; set; } = new Point(100, 250);

        public Size Size { get; set; } = new Size(300, 300);

        public FenceOptions Options { get; set; } = new FenceOptions();

        public FenceMode Mode { get; set; } = FenceMode.ShortcutBased;

        public List<string> Paths { get; set; } = new List<string>(); 
    }
}
