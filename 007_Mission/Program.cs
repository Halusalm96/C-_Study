using System;

namespace _007_Mission
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10, num2 = 20, total = 0;
            total = num1-- * 2 + ++num2 - 10 + --num1 * (num2++ % 2);
            // 10 * 2 + 21 - 10 + 8 * (21 % 2)

            num1 = 10;
            num2 = 20;
            Console.WriteLine($"계산 과정 : {num1--} * 2 + {++num2} - 10 + {--num1 } * ({num2++} % 2)");

            Console.WriteLine($"결과값 : {total}");
        }
    }
}
