using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormBooks
{
    public partial class FormInsertUser : Form
    {
        public FormInsertUser()
        {
            InitializeComponent();
        }

        private void FormInsertUser_Load(object sender, EventArgs e)
        {
            cmbRoleIn.Items.AddRange(new string[] { "admin", "felhasználó" });
            cmbRoleIn.SelectedIndex = 0;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            // BCrypt
            string salt = BCrypt.Net.BCrypt.GenerateSalt(10);
            string hashedPassword;

            // Új felhasználó adatai
            string username = tbUsernameIn.Text;
            string password1 = tbPasswordIn1.Text;
            string password2 = tbPasswordIn2.Text;
            string role = RoleToSend(cmbRoleIn.SelectedIndex);

            // Új felhasználó felvétele
            if (FieldsFilled(username, password1, password2) && UsernameMinimumLength(username) && UsernameIsSimple(username) && UsernameIsAvailable(username) && PasswordIsComplex(password1) && PasswordMatch(password1, password2))
            {
                hashedPassword = BCrypt.Net.BCrypt.HashPassword(password1, salt);
                Program.database.InsertUser(username, hashedPassword, role);
                Program.mainForm.DataGridViewUpdateSearch();
                this.Close();
            }
        }



        // Jogosultság megnevezésének átalakítása, hogy megfelelő értéket küldjön az adatbázisnak
        private string RoleToSend(int selectedIndex)
        {
            if (selectedIndex == 0)
            {
                return "admin";
            }
            else
            {
                return "user";
            }
        }

        // Ellenőrzés: a mezők ki vannak-e töltve
        private bool FieldsFilled(string username, string password1, string password2)
        {
            bool result = true;
            if (username == "" || password1 == "" || password2 == "")
            {
                result = false;
                MessageBox.Show("Tölts ki minden mezőt!", Program.globalMessageBoxCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return result;
        }

        // Ellenőrzés: a felhasználónév elérhető-e, vagy már foglalt
        private bool UsernameIsAvailable(string newUsername)
        {
            bool result = true;
            List<string> usernames = Program.database.UsernamesList();

            foreach (string username in usernames)
            {
                if (newUsername == username)
                {
                    result = false;
                    MessageBox.Show("A felhasználónév már foglalt!", Program.globalMessageBoxCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            return result;
        }

        // Ellenőrzés: a felhasználónév minimum 3 karakterből áll-e
        private bool UsernameMinimumLength(string username)
        {
            bool result = false;
            if (username.Length >= 3)
            {
                result = true;
            }
            else
            {
                MessageBox.Show("A felhasználónév minimum 3 karakterből álljon!", Program.globalMessageBoxCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return result;

        }

        // Ellenőrzés: a felhasználónév megfelelő karakterekből áll-e
        private bool UsernameIsSimple(string username)
        {
            bool result = false;
            if (Regex.IsMatch(username, @"^[a-zA-Z0-9_\-.]+$"))
            {
                result = true;
            }
            else
            {
                MessageBox.Show("A felhasználónév csak a következőket tartalmazhatja:\naz angol abc kis- és nagybetűi, számok, pont, kötőjel és aláhúzásjel.", Program.globalMessageBoxCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return result;
        }

        // Ellenőrzés: elég erős-e a jelszó
        private bool PasswordIsComplex(string password)
        {
            bool result = false;
            if (Regex.IsMatch(password, @"^.*(?=.{8,})(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[!*@#$%^&+=]).*$"))
            {
                result = true;
            }
            else
            {
                MessageBox.Show("A jelszó legalább 8 karakter hosszú legyen,\ntartalmazzon kis- és nagybetűt, számot és speciális karaktert!", Program.globalMessageBoxCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return result;
        }

        // Ellenőrzés: a jelszavak egyeznek-e
        private bool PasswordMatch(string password1, string password2)
        {
            bool result = false;
            if (password1 == password2)
            {
                result = true;
            }
            else
            {
                MessageBox.Show("A jelszavak nem egyeznek!", Program.globalMessageBoxCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return result;
        }

        



    }
}
