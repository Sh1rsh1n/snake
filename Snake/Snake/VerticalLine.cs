using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VerticalLine
    {
        List<Point> pointsList;

        public VerticalLine(int yUp, int yDown, int x, char sym)
        {
            pointsList = new List<Point>();
            for (int y = yUp; y < yDown; y++)
            {
                Point point = new Point(x, y, sym);
                pointsList.Add(point);
            }
        }

        public void Draw()
        {
            foreach (Point point in pointsList)
            {
                point.draw();
            }
        }
    }
}
