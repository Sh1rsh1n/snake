using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class HorizontLine : Figura
    {
        public HorizontLine(int xLeft, int xRight, int y, char sym)
        {
            pointList = new List<Point>();
            for (int x = xLeft; x <= xRight; x++)
            {
                Point p = new Point(x, y, sym);
                pointList.Add(p);
            }
        }

        public override void Drow()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            base.Drow();

            Console.ForegroundColor= ConsoleColor.White;
        }
    }
}
