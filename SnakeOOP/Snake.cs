using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SnakeOOP
{
    class Snake : Figure
    {
        Direction direction;
        public Snake(Point tail, int lenght, Direction _direction)
        {
            direction = _direction;
            pointline = new List<Point>();

            for( int i=0;i < lenght;i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                pointline.Add(p);
            }

        }
        public void Move()
        {
            Point tail = pointline.First();
            pointline.Remove(tail);
            tail.clear();

            Point head = GetNextPoint();
            pointline.Add(head);
            head.Draw();

        }
        public Point GetNextPoint()
        {
            Point head = pointline.Last();
            Point nextpoint = new Point(head);
            nextpoint.Move(1, direction);
            return nextpoint;

        }
        public void HandleKeys(ConsoleKey key)
        {
            if(key == ConsoleKey.LeftArrow)
            {
                direction = Direction.LEFT;
            }
            else if (key == ConsoleKey.RightArrow)
            {
                direction = Direction.RIGHT;
            }
            else if (key == ConsoleKey.UpArrow)
            {
                direction = Direction.UP;
            }
            else  
            {
                direction = Direction.DOWN;
            }
        }
        public bool Eat(Point food)
        {
            Point head = GetNextPoint();
            if (head.IsHit(food))
            {
                food.symb = head.symb;
                pointline.Add(food);
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool ishittail()
        {
            Point haed = pointline.Last();
            for (int i = 0;i < pointline.Count - 2; i++)
            {
                if (haed.IsHit(pointline[i]))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
