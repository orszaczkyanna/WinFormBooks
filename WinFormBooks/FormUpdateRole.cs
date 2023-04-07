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

        // Kiválasztott felhasználó adatai
        string selectedUserId;
        string selectedUserName;
        string selectedUserRole;
        int selectedRoleIndex;

        public FormUpdateRole()
        {
            InitializeComponent();
        }

        private void FormUpdateRole_Load(object sender, EventArgs e)
        {
            cmbRoleUp.Items.AddRange(new string[] { "admin", "felhasználó" });
            cmbRoleUp.Focus();
            LoadSelectedUserData();
        }

        private void LoadSelectedUserData()
        {
            // Kiválasztott felhasználó adatainak kiolvasása
            DataGridViewRow selectedRow = Program.mainForm.dgvUsers.SelectedRows[0];;
            selectedUserId = selectedRow.Cells["id"].Value.ToString();
            selectedUserName = selectedRow.Cells["username"].Value.ToString();
            selectedUserRole = selectedRow.Cells["role"].Value.ToString();
            selectedRoleIndex = SelectedRoleIndex(selectedUserRole);

            // Adatok megjelenítése
            tbUsernameUp.Text = selectedUserName;
            cmbRoleUp.SelectedIndex = selectedRoleIndex;

        }

        // A kiválasztott jogosultság értéke alapján visszaadja a megfelelő indexet
        private int SelectedRoleIndex(string selectedUserRole)
        {
            if (selectedUserRole == "admin")
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Módosított jogosultság
            int updatedRoleIndex = cmbRoleUp.SelectedIndex;


            // Feltétel vizsgálat: módosult-e a kiválasztott felhasználó jogosultsága?
            // Ha igen, a módosítás történjen meg
            if (selectedRoleIndex == updatedRoleIndex)
            {
                BooksMessageBox.Warning("Nem történt módosítás!");
            }
            else
            {
                string updatedRoleToSend = RenameRoleValue(updatedRoleIndex, "admin", "user");
                User updatedUser = new User(Convert.ToUInt32(selectedUserId), selectedUserName, updatedRoleToSend);
                Program.database.UpdateRole(updatedUser);
                Program.mainForm.DataGridViewUpdateSearch();
                this.Close();
            }


        }

        // Jogosultság megnevezésének átalakítása, hogy megfelelő értéket küldjön az adatbázisnak
        private string RenameRoleValue(int index, string v1, string v2)
        {
            if (index == 0)
            {
                return v1;
            }
            else
            {
                return v2;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
