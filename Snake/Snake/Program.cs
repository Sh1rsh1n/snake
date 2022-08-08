using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {

            HorizontLine horizontUp = new HorizontLine(0, 78, 0, '+');
            HorizontLine horizontDown = new HorizontLine(0, 78, 24, '+');
            VerticalLine verticalRight = new VerticalLine(0, 24, 0, '+');
            VerticalLine verticalLeft = new VerticalLine(0, 24, 78, '+');


            horizontDown.Drow();
            horizontUp.Drow();
            verticalRight.Drow();
            verticalLeft.Drow();

            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Directions.RIGHT);
            snake.Drow();

            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);

        }
    }
}
