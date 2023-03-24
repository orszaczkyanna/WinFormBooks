using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormBooks
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        public static MainForm mainForm = null;
        public static FormBooks formBooks = null;
        public static Database database = new Database();

        public static string globalMessageBoxCaption = "Books";


        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            mainForm = new MainForm();
            formBooks = new FormBooks();
            Application.Run(mainForm);

        }
    }
}
