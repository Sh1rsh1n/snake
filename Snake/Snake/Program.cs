using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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


            horizontDown.Draw();
            horizontUp.Draw();
            verticalRight.Draw();
            verticalLeft.Draw();

            Console.ReadLine();
        }
    }
}
