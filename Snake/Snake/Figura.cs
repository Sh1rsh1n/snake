using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Figura
    {
        protected List<Point> pointList;
        public virtual void Drow()
        {
            foreach (Point p in pointList)
            {
                p.draw();
            }
        }

        internal bool IsHit(Figura figura)
        {
            foreach(var p in pointList)
            {
                if (figura.IsHit(p))
                    return true;
            }
            return false;
        }

        private bool IsHit(Point point)
        {
            foreach(var p in pointList)
            {
                if(p.IsHit(point))
                    return true;
            }
            return false;
        }
    }
}
