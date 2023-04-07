using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static Mysqlx.Notice.Warning.Types;

namespace WinFormBooks
{
    internal class Database
    {

        MySqlConnection connection = null;
        MySqlCommand cmd = null;

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
                connection.Close();
                BooksMessageBox.Error("Nem sikerült csatlakozni az adatbázishoz!\nA program leáll!");
                Environment.Exit(0);
            }
        }


        // --------------------- USERS ------------------------


        // Metódus, ami visszaadja a keresett felhasználókat; ha nincs keresés, az összeset        
        public List<User> SelectedUsersList(User user)
        {
            List<User> users = new List<User>();
            cmd.CommandText = $"SELECT userid, username, role FROM users WHERE username LIKE \"%{user.Username}%\" AND role LIKE \"%{user.Role}%\";";

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
                            dr.GetUInt32("userid"),
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
                connection.Close();
                BooksMessageBox.Error("Felhasználók lekérdezése sikertelen!\nA program leáll!");
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
                connection.Close();
                BooksMessageBox.Error(ex.Message);
            }

            return usernames;
        }



        // Új felhasználó hozzáadása
        public void InsertUser(User newUser, string password)
        {
            try
            {
                connection.Open();
                cmd.Parameters.Clear();
                cmd.CommandText = "INSERT INTO users(userid, username, password, role) VALUES (NULL,@Username,@Password,@Role);";
                cmd.Parameters.AddWithValue("Username", newUser.Username);
                cmd.Parameters.AddWithValue("Password", password);
                cmd.Parameters.AddWithValue("Role", newUser.Role);
                int affectedRows = cmd.ExecuteNonQuery();
                IsSuccessfulMessageBox(affectedRows, "Felhasználó felvétele");
                connection.Close();

            }
            catch (MySqlException ex)
            {
                connection.Close();
                BooksMessageBox.Error(ex.Message);
            }
        }

        // Jogosultság módosítása
        public void UpdateRole(User user)
        {
            try
            {
                connection.Open();
                cmd.Parameters.Clear();
                cmd.CommandText = "UPDATE users SET role = @role WHERE userid = @id;";
                cmd.Parameters.AddWithValue("@role", user.Role);
                cmd.Parameters.AddWithValue("@id", user.Id);

                int affectedRows = cmd.ExecuteNonQuery();
                IsSuccessfulMessageBox(affectedRows, "Jogosultság módosítása");

                connection.Close();

            }
            catch (MySqlException ex)
            {
                connection.Close();
                BooksMessageBox.Error(ex.Message);
            }
        }



        // --------------------- BOOKS ------------------------

        // Metódus, ami visszaadja a keresett könyveket; ha nincs keresés, az összeset   
        public List<Book> SelectedBooksList(Book book)
        {
            List<Book> books = new List<Book>();
            cmd.CommandText = $"SELECT bookid, cim, szerzo, tipus, olvasas FROM book WHERE cim LIKE \"%{book.Title}%\" AND szerzo LIKE \"%{book.Author}%\" AND tipus LIKE \"%{book.Type}%\" AND olvasas LIKE \"%{book.Finished}%\";";

            try
            {
                connection.Open();
                using(MySqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Book newBook = new Book(
                            dr.GetUInt32("bookid"),
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
                connection.Close();
                BooksMessageBox.Error("Könyvek lekérdezése sikertelen!\nA program leáll!");
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
                cmd.CommandText = "UPDATE book SET cim=@title, szerzo=@author, tipus=@type, olvasas=@finished WHERE bookid=@id";
                
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
                connection.Close();
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
        public void DeleteUserOrBook(string id, string tableName)
        {
            
            string messageText = string.Empty;
            string idFieldName = string.Empty;

            if (tableName.Equals("users"))
            {
                messageText = "Felhasználó";
                idFieldName = "userid";
            }
            else if (tableName.Equals("book"))
            {
                messageText = "Könyv";
                idFieldName = "bookid";
            }

            try
            {
                connection.Open();
                cmd.Parameters.Clear();
                cmd.CommandText = $"DELETE FROM {tableName} WHERE {idFieldName} = @id;";
                cmd.Parameters.AddWithValue("@id", id);

                int affectedRows = cmd.ExecuteNonQuery();
                IsSuccessfulMessageBox(affectedRows, $"{messageText} törlése");

                connection.Close();

            }
            catch (MySqlException ex)
            {
                connection.Close();  

                switch (ex.Number)
                {
                    case 1451:
                        BorrowedBookErrorMessage(tableName);
                        break;
                    case 1064:
                        BooksMessageBox.Error("A program nemlétező adattáblából próbál törölni.\nA művelet sikertelen.");
                        break;
                    default:
                        BooksMessageBox.Error(ex.Message);
                        break;
                }
            }
        }

        private void BorrowedBookErrorMessage(string tableName)
        {
            if (tableName.Equals("book"))
            {
                BooksMessageBox.Error("A könyv nem törölhető, mivel kölcsönben van.");
            }
            else if (tableName.Equals("users"))
            {
                BooksMessageBox.Error("A felhasználó nem törölhető, mivel kölcsönvett könyv van nála.");
            }
        }
    }
}
