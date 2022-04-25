using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using NetFramework.Layers.WinApp;

namespace CapaPresentacion
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SplashScreen sp = new SplashScreen();
            if (sp.ShowDialog() == DialogResult.OK)
            {
                Login login = new Login();
                login.Show();
            }
            Application.Run();

        }
    }
}
