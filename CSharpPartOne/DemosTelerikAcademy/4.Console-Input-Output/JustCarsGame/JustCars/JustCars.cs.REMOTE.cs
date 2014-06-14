using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;


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
            
             static void PrintStringOnPosition(int x, int y, string str,
            ConsoleColor color = ConsoleColor.Gray)
            {
    
                Console.SetCursorPosition(x, y);//Мести курсора
                Console.ForegroundColor = color;//цвета, който изписваме да е равен на color
                Console.Write(str);
            } 
            static void Main()
            {
                //С долните два реда махаме скролбара
                double speed = 100.0;
                double acceleration = 0.5;
                int playfieldWidth = 5;
                int livesCount = 5;
                Console.BufferHeight = Console.WindowHeight = 20;
                Console.BufferWidth = Console.WindowWidth = 30;
                Car userCar = new Car();
                userCar.x = 2;
                userCar.y = Console.WindowHeight - 1;
                userCar.c = '@';
                userCar.color = ConsoleColor.Yellow;
                Random randomGenerator = new Random();
                List<Car> car = new List<Car>();
                //PrintOnPosition(0, 0, 'N', ConsoleColor.Yellow);//позиция горе-ляво
                //PrintOnPosition(10, 10, 'X');
    //1:25:30
                while (true)
                {
                        speed += acceleration; 
                        if (speed > 400)
                        {
                                speed = 400;
                        }
                        bool hitted = false;
                    {// Move cars 
                    Car newCar = new Car();
                    newCar.color = ConsoleColor.Green;
                    newCar.x = randomGenerator.Next(0, playfieldWidth);
                    newCar.y = 0;
                    newCar.c = '#';
                    cars.Add(newCar);
                    }
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
                    List<Car> newList = new List<Car>();
                    for (int i = 0; i < cars.Count; i++)
                    {
                           Car oldCar = cars[i];
                           Car newCar = new Car();
                           newCar.x = oldCar.x;
                           newCar.y = oldCar.y + 1;
                           newCar.c = oldCar.c;
                           newCar.color = oldCar.color;
                           if (newCar.y == userCar.y && newCar.x == userCar.x)
                           {
                                   livesCiunt--;
                                   hitted = true;
                                   speed += 0.5;
                                    if (speed > 400)
                        {
                                speed = 400;
                        }
                                   if (livesCount <= 0)
                                   {
                                         PrintStringOnPosition(8, 10, "Game over!", ConsoleColor.Red);
                                         PrintStringOnPosition(8, 12, "Press [enter] to exit", ConsoleColor.Red);
                                         Console.ReadLine();
                                         Environment.Exit(0);
                                   }
                           }
                           if (newCar.y < Console.WindowHeight)
                           {
                                   newList.Add(newCar);
                           }
                    }
                    cars = newList;
                    //
                    // Check if other cars are hitting as
                    // Clear the console
                    Console.Clear();
                    // Redraw playfield
                   
                   if (hitted)
                    {
                         cars.Clear();   
                         PrintOnPosition(userCar.x userCar.y, 'x', ConsoleColor.Red);
                    }
                    else 
                    {
                        PrintOnPosition(userCar.x, userCar.y, userCar.c, userCar.color);
                    }
                    
                     // Move our car (key pressed)
                   foreach (Car car in cars)
                    {
                            PrintOnPosition(car.x, car.y, car.c, car.color);
                    } 
                    
                    // Draw info
                   PrintStringOnPosition(8, 4, "Lives: " + livesCount, ConsoleColor.White);
                   PrintStringOnPosition(8, 5, "Speed: " + speed, ConsoleColor.White);
                   PrintStringOnPosition(8, 6, "Acceleration: " + acceleration, ConsoleColor.White);
                    // Slow down program
                    //Console.Beep();
                 
                    Thread.Sleep((int)(600 - speed));
                }
            }
    
        }
