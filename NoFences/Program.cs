using NoFences.Migration;
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
            LoadFences();
            Application.Run();
        }

        private static void LoadFences()
        {
            new FenceWindow().Show();
        }
    }
}