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
    public partial class FormUpdateBook : Form
    {


        // Kiválasztott könyv
        static DataGridViewRow selectedRow;
        uint selectedBookId;
        //string selectedBookTitle;
        //string selectedBookAuthor;
        //string selectedBookType;
        //string selectedBookFinished;
        Book selectedBook;

        public FormUpdateBook()
        {
            InitializeComponent();
        }

        private void FormUpdateBook_Load(object sender, EventArgs e)
        {
            cmbTypeUp.Items.AddRange(new string[] { "nyomtatott", "ebook" });
            cmbFinishedUp.Items.AddRange(new string[] { "igen", "nem" });
            LoadSelectedBookData();
        }

        private void LoadSelectedBookData()
        {

            // Kiválasztott könyv adatainak kiolvasása
            selectedRow = Program.formBooks.dgvBooks.SelectedRows[0];
            selectedBookId = Convert.ToUInt32(selectedRow.Cells["id"].Value.ToString());
            string selectedBookTitle = selectedRow.Cells["title"].Value.ToString();
            string selectedBookAuthor = selectedRow.Cells["author"].Value.ToString();
            string selectedBookType = selectedRow.Cells["type"].Value.ToString();
            string selectedBookFinished = selectedRow.Cells["finished"].Value.ToString();
            selectedBook = new Book(selectedBookId, selectedBookTitle, selectedBookAuthor, selectedBookType, selectedBookFinished);


            // Megjelenítés
            tbTitleUp.Text = selectedBook.Title;
            tbAuthorUp.Text = selectedBook.Author;
            ComboBoxLoadSelectedIndex(cmbTypeUp, selectedBook.Type, "nyomtatott");
            ComboBoxLoadSelectedIndex(cmbFinishedUp, selectedBook.Finished, "igen");


        }

        // Beállítja a megadott ComboBox kiválasztott elemének indexét,
        // hogy az a típus/befejezettség jelenjen meg alapértelmezetten, ami a kiválasztott könyvnél volt
        private void ComboBoxLoadSelectedIndex(ComboBox cmb, string selectedValue, string value)
        {
            if (selectedValue == value)
            {
                cmb.SelectedIndex = 0;
            }
            else
            {
                cmb.SelectedIndex = 1;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Bevitt adatok
            Book updatedBook = new Book(selectedBookId, tbTitleUp.Text, tbAuthorUp.Text, cmbTypeUp.Text, cmbFinishedUp.Text);


            // Könyv adatainak módosítása,
            // ha a mezők ki vannak töltve, és történt változtatás
            if (ValuesAreAppropriate(updatedBook) && ValuesChanged(selectedBook, updatedBook))
            {
                Program.database.UpdateBook(updatedBook);
                Program.formBooks.DataGridViewBooksUpdateSearch();
                this.Close();
            }

        }




        // Ellenőrzi, hogy a mezők ki vannak-e töltve
        private bool ValuesAreAppropriate(Book book)
        {
            if (book.Title.Equals(""))
            {
                MessageBox.Show("Add meg a címet!", Program.globalMessageBoxCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (book.Author.Equals(""))
            {
                MessageBox.Show("Add meg a szerzőt!", Program.globalMessageBoxCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!book.Type.Equals("nyomtatott") && !book.Type.Equals("ebook"))
            {
                MessageBox.Show("Add meg a típust!", Program.globalMessageBoxCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MessageBox.Show(book.Type);
                return false;
            }
            if (!book.Finished.Equals("igen") && !book.Finished.Equals("nem"))
            {
                MessageBox.Show("Add meg, hogy olvastad-e már a könyvet!", Program.globalMessageBoxCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        // Ellenőrzi, hogy történt-e módosítás
        private bool ValuesChanged(Book selectedBook, Book updatedBook)
        {

            if (selectedBook.Title.Equals(updatedBook.Title) && selectedBook.Author.Equals(updatedBook.Author) && selectedBook.Type.Equals(updatedBook.Type) && selectedBook.Finished.Equals(updatedBook.Finished))
            {
                MessageBox.Show("Nem történt módosítás!", Program.globalMessageBoxCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }


    }
}
