﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;



namespace my_snake
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задал размер консоли
            Console.SetWindowSize(80, 25);      // принудительно задаем размер консоли 
            Console.SetBufferSize(80, 25);      // установливаем размер окна и убираем возможность перемотки

            // Нарисовал пямоугольник по краям консоли
            HorizontalLine h1Line = new HorizontalLine(0, 78, 0, '*');
            h1Line.Drow();
            HorizontalLine h2Line = new HorizontalLine(0, 78, 24, '*');
            h2Line.Drow();
            VerticalLine v1Line = new VerticalLine(0, 24, 0, '*');
            v1Line.Drow();
            VerticalLine v2Line = new VerticalLine(0, 24, 78, '*');
            v2Line.Drow();

            // Нарисовал точки
            Point p = new Point(4, 5, '*');    // Задаем координаты точки и символ
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Drow();

            FoodCreator foodcreator = new FoodCreator(80, 25, '$');
            Point food = foodcreator.CreateFood();
            food.Draw();

            while (true)
            {
                if (snake.Eat(food))
                {
                    food = foodcreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }

                Thread.Sleep(100);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
            }
        }
    }
}
