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
            Point p1 = new Point(1,3,'*');
            Point p2 = new Point(4,5, '#');

            p1.draw();

            p2.draw();

            Console.ReadLine();
        }
    }
}
