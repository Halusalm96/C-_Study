using System;

namespace _014_Operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 기초 (+, -, *, /, %)
            {
                int num1 = 3, num2 = 4;
                int sum = num1 + num2;
                Console.WriteLine($"Sum : {sum}");

                Console.WriteLine($"num1 + num2 : {num1 + num2}");
                Console.WriteLine($"num1 - num2 : {num1 - num2}");
                Console.WriteLine($"num1 * num2 : {num1 * num2}");
                Console.WriteLine($"num1 / num2 : {num1 / num2}");
                Console.WriteLine($"num1 % num2 : {num1 % num2}");

                byte b = 100;
                Console.WriteLine($"Type: {(b + 10).GetType()}");
                var result = (b + 10);
                Console.WriteLine($"Type: {result.GetType()}");

                Console.WriteLine($"15.6f / 3.3f:  {15.6f / 3.3f}");
            }

            //복합 연산
            {
                int num = 1 + 2 * 3 + 4;
                Console.WriteLine($"1 + 2 * 3 + 4= {num}");

                num = (1 + 2) * (3 + 4);
                Console.WriteLine($"(1 + 2) * (3 + 4)= {num}");

                int num1 = 1 + 2;
                int num2 = 3 + 4;
                int total = num1 * num2;
                Console.WriteLine($"total: {total}");

                num = 4 * 6 / 4 * 2;
                Console.WriteLine($"num: {num}");
                num = 4 * 6;
                num = num / 4;
                num = num * 2;
                Console.WriteLine($"num: {num}");
            }
        }
    }
}
