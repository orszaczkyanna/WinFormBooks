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
            // Táblázat megrajzolása
            DataGridViewCreate();


            // Táblázat feltöltése/adatok frissítése
            //DataGridViewUpdate(Program.database.UsersList());
            //DataGridViewUpdate(Program.database.SelectedUsersList(tbSearch.Text, SelectedRole()));
            DataGridViewUpdatePublic();

        }



        private void DataGridViewCreate()
        {
            // Táblázat tulajdonságai
            dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsers.MultiSelect = false;
            dgvUsers.RowTemplate.Height = 45; // sormagasság
            dgvUsers.RowHeadersWidth = 30; // sor header szélesség
            //dgvUsers.ColumnHeadersDefaultCellStyle.Font = new Font(this.Font, FontStyle.Bold); // félkövér fejléc

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

        /*private void DataGridViewUpdate()
        {
            dgvUsers.Rows.Clear();
            foreach (User user in Program.database.UsersList())
            {
                int index = dgvUsers.Rows.Add();
                DataGridViewRow newRow = dgvUsers.Rows[index];

                newRow.Cells["id"].Value = user.Id;
                newRow.Cells["username"].Value = user.Username;
                newRow.Cells["role"].Value = user.Role;
            }
        }
        */

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

        public void DataGridViewUpdatePublic()
        {
            string usernameSearch = tbSearch.Text;
            string roleSearch = SelectedRole();
            List<User> UsersList = Program.database.SelectedUsersList(usernameSearch, roleSearch);
            DataGridViewUpdate(UsersList);
        }


        private void dgvUsers_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.dgvUsers.Sort(this.dgvUsers.Columns[e.ColumnIndex], ListSortDirection.Ascending);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataGridViewUpdatePublic();
        }

        private void tbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch.PerformClick();
            }
        }

        private void cmbFilter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch.PerformClick();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            tbSearch.Text = string.Empty;
            cmbFilter.SelectedIndex = 0;
            List<User> UsersList = Program.database.SelectedUsersList(tbSearch.Text, string.Empty);
            DataGridViewUpdate(UsersList);
        }

        private void btnInsertUser_Click(object sender, EventArgs e)
        {
            FormInsertUser formInsertUser = new FormInsertUser();
            formInsertUser.ShowDialog();
        }

        private void btnUpdateRole_Click(object sender, EventArgs e)
        {

            if (dgvUsers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nincs kiválasztott felhasználó!", Program.globalMessageBoxCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                FormUpdateRole formUpdateRole = new FormUpdateRole();
                formUpdateRole.ShowDialog();
            }
            

        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nincs kiválasztott felhasználó!", Program.globalMessageBoxCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                
                DialogResult result = MessageBox.Show("Biztosan törli a felhasználót?", Program.globalMessageBoxCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result.Equals(DialogResult.Yes))
                {
                    DataGridViewRow selectedRow = dgvUsers.SelectedRows[0];
                    string selectedUsersId = selectedRow.Cells["id"].Value.ToString();
                    Program.database.DeleteUser(selectedUsersId);
                    DataGridViewUpdatePublic();
                }

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
