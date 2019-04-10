using Rollbar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienteIntellectus
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            RollbarLocator.RollbarInstance.Configure(new RollbarConfig("fe9f3e0934734bae922fb1cb33fc1d4b"));
            RollbarLocator.RollbarInstance.Info("Rollbar is configured properly.");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Views.Login());
        }
    }
}
