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
            DataGridViewUpdateSearch(); // Táblázat feltöltése/adatok frissítése

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
                colId.SortMode = DataGridViewColumnSortMode.Automatic;
            }
            dgvUsers.Columns.Add(colId);


            // 2. oszlop - username
            DataGridViewColumn colUsername = new DataGridViewColumn();
            {
                colUsername.Name = "username";
                colUsername.HeaderText = "Felhasználónév";
                colUsername.CellTemplate = new DataGridViewTextBoxCell();
                colUsername.SortMode = DataGridViewColumnSortMode.Automatic;
            }
            dgvUsers.Columns.Add(colUsername);

            // 3. oszlop - role
            DataGridViewColumn colRole = new DataGridViewColumn();
            {
                colRole.Name = "role";
                colRole.HeaderText = "Jogosultság";
                colRole.CellTemplate = new DataGridViewTextBoxCell();
                colRole.SortMode = DataGridViewColumnSortMode.Automatic;
            }
            dgvUsers.Columns.Add(colRole);
        }

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


        public void DataGridViewUpdateSearch()
        {
            string usernameSearch = tbSearch.Text;
            string roleFilter = ComboBoxSelectedItem(cmbFilter.SelectedIndex, "admin", "user");

            List<User> usersList = Program.database.SelectedUsersList(usernameSearch, roleFilter);
            DataGridViewUpdate(usersList);
        }


        //private void dgvUsers_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        //{
        //    this.dgvUsers.Sort(this.dgvUsers.Columns[e.ColumnIndex], ListSortDirection.Ascending);
        //}

        // Felhasználó(k) keresése keresés gombbal, vagy enterrel
        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataGridViewUpdateSearch();
        }

        private void tbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            EnterSearch(btnSearch, e);
        }

        private void cmbFilter_KeyDown(object sender, KeyEventArgs e)
        {
            EnterSearch(btnSearch, e);
        }


        // Táblázat tartalmának frissítése: töltse be az összes felhasználót
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            tbSearch.Text = string.Empty;
            cmbFilter.SelectedIndex = 0;
            DataGridViewUpdateSearch();
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
                BooksMessageBox.Warning("Nincs kiválasztott felhasználó!");
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
                BooksMessageBox.Warning("Nincs kiválasztott felhasználó!");
            }
            else
            {
                DialogResult result = BooksMessageBox.YesNo("a felhasználót");
                if (result.Equals(DialogResult.Yes))
                {
                    DataGridViewRow selectedRow = dgvUsers.SelectedRows[0];
                    string selectedUsersId = selectedRow.Cells["id"].Value.ToString();
                    Program.database.DeleteUserOrBook(selectedUsersId, "users", "Felhasználó", "userid");
                    DataGridViewUpdateSearch();
                }

            }
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            Program.formBooks.Show();
            this.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        // ---------------------- Publikus Metódusok -------------------------
        // --- amiket a felhasználó keresés, és a könyv keresés is használ ---

        // Megadott index alapján visszaadja a ComboBox megfelelő értékét
        public string ComboBoxSelectedItem(int index, string firstValue, string secondValue)
        {
            switch (index)
            {
                case 1:
                    return firstValue;
                case 2:
                    return secondValue;
                default:
                    return string.Empty;
            }
        }


        // Enter leütésére hajtsa végre a megadott gomb (keresés) kattintás eseményét
        public void EnterSearch(Button btn, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn.PerformClick();
            }
        }



    }
}
