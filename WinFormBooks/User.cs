using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormBooks
{
    internal class User
    {
        readonly uint id;
        string username;
        string password;
        string role;

        public uint Id => id;

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Role { get => role; set => role = value; }

        public User(uint id, string username, string password, string role)
        {
            this.id = id;
            Username = username;
            Password = password;
            Role = role;
        }

        public override string ToString()
        {
            return $"{Id} {Username} {Password} {Role}";
        }

    }
}
