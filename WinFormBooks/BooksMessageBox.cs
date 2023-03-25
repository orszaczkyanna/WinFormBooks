using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormBooks
{
    public class BooksMessageBox
    {
        //static string MessageBoxCaption = "BooksMessageBox";

        public static void Information(string message)
        {
            MessageBox.Show(message, "Sikeres végrehajtás", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void Error(string message)
        {
            MessageBox.Show(message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void Warning(string message)
        {
            MessageBox.Show(message, "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void WarningNoSelected(string v)
        {
            MessageBox.Show($"Nincs kiválasztott {v}!", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        internal static DialogResult YesNo(string v)
        {
            return MessageBox.Show($"Biztosan törli {v}?", "Megerősítés", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        }
    }
}
