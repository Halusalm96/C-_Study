using System;

namespace _006_Mission
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write($"1번째 숫자 입력 : ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write($"2번째 숫자 입력 : ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"두 수의 합 : {num1 + num2}");
        }
    }
}