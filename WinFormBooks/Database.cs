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
                BooksMessageBox.Error(ex.Message + "\n\nNem sikerült csatlakozni az adatbázishoz!\nA program leáll!");
                Environment.Exit(0);
            }
        }


        // --------------------- USERS ------------------------


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
                BooksMessageBox.Error(ex.Message + "\n\nFelhasználók lekérdezése sikertelen!\nA program leáll!");
                Environment.Exit(0);
            }

            return users;
        }

        // Metódus, ami visszaadja az összes felhasználónevet
        public List<string> UsernamesList()
        {
            List<string> usernames = new List<string>();
            cmd.CommandText = "SELECT username FROM users;";

            try
            {
                connection.Open();
                using (MySqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        usernames.Add(dr.GetString("username"));
                    }
                }
                connection.Close();
            }
            catch (MySqlException ex)
            {
                BooksMessageBox.Error(ex.Message);
            }

            return usernames;
        }



        // Új felhasználó hozzáadása
        public void InsertUser(string username, string password, string role)
        {
            try
            {
                connection.Open();
                cmd.Parameters.Clear();
                cmd.CommandText = "INSERT INTO users(id, username, password, role) VALUES (NULL,@Username,@Password,@Role);";
                cmd.Parameters.AddWithValue("Username", username);
                cmd.Parameters.AddWithValue("Password", password);
                cmd.Parameters.AddWithValue("Role", role);
                int affectedRows = cmd.ExecuteNonQuery();
                IsSuccessfulMessageBox(affectedRows, "Felhasználó felvétele");
                connection.Close();

            }
            catch (MySqlException ex)
            {
                BooksMessageBox.Error(ex.Message);
            }
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

                connection.Close();

            }
            catch (MySqlException ex)
            {
                BooksMessageBox.Error(ex.Message);
            }
        }



        // --------------------- BOOKS ------------------------

        // Metódus, ami visszaadja a keresett könyveket; ha nincs keresés, az összeset   
        public List<Book> SelectedBooksList(string title, string author, string type, string finished)
        {
            List<Book> books = new List<Book>();
            cmd.CommandText = $"SELECT id, cim, szerzo, tipus, olvasas FROM book WHERE cim LIKE \"%{title}%\" AND szerzo LIKE \"%{author}%\" AND tipus LIKE \"%{type}%\" AND olvasas LIKE \"%{finished}%\";";

            try
            {
                connection.Open();
                using(MySqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Book newBook = new Book(
                            dr.GetUInt32("id"),
                            dr.GetString("cim"),
                            dr.GetString("szerzo"),
                            dr.GetString("tipus"),
                            dr.GetString("olvasas")
                        );
                        books.Add(newBook);
                    }
                }
                connection.Close();

            }
            catch (MySqlException ex)
            {
                BooksMessageBox.Error(ex.Message + "\n\nKönyvek lekérdezése sikertelen!\nA program leáll!");
                Environment.Exit(0);
            }

            return books;
        }


        // Könyv adatainak módosítása
        public void UpdateBook(Book book)
        {
            try
            {
                connection.Open();
                cmd.Parameters.Clear();
                cmd.CommandText = "UPDATE book SET cim=@title, szerzo=@author, tipus=@type, olvasas=@finished WHERE id=@id";
                
                cmd.Parameters.AddWithValue("@title", book.Title);
                cmd.Parameters.AddWithValue("@author", book.Author);
                cmd.Parameters.AddWithValue("@type", book.Type);
                cmd.Parameters.AddWithValue("@finished", book.Finished);
                cmd.Parameters.AddWithValue("@id", book.Id);

                int affectedRows = cmd.ExecuteNonQuery();
                IsSuccessfulMessageBox(affectedRows, "Könyv adatainak módosítása");

                connection.Close();

            }
            catch (MySqlException ex)
            {
                BooksMessageBox.Error(ex.Message);

            }
        }




        // --------------------- USERS & BOOKS ------------------------


        // Sikeres volt-e a művelet
        private void IsSuccessfulMessageBox(int affectedRows, string message)
        {
            if (affectedRows == 1)
            {
                BooksMessageBox.Information($"{message} sikeres!");
            }
            else
            {
                BooksMessageBox.Error($"{message} sikertelen!");
            }
        }


        // Felhasználó vagy könyv törlése
        public void DeleteUserOrBook(string id, string tableName, string typeName)
        {
            try
            {
                connection.Open();
                cmd.Parameters.Clear();
                cmd.CommandText = $"DELETE FROM {tableName} WHERE id = @id;";
                cmd.Parameters.AddWithValue("@id", id);

                int affectedRows = cmd.ExecuteNonQuery();
                IsSuccessfulMessageBox(affectedRows, $"{typeName} törlése");

                connection.Close();

            }
            catch (MySqlException ex)
            {
                BooksMessageBox.Error(ex.Message);
            }
        }

    }
}
