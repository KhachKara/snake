using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace my_snake
{
    class Program
    {
        static void Main(string[] args)
        {
            book b1 = new book(125, "Shrek", "Unknown");
            book b2 = new book(300, "Nemo", "Dyuma");
            book b3 = new book(450, "English-Russian dictionary", "AST");
            /*b1.drawbook(b1.pages, b1.name, b1.author);
            b2.drawbook(b2.pages, b2.name, b2.author);
            b3.drawbook(b3.pages, b3.name, b3.author);*/

            List<book> booklist = new List<book>();
            booklist.Add(b1);
            booklist.Add(b2);
            booklist.Add(b3);
            foreach (book i in booklist)
            {
                i.drawbook(i.pages, i.name, i.author);
            }
            
            Console.ReadLine();
        }
    }
}
