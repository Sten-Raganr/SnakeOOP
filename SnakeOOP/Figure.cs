using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeOOP
{
    class Figure
    {
        protected List<Point> pointline;

        public void Draw()
        {
            foreach (Point point in pointline)
            {
                Console.SetCursorPosition(point.x, point.y);
                Console.Write(point.symb);
            }
           
        }
        public bool IsHit(Figure figure)
        {
            foreach(var point in pointline)
            {
                if (figure.IsHit(point))
                {
                    return true;
                }
                

            }
            return false;
        }
        public bool IsHit(Point point)
        {
            foreach(var p in pointline)
            {
                if (p.IsHit(point))
                {

                }
            }
            return false;
        }

    }

}
