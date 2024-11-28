using System;

namespace _005_Mission
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("이름 : ");
            var Name = Console.ReadLine();
            Console.Write("나이 : ");
            var Age = Console.ReadLine();
            Console.Write("성별 : ");
            var Data = Console.ReadLine();

            Console.WriteLine($"이름 : {Name} / 나이 : {Age} / 성별 : {Data}");
        }
    }
}
