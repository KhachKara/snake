using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
	class HorizontalLine : Figure
	{
		public HorizontalLine(int xLeft, int xRight, int y, char sym)
		{
			pList = new List<Point>();
			for(int x = xLeft; x <= xRight; x++)
			{
				Point p = new Point( x, y, sym );
				pList.Add( p );
			}			
		}

		public override void Draw()
		{
			Console.ForegroundColor = ConsoleColor.Yellow;		// переопределение цвета текста	на желтый

			base.Draw();                                        // вызов базовова метода Draw базовова класса

            Console.ForegroundColor = ConsoleColor.White;       // переопределение цвета текста	на белый
		}
	}
}
