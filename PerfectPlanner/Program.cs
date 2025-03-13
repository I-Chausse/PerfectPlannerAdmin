using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PerfectPlanner
{
    static class Program
    {
        public static CustomApplicationContext AppContext;
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmLogin loginForm = new frmLogin();
            AppContext = new CustomApplicationContext(loginForm);
            Application.Run(AppContext);
        }
    }
}
