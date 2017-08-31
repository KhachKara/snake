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
            Point p1 = new Point(1, 3, '*');
            p1.Draw(p1.x, p1.y, p1.sym);

            Point p2 = new Point(4, 5, '#');
            p2.Draw(p2.x, p2.y, p2.sym);

            HorizontalLine line = new HorizontalLine(5, 10, 8, '+');
            line.Drow();          
            
            Console.ReadLine();
        }
    }
}
