using System;

    class StringSplit
    {
        static void Main()
        {
            //string input = "12 123 432 45 1";
            //string[] strArr = input.Split(' ');
            //int[] nums = new int[strArr.Length];
            //for (int i = 0; i < strArr.Length; i++)
            //{
            //    nums[i] = int.Parse(strArr[i]);
            //    Console.WriteLine(strArr);
            //} 


            //string numStr = "";
            //for (int i = 0; i < input.Length; i++)
            //{
            //    if (char.IsDigit(input, i))
            //    {
            //        numStr += input[i];
            //    }
            //    else
            //    {
            //        int num = int.Parse(numStr);
            //        Console.WriteLine(num);
            //        numStr = "";
            //    }
            //}

            Console.WriteLine("Enter five numbers given in a single line, separated by a space");
            string[] fiveNumber = Console.ReadLine().Split(' ');
            double sum = 0;
            for (int i = 0; i < fiveNumber.Length; i++)
            {
                sum += Convert.ToDouble(fiveNumber[i]);
            }
            Console.WriteLine("Sum is = {0}", sum);
        }
    }

