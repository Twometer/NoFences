using NoFences.Services;
using NoFences.Windows;

namespace NoFences
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using var mutex = new Mutex(true, "NoFences", out var createdNew);
            if (!createdNew) return;

            ApplicationConfiguration.Initialize();
            MigrateFences();
            InitializeFences();
            Application.Run();
        }

        private static void InitializeFences()
        {
            new FenceWindow().Show();
        }

        private static void MigrateFences()
        {
            var legacyManager = new LegacyFenceManager();
            var legacyFences = legacyManager.LoadAll();
            if (legacyFences.Count == 0) return;

            if (MessageBox.Show($"NoFences found {legacyFences.Count} fence definitions from v1.x. Should they be migrated now?", "Fence migration", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var manager = new FenceManager();
                foreach (var fence in legacyFences)
                {
                    manager.SaveFence(FenceMigrator.Migrate(fence));
                    legacyManager.Delete(fence);
                }
            }
        }
    }
}