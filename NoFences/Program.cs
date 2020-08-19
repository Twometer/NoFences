using System;
using System.Threading;
using System.Windows.Forms;

namespace NoFences
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (var mutex = new Mutex(true, "No_fences", out var createdNew))
            {
                if (createdNew)
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    new FenceWindow().Show();
                    Application.Run();
                }
            }
        }

    }
}
