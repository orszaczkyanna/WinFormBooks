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
    public partial class FormBooks : Form
    {
        public FormBooks()
        {
            InitializeComponent();
        }

        private void FormBooks_Load(object sender, EventArgs e)
        {

            // ComboBox elemeinek megadása
            cmbFilterType.Items.AddRange(new string[] { "mind", "nyomtatott", "ebook" });
            cmbFilterType.SelectedIndex = 0;
            cmbFilterFinished.Items.AddRange(new string[] { "mind", "igen", "nem" });
            cmbFilterFinished.SelectedIndex = 0;

            // dgvBooks DataGridView
            DataGridViewBooksCreate();
            DataGridViewBooksUpdateSearch();
        }



        private void DataGridViewBooksCreate()
        {
            // Táblázat tulajdonságai
            dgvBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBooks.MultiSelect = false;
            dgvBooks.RowTemplate.Height = 45;
            dgvBooks.RowHeadersWidth = 30;

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
            dgvBooks.Columns.Add(colId);

            // 2. oszlop - Cím
            DataGridViewColumn colTitle = new DataGridViewColumn();
            {
                colTitle.Name = "title";
                colTitle.HeaderText = "Cím";
                colTitle.CellTemplate = new DataGridViewTextBoxCell();
                colTitle.SortMode = DataGridViewColumnSortMode.Automatic;
            }
            dgvBooks.Columns.Add(colTitle);

            // 3. oszlop - Szerző
            DataGridViewColumn colAuthor = new DataGridViewColumn();
            {
                colAuthor.Name = "author";
                colAuthor.HeaderText = "Szerző";
                colAuthor.CellTemplate = new DataGridViewTextBoxCell();
                colAuthor.SortMode = DataGridViewColumnSortMode.Automatic;
            }
            dgvBooks.Columns.Add(colAuthor);


            // 4. oszlop - Típus
            DataGridViewColumn colType = new DataGridViewColumn();
            {
                colType.Name = "type";
                colType.HeaderText = "Típus";
                colType.CellTemplate = new DataGridViewTextBoxCell();
                colType.SortMode = DataGridViewColumnSortMode.Automatic;
            }
            dgvBooks.Columns.Add(colType);


            // 5. oszlop - Befejezett
            DataGridViewColumn colFinished = new DataGridViewColumn();
            {
                colFinished.Name = "finished";
                colFinished.HeaderText = "Befejezett";
                colFinished.CellTemplate = new DataGridViewTextBoxCell();
                colFinished.SortMode = DataGridViewColumnSortMode.Automatic;
            }
            dgvBooks.Columns.Add(colFinished);



        }

        private void DataGridViewBooksUpdate(List<Book> BooksList)
        {
            dgvBooks.Rows.Clear();
            foreach (Book book in BooksList)
            {
                int index = dgvBooks.Rows.Add();
                DataGridViewRow newRow = dgvBooks.Rows[index];

                newRow.Cells["id"].Value = book.Id;
                newRow.Cells["title"].Value = book.Title;
                newRow.Cells["author"].Value = book.Author;
                newRow.Cells["type"].Value = book.Type;
                newRow.Cells["finished"].Value = book.Finished;
            }
        }

        public void DataGridViewBooksUpdateSearch()
        {
            string titleSearch = tbSearchTitle.Text;
            string authorSearch = tbSearchAuthor.Text;
            string typeFilter = Program.mainForm.ComboBoxSelectedItem(cmbFilterType.SelectedIndex, "nyomtatott", "ebook");
            string finishedFilter = Program.mainForm.ComboBoxSelectedItem(cmbFilterFinished.SelectedIndex, "igen", "nem");

            List<Book> booksList = Program.database.SelectedBooksList(titleSearch, authorSearch, typeFilter, finishedFilter);
            DataGridViewBooksUpdate(booksList);
        }




        // Könyv(ek) keresése keresés gombbal, vagy enterrel
        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataGridViewBooksUpdateSearch();
        }

        private void tbSearchTitle_KeyDown(object sender, KeyEventArgs e)
        {
            Program.mainForm.EnterSearch(btnSearch, e);
        }

        private void tbSearchAuthor_KeyDown(object sender, KeyEventArgs e)
        {
            Program.mainForm.EnterSearch(btnSearch, e);
        }

        private void cmbFilterType_KeyDown(object sender, KeyEventArgs e)
        {
            Program.mainForm.EnterSearch(btnSearch, e);
        }

        private void cmbFilterFinished_KeyDown(object sender, KeyEventArgs e)
        {
            Program.mainForm.EnterSearch(btnSearch, e);
        }

        // Táblázat tartalmának frissítése: töltse be az összes könyvet
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            tbSearchTitle.Text = string.Empty;
            tbSearchAuthor.Text = string.Empty;
            cmbFilterType.SelectedIndex = 0;
            cmbFilterFinished.SelectedIndex = 0;
            DataGridViewBooksUpdateSearch();
        }


        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
            if (dgvBooks.SelectedRows.Count == 0)
            {
                BooksMessageBox.WarningNoSelected("könyv");
            }
            else
            {
                FormUpdateBook formUpdateBook = new FormUpdateBook();
                formUpdateBook.ShowDialog();
            }
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            
            if (dgvBooks.SelectedRows.Count == 0)
            {
                BooksMessageBox.WarningNoSelected("könyv");
            }
            else
            {

                DialogResult result = BooksMessageBox.YesNo("a könyvet");

                if (result.Equals(DialogResult.Yes))
                {
                    DataGridViewRow selectedRow = dgvBooks.SelectedRows[0];
                    string selectedBookId = selectedRow.Cells["id"].Value.ToString();
                    Program.database.DeleteUserOrBook(selectedBookId, "book", "Könyv", "bookid");
                    DataGridViewBooksUpdateSearch();

                }

            }
        }



        private void btnUsers_Click(object sender, EventArgs e)
        {
            Program.mainForm.Show();
            this.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormBooks_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.mainForm.Close();
        }


    }
}
