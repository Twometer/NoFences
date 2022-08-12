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

            var appContext = new AppContext();
            MigrateFences(appContext);
            InitializeFences();
            Application.Run();
        }

        private static void InitializeFences()
        {
            new FenceWindow().Show();
        }

        private static void MigrateFences(AppContext ctx)
        {
            var legacyFences = ctx.LegacyFenceManager.LoadAllFences();
            if (legacyFences.Count == 0) return;

            if (MessageBox.Show($"NoFences found {legacyFences.Count} fence definitions from v1.x. Should they be migrated now?", "Fence migration", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                foreach (var fence in legacyFences)
                {
                    ctx.FenceManager.SaveFence(FenceMigrator.Migrate(fence));
                    ctx.LegacyFenceManager.DeleteFence(fence);
                }
            }
        }
    }
}