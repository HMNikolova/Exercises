using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustCars
{
    struct Car
    {
        public int x;
        public int y;
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
            Console.BufferHeight = Console.WindowHeight = 20;
            Console.BufferWidth = Console.WindowWidth = 30;

            PrintOnPosition(0, 0, 'N', ConsoleColor.Yellow);//позиция горе-ляво
            PrintOnPosition(10, 10, 'X');

            while (true)
            {
                // Move cars  
                // Move our car (key pressed)
                // Check if other cars are hitting as
                // Clear the console
                // Redraw playfield
                // Draw info
                // Slow down program
            }
        }

    }

}
