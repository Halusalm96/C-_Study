using System;

namespace _006_Bool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // bool (부등호) - (== , 값다) / ( <, >, 크다, 작다)

            bool isEqual = (100 == 100);
            bool isResult = (100 < 1);

            Console.WriteLine($"isEqual : {isEqual}");
            Console.WriteLine($"isResult : {isResult}");

            bool isTrue = true;
            bool isFalse = false;

            Console.WriteLine($"isTrue : {isTrue}");
            Console.WriteLine($"isFalse : {isFalse}");
        }
    }
}
