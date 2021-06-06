using BTL_PTUD.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BTL_PTUD {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainTeacherForm("TC1", @"Data Source=DESKTOP-S4GU3GQ\SQLEXPRESS;Initial Catalog=phanmemthi;Integrated Security=SSPI"));
        }

        // wt áđấ
    }
}
