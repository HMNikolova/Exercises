﻿﻿using System;
using System.Collections;
using System.Text;
using System.Threading;

class Program
{
    //static byte[][,] levels = new byte[3][,];
    //levels[0] = levels[]
    static int padSize = 10;
    static int padPositionX = 0;
    static int padPositionY = 3;
    static int ballPositionX = 0;
    static int ballPositionY = 0;
    static bool ballMovementRight = true;
    static bool ballMovementUp = true;
    static string brickSymbol = "\u2580";
    static int[,] bricks;
    static int fieldHeight;
    static int fieldWidth;
    static void Main()
    {
        DrawGamefield();
        fieldHeight = Console.WindowHeight;
        fieldWidth = Console.WindowWidth;
        Console.OutputEncoding = Encoding.Unicode;
        bricks = new int[fieldHeight, fieldWidth];
        CreateBricks();
        PrintBricks();
        DrawPad();
        while (true)
        {
            BallMovement();
            while (Console.KeyAvailable)
            {
                ConsoleKeyInfo pressedKey = Console.ReadKey(true);
                if (pressedKey.Key == ConsoleKey.LeftArrow)
                {
                    if (padPositionX > 0)
                    {
                        PadMovement("left");
                    }
                }
                else if (pressedKey.Key == ConsoleKey.RightArrow)
                {
                    if (padPositionX < Console.WindowWidth - padSize)
                    {
                        PadMovement("right");
                    }
                }
            }
            Thread.Sleep(100);

        }
    }



    static void CreateBricks()
    {
        for (int i = 7; i < 13; i++)
        {
            for (int j = 1; j < 100; j++)
            {
                bricks[i, j] = 1;
            }
        }
    }
    static void PrintBricks()
    {
        for (int i = 0; i < fieldHeight; i++)
        {
            for (int j = 0; j < fieldWidth; j++)
            {
                if (bricks[i, j] != 0)
                {
                    PrintAtPosition(j, i, brickSymbol, ConsoleColor.Cyan);
                }
            }
        }

    }
    
    static void DrawGamefield()
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Console.WindowHeight = 30;
        Console.WindowWidth = 100;
        Console.BufferHeight = Console.WindowHeight;
        Console.BufferWidth = Console.WindowWidth;
        padPositionX = (Console.WindowWidth - padSize) / 2;
        padPositionY = Console.WindowHeight - padPositionY;
        ballPositionX = Console.WindowWidth / 2;
        ballPositionY = Console.WindowHeight / 2;
        PrintAtPosition(ballPositionX, ballPositionY, "\u25cb");
    }
    static void DrawPad()
    {
        for (int col = 0; col < padSize; col++)
        {
            PrintAtPosition(padPositionX + col, padPositionY, "\u25a0");
        }
    }
    static void BallMovement()
    {
        PrintAtPosition(ballPositionX, ballPositionY, " ");
        if (ballMovementRight && ballMovementUp)
        {
            ballPositionX++;
            ballPositionY--;
        }
        else if (ballMovementRight && !ballMovementUp)
        {
            ballPositionX++;
            ballPositionY++;
        }
        else if (!ballMovementRight && ballMovementUp)
        {
            ballPositionX--;
            ballPositionY--;
        }
        else
        {
            ballPositionX--;
            ballPositionY++;
        }
        PrintAtPosition(ballPositionX, ballPositionY, "\u25cb");
        if (ballPositionX == Console.WindowWidth - 1) ballMovementRight = false;
        else if (ballPositionX == 0) ballMovementRight = true;
        else if (ballPositionY == 0) ballMovementUp = false;
        else if (ballPositionY == padPositionY - 1 && ballPositionX >= padPositionX && ballPositionX <= padPositionX + padSize) ballMovementUp = true;
        //else if (ballPositionY == Console.WindowHeight - 1) ballMovementUp = true;
    }
    static void PadMovement(string direction)
    {
        if (direction == "left")
        {
            PrintAtPosition(padPositionX + padSize - 1, padPositionY, " ");
            padPositionX--;
            DrawPad();
        }
        else
        {
            PrintAtPosition(padPositionX, padPositionY, " ");
            padPositionX++;
            DrawPad();
        }
    }
    static void PrintAtPosition(int x, int y, string text, ConsoleColor foregroundColor = ConsoleColor.White)
    {
        Console.ForegroundColor = foregroundColor;
        Console.SetCursorPosition(x, y);
        Console.Write(text);
    }
}