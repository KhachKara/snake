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
            // Задал размер консоли
            Console.SetWindowSize(100, 30);

            // Нарисовал пямоугольник по краям консоли
            HorizontalLine h1Line = new HorizontalLine(0, 99, 1, '*');
            h1Line.Drow();
            HorizontalLine h2Line = new HorizontalLine(0, 99, 29, '*');
            h2Line.Drow();
            VerticalLine v1Line = new VerticalLine(0, 0, 28, '*');
            v1Line.Drow();
            VerticalLine v2Line = new VerticalLine(99, 0, 28, '*');
            v2Line.Drow();

            // Нарисовал точки
            Point p = new Point(5, 10, '*');    // Задаем координаты точки и символ
            p.Draw(5, 10, '*');                 // Не корректный синтаксис но работает
     
            Console.ReadLine();
        }
    }
}
