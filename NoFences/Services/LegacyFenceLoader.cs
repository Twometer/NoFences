using NoFences.DataModel.Legacy;

namespace NoFences.Services
{
    internal class LegacyFenceLoader
    {
        private const string BaseFolderName = "NoFences";
        private const string MetaFileName = "__fence_metadata.xml";

        private readonly DirectoryInfo baseDir;

        public LegacyFenceLoader()
        {
            baseDir = new DirectoryInfo(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), BaseFolderName));
        }

        public List<LegacyFenceInfo> LoadAll()
        {
            var fences = new List<LegacyFenceInfo>();
            if (!baseDir.Exists)
                return fences;

            foreach (var fenceDir in baseDir.EnumerateDirectories())
            {
                var fenceInfo = TryLoadFenceInfo(fenceDir);
                if (fenceInfo != null)
                    fences.Add(fenceInfo);
            }
            return fences;
        }

        private LegacyFenceInfo? TryLoadFenceInfo(DirectoryInfo fenceDir)
        {
            var metaFile = new FileInfo(Path.Combine(fenceDir.FullName, MetaFileName));
            if (!metaFile.Exists)
                return null;

            using var reader = new StreamReader(metaFile.FullName);
            return XmlConverter.Deserialize<LegacyFenceInfo>(reader);
        }

    }
}
