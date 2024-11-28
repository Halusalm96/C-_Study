using System;

namespace _023_For
{
    class Program
    {
        static void Main(string[] args)
        {
            //기초for(초기화 ; 조건 ; 증감)..
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.Write($"i: {i}  ");
                }

                Console.WriteLine();

                int j = 0;
                while (j < 5)
                {
                    Console.Write($"j: {j}  ");
                    j++;
                }
            }

            {
                Console.WriteLine("\n 0 ~ 10까지의 합, 짝수의 합");
                int totalEven = 0;
                int total = 0;

                for (int i = 0; i <= 10; i++)
                {
                    if (i % 2 == 0)
                    {
                        totalEven += i;
                    }
                    total += i;
                }

                Console.WriteLine($"totalEven: {totalEven}");
                Console.WriteLine($"total: {total}");
            }

            //중첩되는 for문
            {
                Console.WriteLine("\n 중첩되는 for문");

                for (int i = 0; i < 5; i++)
                {
                    Console.Write($"i: {i}   ");
                    for (int j = 0; j < 5; j++)
                    {
                        Console.Write($"j: {j} ");
                    }

                    Console.WriteLine();
                }
            }

            //구구단 출력..
            {
                Console.WriteLine("\n 구구단 출력");

                for (int i = 1; i < 10; i++)
                {
                    for (int j = 2; j < 10; j++)
                    {
                        Console.Write($"\t{j} * {i} = {j * i}");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
