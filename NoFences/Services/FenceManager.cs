using NoFences.DataModel;

namespace NoFences.Services
{
    internal class FenceManager
    {
        private const string BaseFolderName = "NoFences";
        private const string MetaFolderName = "Metadata";

        private readonly DirectoryInfo baseDir;
        private readonly DirectoryInfo metaDir;

        public FenceManager()
        {
            string strExeFilePath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string portableDir = Path.Combine(strExeFilePath, ".portable");
            
            if (Directory.Exists(portableDir)){
                baseDir = new DirectoryInfo(portableDir);
            }
            else {
                baseDir = new DirectoryInfo(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), BaseFolderName));
            }
            EnsureDirectoryExists(baseDir);

            metaDir = new DirectoryInfo(Path.Combine(baseDir.FullName, MetaFolderName));
            EnsureDirectoryExists(metaDir);
        }

        public List<FenceInfo> LoadAllFences()
        {
            var fences = new List<FenceInfo>();

            foreach (var fenceFile in metaDir.EnumerateFiles("*.xml"))
            {
                var fenceXml = File.ReadAllText(fenceFile.FullName);
                var fence = XmlConverter.Deserialize<FenceInfo>(fenceXml);
                fences.Add(fence);
            }

            return fences;
        }

        public void SaveFence(FenceInfo info)
        {
            var fencePath = GetFenceFileName(info);
            var fenceXml = XmlConverter.Serialize(info);
            File.WriteAllText(fencePath, fenceXml);
        }

        public bool HasFence(Guid fenceId) => File.Exists(GetFenceFileName(fenceId));

        private string GetFenceFileName(FenceInfo info)
             => GetFenceFileName(info.Id);

        private string GetFenceFileName(Guid fenceId)
             => Path.Combine(metaDir.FullName, $"{fenceId}.xml");

        private void EnsureDirectoryExists(DirectoryInfo dir)
        {
            if (!dir.Exists)
                dir.Create();
        }
    }
}
