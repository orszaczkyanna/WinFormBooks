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
                MessageBox.Show(ex.Message + "\n\nNem sikerült csatlakozni az adatbázishoz!\nA program leáll!");
                Environment.Exit(0);
            }
        }


        // Metódus, ami visszaadja az összes felhasználót tartalmazó listát
        public List<User> UsersList()
        {

            List<User> users = new List<User>();
            cmd.CommandText = "SELECT id, username, password, role FROM users;";

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
                            dr.GetString("password"),
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




    }
}
