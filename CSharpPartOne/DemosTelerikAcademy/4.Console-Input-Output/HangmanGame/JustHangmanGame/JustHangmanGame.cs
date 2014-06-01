using System;

class JustHangmanGame
{
    static void Main(string[] args)
    {
        //champion
        char c = 'c';
        char h = 'h';
        char a = 'a';
        char m = 'm';
        char p = 'p';
        char i = 'i';
        char o = 'o';
        char n = 'n';

        char hiddenChar = '_';

        bool isCShown = false;
        bool isHShown = false;
        bool isAShown = false;
        bool isMShown = false;
        bool isPShown = false;
        bool isIShown = false;
        bool isOShown = false;
        bool isNShown = false;

        int livesCount = 9;



        while (true)
        {
            Console.Write("Enter command: ");
            string command = "";
            command = Console.ReadLine();



            if (command == "view")
            {
                Console.WriteLine("Your lives are {0}", livesCount);
            }
            if (command == "guess")
            {
                Console.Write("Enter letter: ");
                char letter = Char.Parse(Console.ReadLine());
                if (letter == c)
                {
                    if (!isCShown)
                    {
                        isCShown = true;
                    }
                    else
                    {
                        Console.WriteLine("You already revealed this letter");
                    }
                }
                if (letter == h)
                {
                    if (!isHShown)
                    {
                        isHShown = true;
                    }
                    else
                    {
                        Console.WriteLine("You already revealed this letter");
                    }
                }
                if (letter == a)
                {
                    if (!isAShown)
                    {
                        isAShown = true;
                    }
                    else
                    {
                        Console.WriteLine("You already revealed this letter");
                    }
                }
                if (letter == m)
                {
                    if (!isMShown)
                    {
                        isMShown = true;
                    }
                    else
                    {
                        Console.WriteLine("You already revealed this letter");
                    }
                }
                if (letter == p)
                {
                    if (!isPShown)
                    {
                        isPShown = true;
                    }
                    else
                    {
                        Console.WriteLine("You already revealed this letter");
                    }

                }
                if (letter == i)
                {
                    if (!isIShown)
                    {
                        isIShown = true;
                    }
                    else
                    {
                        Console.WriteLine("You already revealed this letter");
                    }
                }
                if (letter == o)
                {
                    if (!isOShown)
                    {
                        isOShown = true;
                    }
                    else
                    {
                        Console.WriteLine("You already revealed this letter");
                    }
                }
                if (letter == n)
                {
                    if (!isNShown)
                    {
                        isNShown = true;
                    }
                    else
                    {
                        Console.WriteLine("You already revealed this letter");
                    }
                }
                if (letter != c && letter != h && letter != a && letter != m && letter != p && letter != i && letter != o && letter != n)
                {
                    Console.WriteLine("You made a huge mistake! Your lives now are {0}", livesCount);
                    livesCount--;
                }

                if (livesCount == 0)
                {
                    Console.WriteLine("Game over!");
                    break;
                }

                if (isCShown)
                {
                    Console.Write("{0} ", c);
                }
                else
                {
                    Console.Write("{0}", hiddenChar);
                }

                if (isHShown)
                {
                    Console.Write("{0} ", c);
                }
                else
                {
                    Console.Write("{0}", hiddenChar);
                }

                if (isAShown)
                {
                    Console.Write("{0} ", c);
                }
                else
                {
                    Console.Write("{0}", hiddenChar);
                }

                if (isMShown)
                {
                    Console.Write("{0} ", c);
                }
                else
                {
                    Console.Write("{0}", hiddenChar);
                }

                if (isPShown)
                {
                    Console.Write("{0} ", c);
                }
                else
                {
                    Console.Write("{0}", hiddenChar);
                }

                if (isIShown)
                {
                    Console.Write("{0} ", c);
                }
                else
                {
                    Console.Write("{0}", hiddenChar);
                }

                if (isOShown)
                {
                    Console.Write("{0} ", c);
                }
                else
                {
                    Console.Write("{0}", hiddenChar);
                }

                if (isNShown)
                {
                    Console.Write("{0} ", c);
                }
                else
                {
                    Console.Write("{0}", hiddenChar);
                }
            }

        }
    }

}



