using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeOOP
{
    class HorizontalLine : Figure
    {
        public HorizontalLine(int xleft, int xright,int y, char symb)
        {
            pointline = new List<Point>();
            for (int i= xleft;i<= xright; i++)
            {
                Point p = new Point(i, y, symb);
                pointline.Add(p);
            }

        }
       
    }
}
