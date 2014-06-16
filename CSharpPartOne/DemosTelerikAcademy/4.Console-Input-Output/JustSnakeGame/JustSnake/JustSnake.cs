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
        public int col;
        public Position(int row, int col)
        {
            this.row = row;
            this.col = col;
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
                new Position(-1, 0), //up
            };
             int direction = 0; //0
             
            Queue<Position> snakeElements = new Queue<Position>();
            for (int i = 0; i <= 5; i++)
            {
                snakeElements.Enqueue(new Position(0, i));
            }
            
            foreach (Position position in snakeElements )
                {
                    Console.SetCursorPosition(position.col, position.row);
                    Console.Write("*");
                }
                

            while (true)
            {
                ConsoleKeyInfo userInput = Console.ReadKey();
                //Console.Clear();
                if (userInput.Key == ConsoleKey.LeftArrow)
                {
                    direction = 1;
                }
                if (userInput.Key == ConsoleKey.RightArrow)
                {
                    direction = 0;
                }
                if (userInput.Key == ConsoleKey.UpArrow)
                {
                    direction = 3;
                }
                if (userInput.Key == ConsoleKey.DownArrow)
                {
                    direction = 2;
                }
                
            
                Position SnakeHead = snakeElements.Last();
                snakeElements.Dequeue();
                Position nextDirection = directions[drection];
                Position snakeNewHead = new Position(snakeHead.row + nextDirection.row, snakeHead.col + nextDirection.col);
                
                snakeElements.Enqueue(snakeNewHead);
                
                foreach (Position position in snakeElements )
                {
                    Console.SetCursorPosition(position.col, position.row);
                    Console.Write("*");
                    //31:24
                }
                
            }
        }
    }
}
