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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // --- cmbFilter ComboBox elemeinek megadása ---
            cmbFilter.Items.AddRange(new string[] { "mind", "admin", "felhasználó" });
            cmbFilter.SelectedIndex = 0;

            // --- dgvUsers DataGridView ---
            DataGridViewCreate(); // Táblázat megrajzolása
            //DataGridViewUpdate(Program.database.UsersList());
            DataGridViewUpdate(Program.database.SelectedUsersList(tbSearch.Text, SelectedRole())); // Táblázat feltöltése/adatok frissítése

        }



        private void DataGridViewCreate()
        {
            // Táblázat tulajdonságai
            dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsers.MultiSelect = false;

            // Oszlopok tulajdonságai
            // 1. oszlop - ID
            DataGridViewColumn colId = new DataGridViewColumn();
            {
                colId.Name = "id";
                colId.HeaderText = "id";
                colId.CellTemplate = new DataGridViewTextBoxCell();
                colId.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                colId.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
            dgvUsers.Columns.Add(colId);


            // 2. oszlop - username
            DataGridViewColumn colUsername = new DataGridViewColumn();
            {
                colUsername.Name = "username";
                colUsername.HeaderText = "Felhasználónév";
                colUsername.CellTemplate = new DataGridViewTextBoxCell();
            }
            dgvUsers.Columns.Add(colUsername);

            // 3. oszlop - role
            DataGridViewColumn colRole = new DataGridViewColumn();
            {
                colRole.Name = "role";
                colRole.HeaderText = "Jogosultság";
                colRole.CellTemplate = new DataGridViewTextBoxCell();
            }
            dgvUsers.Columns.Add(colRole);
        }

        //private void DataGridViewUpdate()
        //{
        //    dgvUsers.Rows.Clear();
        //    foreach (User user in Program.database.UsersList())
        //    {
        //        int index = dgvUsers.Rows.Add();
        //        DataGridViewRow newRow = dgvUsers.Rows[index];

        //        newRow.Cells["id"].Value = user.Id;
        //        newRow.Cells["username"].Value = user.Username;
        //        newRow.Cells["role"].Value = user.Role;
        //    }
        //}

        private void DataGridViewUpdate(List<User> UsersList)
        {
            dgvUsers.Rows.Clear();
            foreach (User user in UsersList)
            {
                int index = dgvUsers.Rows.Add();
                DataGridViewRow newRow = dgvUsers.Rows[index];

                newRow.Cells["id"].Value = user.Id;
                newRow.Cells["username"].Value = user.Username;
                newRow.Cells["role"].Value = user.Role;
            }
        }


        private string SelectedRole()
        {
            switch (cmbFilter.SelectedIndex)
            {
                case 1:
                    return "admin";
                    //break;
                case 2:
                    return "user";
                    //break;
                default:
                    return string.Empty;
                    //break;
            }
        }

        private void dgvUsers_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.dgvUsers.Sort(this.dgvUsers.Columns[e.ColumnIndex], ListSortDirection.Ascending);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataGridViewUpdate(Program.database.SelectedUsersList(tbSearch.Text, SelectedRole()));
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
