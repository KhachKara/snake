using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_snake
{
    class Figure
    {
       protected List<Point> pList;

        public void Drow()
        {
            foreach (Point p in pList)
            {
                p.Draw(p.x, p.y, p.sym);
            }
        }
    }
}
