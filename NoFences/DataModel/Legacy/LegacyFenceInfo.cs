using System.Xml.Serialization;

namespace NoFences.DataModel.Legacy
{
    [XmlType(TypeName = "FenceInfo")]
    public class LegacyFenceInfo
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public int PosX { get; set; }

        public int PosY { get; set; }

        public int Width { get; set; }

        public int Height { get; set; }

        public bool Locked { get; set; }

        public bool CanMinify { get; set; }

        public int TitleHeight { get; set; } = 35;

        public List<string> Files { get; set; } = new List<string>();
    }
}
