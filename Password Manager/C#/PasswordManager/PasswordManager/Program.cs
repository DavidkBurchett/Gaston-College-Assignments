using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text;
using System.Data;
using System.IO;
using System.Data.SQLite;
using System.Threading.Tasks;

namespace PasswordManager
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// most logic is in Form1
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

        }
    }
}