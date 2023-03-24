using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormBooks
{
    internal class Book
    {
        readonly uint id;
        string title;
        string author;
        string type;
        string finished;

        public uint Id => id;

        public string Title { get => title; set => title = value; }
        public string Author { get => author; set => author = value; }
        public string Type { get => type; set => type = value; }
        public string Finished { get => finished; set => finished = value; }

        public Book(uint id, string title, string author, string type, string finished)
        {
            this.id = id;
            Title = title;
            Author = author;
            Type = type;
            Finished = finished;
        }

        public override string ToString()
        {
            return $"{id} {title} {author} {type} {finished}";
        }
    }
}
