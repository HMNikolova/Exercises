using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Threading;

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
            byte right = 0;
            byte left = 1;
            byte down = 2;
            byte up = 3;
            int lastFoodTime = 0;
            int foodDissapearTime = 8000;
            int negativePoints = 0;
            
            
            Position[] directions = new Position[]
            {
                new Position(0, 1), //right
                new Position(0, -1), //left
                new Position(1, 0), //down
                new Position(-1, 0), //up
            };
            double sleepTime = 100;
             int direction = right; 
              
             Random randomNumbersGenerator = new Random();
             Console.BufferHeight = Console.WindowHeihgt;
             lastFoodTime = Environment.TickCount;
             
             
             List<Position> obstacles = new List<Position>()
             {
                 new Position(12, 12),
                 new Position(14, 20),
                 new Position(7, 7),
                 new Position(19, 19),
                 new Position(6, 9),
             };
             foreach (Position obstacle in obstacles)
             {
                 Console.ForegroungColor = ConsoleColor.Cyan;
                 Console.SetCursorPosition(obstacle.col, obstacle.row);
                 Console.Write("=");
             }
             Queue<Position> snakeElements = new Queue<Position>();
            for (int i = 0; i <= 5; i++)
            {
                snakeElements.Enqueue(new Position(0, i));
            }
            Position food;
             do 
             {
                  food = new Position(randomNumbersGenerator.Next(0, Console.WindowHeight), randomNumbersGenerator.Next(0, WindowWidth));
             }
             while(snakeElements.Contains(food) || obstacles.Contains(food));
             Console.SetCursorPosition(food.col, food.row);
             Console.ForegroundColor = ConsoleColor.Yellow;
             Console.Write("@");
            
            
            foreach (Position position in snakeElements )
                {
                    Console.SetCursorPosition(position.col, position.row);
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.Write("*");
                }
                

            while (true)
            {
                negativePoints++;
                
                if (Console.KeyAvailable)
            {
                
                ConsoleKeyInfo userInput = Console.ReadKey();
                
                if (userInput.Key == ConsoleKey.LeftArrow)
                {
                   if (direction != right) direction = left;
                }
                if (userInput.Key == ConsoleKey.RightArrow)
                {
                    if (direction != left) direction = right;
                }
                if (userInput.Key == ConsoleKey.UpArrow)
                {
                    if (direction != down) direction = up;
                }
                if (userInput.Key == ConsoleKey.DownArrow)
                {
                    if (direction != up) direction = down;
                }
                
                    
            }
            
                
                
                Position SnakeHead = snakeElements.Last();
                Position nextDirection = directions[drection];
                Position snakeNewHead = new Position(snakeHead.row + nextDirection.row, snakeHead.col + nextDirection.col);
                
                if (snakeNewHead.col < 0) snakeNewHead.col = Console.WindowWidth - 1;
                if (snakeNewHead.row < 0) snakeNewHead.row = Console.WindowHeighConsole.WindowWidth - 1;
                if (snakeNewHead.row >= Console.WindowHeight) snakeNewHead.row = 0;
                if (snakeNewHead.col >= Console.WindowWidth) snakeNewHead = 0;
                
                if (snakeElements.Contains(snakeNewHead) || obstacles.Contains(snakeNewHead))
                {
                    Console.SetCursorPosition(0, 0);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Game over!");
                    int userPoints = (snakeElements.Count - 6) * 1 - negativePoints;
                    //if (userPoints < 0) userPoints = 0;
                    userPoints = Math.Max(userPoints, 0);
                    Console.WriteLine("Your points are: {0}", userPoints);
                    return;
                }
                
                
              Console.SetCursorPosition(snakeHead.col, snakeHead.row);
              Console.ForegroundColor = ConsoleColor.DarkGray;
              Console.Write("*");
                
                snakeElements.Enqueue(snakeNewHead);
              Console.SetCursorPosition(snakeNewHead.col, snakeNewHead.row);
              Console.ForegroundColor = ConsoleColor.Gray;
              if (direction == right) Console.Write(">");
              if (direction == left) Console.Write("<");
              if (direction == up) Console.Write("^");
              if (direction == down) Console.Write("v");
              
              Console.Write("*");obstacle
             if (snakeNewHead.col == food.col && snakeNewHead.row == food.row)
             {
                 //feeding the snake
                 do 
                 {
                    food = new Position(randomNumbersGenerator.Next(0, Console.WindowHeight), randomNumbersGenerator.Next(0, WindowWidth));
                 }
                 while(snakeElements.Contains(food) || obstacles.Contains(food));
                 lastFoodTime = Environment.TickCount;
                 Console.SetCursorPosition(food.col, food.row);
                 Console.ForegroundColor = ConsoleColor.Yellow;
             Console.Write("@");
                 sleepTime--;
                 
                 Position obstacle = new Position();
                 do 
                 {
                     obstacle = new Position(randomNumbersGenerator.Next(0, Console.WindowHeight), randomNumbersGenerator.Next(0, WindowWidth));
                  
                 }
                 while(snakeElements.Contains(obstacle) || obstacles.Contains(obstacle));
             //2:07:23
             }
             else
             {
                 //moving...
                Position last = snakeElements.Dequeue();
                 Console.SetCursirPosition(last.col, last.row);
                 Console.Write(" ");
             }
             
             if (Environment.TickCount- lastFoodTime >= foodDissapearTime)
             {
                 negativePoints = negativePoints + 50;
                 Console.SetCursorPosition(food.col, food.row);
                 Console.Write(" ");
                 
                  do 
                 {
                    food = new Position(randomNumbersGenerator.Next(0, Console.WindowHeight), randomNumbersGenerator.Next(0, WindowWidth));
                 }
                 while(snakeElements.Contains(food) || obstacles.Contains(food));
                 lastFoodTime = Environment.TickCount;
             }
             
             Console.SetCursorPosition(food.col, food.row);
             Console.ForegroundColor = ConsoleColor.Yellow;
             Console.Write("@");
                
               sleepTime -- 0.01;
               
               Thread.Sleep((int)sleepTime);
               
            }
        }
    }
}
