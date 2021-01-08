using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeOOP
{
    class FoodGenerator
    {
        int mapwidth;
        int mapHeight;
        char symb;

        Random rnd = new Random();

        public FoodGenerator(int _mapwidth, int _mapheight, char _symb)
        {
            mapwidth = _mapwidth;
            mapHeight = _mapheight;
            symb = _symb;
        } 
        public Point Generatefood()
        {
            int x = rnd.Next(2, mapwidth - 2);
            int y = rnd.Next(2, mapHeight - 2);
            return new Point(x, y, symb);
        }
    }
}
