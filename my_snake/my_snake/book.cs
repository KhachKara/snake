using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_snake
{
    class book
    {
        public int pages;
        public string name;
        public string author;

        public book(int _pages, string _name, string _author)
        {
            pages = _pages;
            name = _name;
            author = _author;
        }

        public void drawbook(int pages, string name, string author) 
        {
            Console.WriteLine("Pages: " + pages);
            Console.WriteLine("Tilte: " + name);
            Console.WriteLine("Author: " + author);
        }

    }
}
