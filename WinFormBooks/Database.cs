using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WinFormBooks
{
    internal class Database
    {

        public MySqlConnection connection = null;
        public MySqlCommand cmd = null;

        // Konstruktor, adatbázis kapcsolat felépítése
        public Database(string server = "localhost", string database = "books", string userID = "root", string password = "")
        {
            // A kapcsolódáshoz szükséges paraméterek
            MySqlConnectionStringBuilder sb = new MySqlConnectionStringBuilder();
            sb.Server = server;
            sb.Database = database;
            sb.UserID = userID;
            sb.Password = password;
            sb.CharacterSet = "utf8";
            connection = new MySqlConnection(sb.ConnectionString);

            // Kapcsolat felépítése
            try
            {
                connection.Open();
                cmd = connection.CreateCommand();
                connection.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message + "\n\nNem sikerült csatlakozni az adatbázishoz!\nA program leáll!", Program.globalMessageBoxCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }
        }


        // Metódus, ami visszaadja az összes felhasználót tartalmazó listát
        /* public List<User> UsersList()
        {

            List<User> users = new List<User>();
            cmd.CommandText = "SELECT id, username, role FROM users;";

            try
            {
                connection.Open();
                using (MySqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {

                        // user átnevezése felhasználóra
                        string role = dr.GetString("role");
                        string roleRename;
                        if (role == "user")
                        {
                            roleRename = "felhasználó";
                        }
                        else
                        {
                            roleRename = role;
                        }

                        // új felhasználó hozzáadása a listához
                        User newUser = new User(
                            dr.GetUInt32("id"),
                            dr.GetString("username"),
                            roleRename
                        );

                        users.Add(newUser);


                    }
                }
                connection.Close();
            }

            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message + "\n\nFelhasználók lekérdezése sikertelen!\nA program leáll!");
                Environment.Exit(0);
            }

            return users;
        }
        */


        // Metódus, ami visszaadja a keresett felhasználókat; ha nincs keresés, az összeset        
        public List<User> SelectedUsersList(string usernameSearch, string roleSearch)
        {
            List<User> users = new List<User>();
            cmd.CommandText = $"SELECT id, username, role FROM users WHERE username LIKE \"%{usernameSearch}%\" AND role LIKE \"%{roleSearch}%\";";

            try
            {
                connection.Open();
                using (MySqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {

                        // felhasználó és admin átnevezése
                        string role = dr.GetString("role");
                        string roleRename;
                        if (role == "user")
                        {
                            roleRename = "felhasználó";
                        }
                        else
                        {
                            roleRename = "admin";
                        }

                        // új felhasználó hozzáadása a listához
                        User newUser = new User(
                            dr.GetUInt32("id"),
                            dr.GetString("username"),
                            roleRename
                        );

                        users.Add(newUser);


                    }
                }
                connection.Close();
            }

            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message + "\n\nFelhasználók lekérdezése sikertelen!\nA program leáll!", Program.globalMessageBoxCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }

            return users;
        }



        // Jogosultság módosítása
        public void UpdateRole(string role, string id)
        {
            try
            {
                connection.Open();
                cmd.Parameters.Clear();
                cmd.CommandText = "UPDATE users SET role = @role WHERE id = @id;";
                cmd.Parameters.AddWithValue("@role", role);
                cmd.Parameters.AddWithValue("@id", id);

                int affectedRows = cmd.ExecuteNonQuery();
                IsSuccessfulMessageBox(affectedRows, "Jogosultság módosítása");

                //if (affectedRows == 1)
                //{
                //    MessageBox.Show("Jogosultság módosítása sikeres!");
                //}
                //else
                //{
                //    MessageBox.Show("Jogosultság módosítása sikertelen!");
                //}

                connection.Close();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }





        // Felhasználó törlése
        public void DeleteUser(string id)
        {
            try
            {
                connection.Open();
                cmd.Parameters.Clear();
                cmd.CommandText = "DELETE FROM users WHERE id = @id;";
                cmd.Parameters.AddWithValue("@id", id);

                int affectedRows = cmd.ExecuteNonQuery();
                IsSuccessfulMessageBox(affectedRows, "Felhasználó törlése");

                connection.Close();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void IsSuccessfulMessageBox(int affectedRows, string message)
        {
            if (affectedRows == 1)
            {
                MessageBox.Show($"{message} sikeres!", Program.globalMessageBoxCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"{message} sikertelen!", Program.globalMessageBoxCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



    }
}
