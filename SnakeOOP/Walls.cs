using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeOOP
{
    class Walls
    {
        List<Figure> Walllist;
        Random rnd = new Random();
        Random rnd2 = new Random();

        public Walls(int mapWidth, int mapheight)
        {
            Walllist = new List<Figure>();
            HorizontalLine top = new HorizontalLine(0, 80, 0, '#');
            HorizontalLine bot = new HorizontalLine(0, 80, 25, '#');
            VerticalLIne left = new VerticalLIne(0, 25, 0, '#');
            VerticalLIne right = new VerticalLIne(0, 25, 80, '#');

            VerticalLIne obstcale = new VerticalLIne(rnd.Next(0, 10), rnd.Next(0, 13), rnd.Next(0, 50), '%');
            VerticalLIne obstcale2 = new VerticalLIne(rnd2.Next(0, 10), rnd2.Next(0, 13), rnd2.Next(0, 50), '%');
            Walllist.Add(top);
            Walllist.Add(bot);
            Walllist.Add(left);
            Walllist.Add(right);
            Walllist.Add(obstcale);
            Walllist.Add(obstcale2);
        }
        public void Draw()
        {
            foreach(var wall in Walllist)
            {
                wall.Draw();
            }
        }
        public bool IsHit(Figure figure)
        {
            foreach (var wall in Walllist)
            {
                if (wall.IsHit(figure))
                {
                    return true;
                }


            }
            return false;
        }
    }
}
