using System;

namespace _024_For
{
    class Program
    {
        static void Main(string[] args)
        {
            //숫자의 자리수를 구하기..
            int num = 479; // 4 7 9

            int DigitOfOne = 0;
            int DigitOfTen = 0;
            int DigitOfHundred = 0;

            Console.WriteLine($"num: {num}");

            DigitOfOne = num % 10; //10보다 작은수...
            Console.WriteLine($"DigitOfOne: {DigitOfOne}");

            num /= 10;
            Console.WriteLine($"num: {num}");
            DigitOfTen = num % 10; //10보다 작은수...
            Console.WriteLine($"DigitOfTen: {DigitOfTen}");

            num /= 10;
            Console.WriteLine($"num: {num}");
            DigitOfHundred = num % 10; //10보다 작은수...
            Console.WriteLine($"DigitOfHundred: {DigitOfHundred}");

            num = 479;
            int temp;

            // 간단하게 만든 코드
            for (int i = 0; i < 3; i++)
            {
                temp = num % 10;

                if (i == 0)
                {
                    DigitOfOne = temp;
                }
                else if (i == 1)
                {
                    DigitOfTen = temp;
                }
                else
                {
                    DigitOfHundred = temp;
                }

                num /= 10;
            }

            Console.WriteLine($"DigitOfOne: {DigitOfOne}");
            Console.WriteLine($"DigitOfTen: {DigitOfTen}");
            Console.WriteLine($"DigitOfHundred: {DigitOfHundred}");
        }
    }
}
