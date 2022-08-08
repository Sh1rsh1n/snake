using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Point
    {
        public int x;
        public int y;
        public char sym;

        public Point()
        {
        }

        public Point(int _x, int _y, char _sym)
        {
            x = _x;
            y = _y;
            sym = _sym;
        }


        public Point(Point point)
        {
            x = point.x;
            y = point.y;
            sym = point.sym;
        }

        public void draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
        public void Move(int offset, Directions directions)
        {
            if (directions == Directions.RIGHT)
            {
                x = x + offset;
            } 
            else if (directions == Directions.LEFT)
            {
                x = x - offset;
            } 
            else if (directions == Directions.UP)
            {
                y = y + offset;
            } 
            else if (directions == Directions.DOWN)
            {
                y = y - offset;
            }
        }

        internal void Clear()
        {
            sym = ' ';
            draw();
        }

        public override string ToString()
        {
            return x + ", " + y + ", " + sym;
        }
    }
}
