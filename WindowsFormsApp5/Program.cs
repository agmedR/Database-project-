using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp5.screens.exports;
using WindowsFormsApp5.screens.imports;
using WindowsFormsApp5.screens.login;
using WindowsFormsApp5.screens.pharmacies;
using WindowsFormsApp5.screens.product;
using WindowsFormsApp5.screens.suppliers;
using WindowsFormsApp5.screens.users;
using WindowsFormsApp5.screens.warning;

namespace WindowsFormsApp5
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
            Application.Run(new Login());
        }
    }
}
