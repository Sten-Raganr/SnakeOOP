using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeOOP
{
    class VerticalLIne : Figure
    {
        public VerticalLIne(int yup ,int ydown,int x,char symb)
        {
            pointline = new List<Point>();
            for(int i = yup; i <= ydown; i++)
            {
                Point p = new Point(x,i, symb);
                pointline.Add(p);
            }
        }
 
    }
}
