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
            //dgvUsers.DataSource = Program.database.UsersList();

            DataGridViewCreate(); // Táblázat megrajzolása
            DataGridViewUpdate(); // Táblázat feltöltése/adatok frissítése

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

        private void DataGridViewUpdate()
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


    }
}
