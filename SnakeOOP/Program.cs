using System;
using System.Collections.Generic;
using System.Threading;

namespace SnakeOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = 0;

            Walls walls = new Walls(80, 25);
            walls.Draw();

            Point snaketail = new Point(15, 15, '¤');
            Snake snake = new Snake(snaketail, 7, Direction.RIGHT);
            snake.Draw();
            FoodGenerator foodGenerator = new FoodGenerator(80, 25, '$');
            Point food = foodGenerator.Generatefood();
            food.Draw();
            
            while (true)
            {
                if (walls.IsHit(snake) || snake.ishittail())
                {
                    break;
                }
                if (snake.Eat(food))
                {
                    food = foodGenerator.Generatefood();
                    food.Draw();
                    score++;
                }
                else
                {
                    snake.Move();
                }
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKeys(key.Key);
                }

                Thread.Sleep(150);
                //snake.Move();
            }
            string str_score = Convert.ToString(score);
            writegameover(str_score);
            Console.ReadLine();

        }
        public static void writegameover(string score)
        {
            int xoffset = 25;
            int yoffset = 8;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(xoffset, yoffset++);
            writetext("==========================", xoffset, yoffset++);
            writetext("        GAME OVER         ", xoffset+1, yoffset++);
            writetext($"You scored {score} points!", xoffset+2, yoffset++);
            writetext("", xoffset+1, yoffset++);
            writetext("==========================", xoffset, yoffset++);
        }
        public static void writetext(String text, int xoffset , int yoffset)
        {
            Console.SetCursorPosition(xoffset, yoffset);
            Console.WriteLine(text);
        }
       
    }
}
