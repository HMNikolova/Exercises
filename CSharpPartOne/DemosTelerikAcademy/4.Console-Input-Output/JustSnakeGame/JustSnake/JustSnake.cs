using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace JustSnake
{
    struct Position
    {
        public int row;
        public int c;
        public Position(int row, int col)
        {
            this.row = row;
            this.c = col;
        }
    }

    class JustSnake
    {
        static void Main(string[] args)
        {
            Position[] directions = new Position[]
            {
                new Position(0, 1), //right
                new Position(0, -1), //left
                new Position(1, 0), //down
                new Position(-1, 0), //top
            };
             
            Queue<Position> snakeElements = new Queue<Position>();
            for (int i = 0; i <= 5; i++)
            {
                snakeElements.Enqueue(new Position(0, i));
            }

            while (true)
            {
                ConsoleKeyInfo userInput = Console.ReadKey();
                //Console.Clear();

            }
        }
    }
}
