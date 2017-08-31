using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_snake
{
    class Point
    {
        public int x;
        public int y;
        public char sym;

        public Point(int _x, int _y, char _sym) 
        {
            x = _x;
            y = _y;
            sym = _sym;
        }
       
        public void Draw(int x, int y, char sym) // ??? у преподавателя не так, не задаются аргументы
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }
}
