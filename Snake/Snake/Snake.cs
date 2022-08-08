using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake : Figura
    {
        public Directions direction;

        public Snake(Point tail, int lenght, Directions _direction)
        {
            direction = _direction;
            pointList = new List<Point>();

            for (int i = 0; i < lenght; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                pointList.Add(p);
            }
        }

        public void Move()
        {
            Point tail = pointList.First();
            pointList.Remove(tail);
            Point head = GetNextPoint();
            pointList.Add(head);

            tail.Clear();
            head.draw();
        }

        internal bool IsHitTail()
        {
            var head = pointList.Last();
            for(int i = 0; i < pointList.Count - 2;i++)
            {
                if (head.IsHit(pointList[i]))
                    return true;
            }
            return false;
        }

        public Point GetNextPoint()
        {
            Point head = pointList.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, direction);
            return nextPoint;
        }

        public bool Eat(Point food)
        {
            Point head = GetNextPoint();
            if (head.IsHit(food))
            {
                food.sym = head.sym;
                pointList.Add(food);
                return true;
            }
            else
                return false;
        }

        public void HandleKey(ConsoleKey key)
        {
                    if (key == ConsoleKey.LeftArrow)
                        direction = Directions.LEFT;
                    else if (key == ConsoleKey.RightArrow)
                        direction = Directions.RIGHT;
                    else if (key == ConsoleKey.UpArrow)
                        direction = Directions.UP;
                    else if (key == ConsoleKey.DownArrow)
                        direction = Directions.DOWN;
        }


    }
}
