﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Figura
    {
        protected List<Point> pointList;
        public void Drow()
        {
            foreach (Point p in pointList)
            {
                p.draw();
            }
        }
    }
}
