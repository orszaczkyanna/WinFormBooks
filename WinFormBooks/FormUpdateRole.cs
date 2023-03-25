using K4os.Compression.LZ4.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormBooks
{
    public partial class FormUpdateRole : Form
    {
        public FormUpdateRole()
        {
            InitializeComponent();
        }

        private void FormUpdateRole_Load(object sender, EventArgs e)
        {
            cmbRoleUp.Items.AddRange(new string[] { "admin", "felhasználó" });
            cmbRoleUp.Focus();

            // Kiválasztott felhasználó adatainak megjelenítése
            LoadSelectedUserData();
        }

        private void LoadSelectedUserData()
        {
            DataGridViewRow selectedRow = Program.mainForm.dgvUsers.SelectedRows[0];
            string selectedUserRole = selectedRow.Cells["role"].Value.ToString();
            string selectedUserName = selectedRow.Cells["username"].Value.ToString();

            tbUsernameUp.Text = selectedUserName;
            if (selectedUserRole == "admin")
            {
                cmbRoleUp.SelectedIndex = 0;
            }
            else
            {
                cmbRoleUp.SelectedIndex = 1;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // A módosításhoz szükséges adatok
            DataGridViewRow selectedRow = Program.mainForm.dgvUsers.SelectedRows[0];
            string selectedUserId = selectedRow.Cells["id"].Value.ToString();
            string selectedUserRole = selectedRow.Cells["role"].Value.ToString();
            int updatedRoleIndex = cmbRoleUp.SelectedIndex;
            string updatedRoleToSend;

            // Jogosultság megnevezésének átalakítása, hogy megfelelő értéket küldjön az adatbázisnak
            if (updatedRoleIndex == 0)
            {
                updatedRoleToSend = "admin";
            }
            else
            {
                updatedRoleToSend = "user";
            }


            // Megnevezés átalakítása, hogy az eredeti és a módosított jogosultság összehasonlítható legyen
            if (selectedUserRole.Equals("felhasználó"))
            {
                selectedUserRole = "user";
            }

            // Feltétel vizsgálat: módosult - e a kiválasztott felhasználó jogosultsága?
            // Ha igen, a módosítás történjen meg
            if (selectedUserRole.Equals(updatedRoleToSend))
            {
                BooksMessageBox.Warning("Nem történt módosítás!");
            }
            else
            {
                Program.database.UpdateRole(updatedRoleToSend, selectedUserId);
                Program.mainForm.DataGridViewUpdateSearch();
                this.Close();
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
