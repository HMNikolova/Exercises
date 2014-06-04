using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


        struct Car
        {
            public int x;
            public int y;
            public char c;
            public ConsoleColor color;
        }
    
        class JustCars
        {
            static void PrintOnPosition(int x, int y, char c,
            ConsoleColor color = ConsoleColor.Gray)
            {
    
                Console.SetCursorPosition(x, y);//Мести курсора
                Console.ForegroundColor = color;//цвета, който изписваме да е равен на color
                Console.Write(c);
            }
            
            static void Main()
            {
                //С долните два реда махаме скролбара
                int playfieldWidth = 5;
                Console.BufferHeight = Console.WindowHeight = 20;
                Console.BufferWidth = Console.WindowWidth = 30;
                Car userCar = new Car();
                userCar.x = 2;
                userCar.y = Console.WindowHeight - 1;
                userCar.c = '@';
                userCar.color = ConsoleColor.Yellow;
                Random randomGenerator = new Random();
                List<Car> cars = new List<Car>();
                //PrintOnPosition(0, 0, 'N', ConsoleColor.Yellow);//позиция горе-ляво
                //PrintOnPosition(10, 10, 'X');
    
                while (true)
                {
                    // Move cars 
                    Car newCar = new Car();
                    newCar.color = ConsoleColor.Green;
                    newCar.x = 
                    //52.03
                    if (Console.KeyAvailable)
                    {
                        ConsoleKeyInfo pressedKey = Console.ReadKey(true);
                        while(Console.KeyAvailable) Console.ReadKey(true);
                      
                        if (pressedKey.Key == ConsoleKey.LeftArrow)//LeftArrow е стрелка на ляво
                        {
                               if (userCar.x - 1 >= 0)
                               {
                                        userCar.x = userCar.x - 1;
                               }
                        }
                        else if (pressedKey.Key == ConsoleKey.RightArrow)
                           {
                                   if (userCar.x + 1 < playfieldWidth)
                                   {
                                           userCar.x = userCaar.x + 1;
                                   }
                           }        
                    }
                    
                    // Move our car (key pressed)
                    // Check if other cars are hitting as
                    // Clear the console
                    Console.Clear();
                    // Redraw playfield
                    PrintOnPosition(userCar.x, userCar.y, userCar.c, userCar.color);
                    // Draw info
                    // Slow down program
                    Thread.Sleep(100);
                }
            }
    
        }
