﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Snake
{
	class Program
	{
		static void Main( string[] args )
		{
			VerticalLine vl = new VerticalLine( 0, 10, 5, '%' );
			Draw( vl );

			Point p = new Point( 4, 5, '*' );
			Figure fSnake = new Snake( p, 4, Direction.RIGHT );
			Draw( fSnake );
			Snake snake = (Snake) fSnake;           //принудительное приведению к типу объекта

			HorizontalLine hl = new HorizontalLine( 0, 5, 6, '&' );

			List<Figure> figures = new List<Figure>();  //создаем список фигур в котором и змейка и линии
			figures.Add( fSnake );
			figures.Add( vl );
			figures.Add( hl );

			foreach(var f in figures)
			{
				f.Draw();
			}
            Console.Read();
		}

		static void Draw( Figure figure )
		{
			figure.Draw();
		}
	}
}
