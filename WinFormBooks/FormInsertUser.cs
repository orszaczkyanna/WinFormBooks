using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
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
            User newUser = new User(0, username, role);

            // Új felhasználó felvétele
            if (FieldsAreFilled(username, password1, password2, role) && UsernameMinimumLength(username) && UsernameIsSimple(username) && UsernameIsAvailable(username) && PasswordIsComplex(password1) && PasswordMatch(password1, password2))
            {
                hashedPassword = BCrypt.Net.BCrypt.HashPassword(password1, salt);
                Program.database.InsertUser(newUser, hashedPassword);
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
        private bool FieldsAreFilled(string username, string password1, string password2, string role)
        {
            bool result = true;
            if (username.Equals("") || password1.Equals("") || password2.Equals("") || (!role.Equals("admin") && !role.Equals("user")))
            {
                result = false;
                BooksMessageBox.Warning("Tölts ki minden mezőt!");
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
                if (newUsername.Equals(username))
                {
                    result = false;
                    BooksMessageBox.Warning("A felhasználónév már foglalt!");
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
                BooksMessageBox.Warning("A felhasználónév minimum 3 karakterből álljon!");
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
                BooksMessageBox.Warning("A felhasználónév csak a következőket tartalmazhatja:\naz angol abc kis- és nagybetűi, számok, pont, kötőjel és aláhúzásjel.");
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
                BooksMessageBox.Warning("A jelszó legalább 8 karakter hosszú legyen,\ntartalmazzon kis- és nagybetűt, számot és speciális karaktert!");
            }

            return result;
        }

        // Ellenőrzés: a jelszavak egyeznek-e
        private bool PasswordMatch(string password1, string password2)
        {
            bool result = false;
            if (password1.Equals(password2))
            {
                result = true;
            }
            else
            {
                BooksMessageBox.Warning("A jelszavak nem egyeznek!");
            }
            return result;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
