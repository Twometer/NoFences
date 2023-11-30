using NoFences.Model;
using System;
using System.Threading;
using System.Windows.Forms;
using NoFences.Win32;

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
            //allows the context menu to be in dark mode
            //inherits from the system settings
            WindowUtil.SetPreferredAppMode(1);

            using (var mutex = new Mutex(true, "No_fences", out var createdNew))
            {
                if (createdNew)
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);

                    FenceManager.Instance.LoadFences();
                    if (Application.OpenForms.Count == 0)
                        FenceManager.Instance.CreateFence("First fence");

                    Application.Run();
                }
            }
        }

    }
}
