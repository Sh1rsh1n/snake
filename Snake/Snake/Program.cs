using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class Program
    {
        static void Main(string[] args)
        {

            HorizontLine horizontUp = new HorizontLine(1, 20, 0, '+');
            horizontUp.Draw();
            HorizontLine horizontDown = new HorizontLine(1, 20, 11, '+');
            horizontDown.Draw();


            VerticalLine verticalRight = new VerticalLine(0, 12, 21, '+');
            verticalRight.Draw();
            VerticalLine verticalLeft = new VerticalLine(0, 12, 0, '+');
            verticalLeft.Draw();

            Console.ReadLine();
        }
    }
}
