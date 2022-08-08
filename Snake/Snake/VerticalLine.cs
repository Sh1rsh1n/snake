using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VerticalLine : Figura
    {
        public VerticalLine(int yUp, int yDown, int x, char sym)
        {
            pointList = new List<Point>();
            for (int y = yUp; y < yDown; y++)
            {
                Point point = new Point(x, y, sym);
                pointList.Add(point);
            }
        }

        public override void Drow()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            foreach (Point p in pointList)
            {
                p.draw();
            }

            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
