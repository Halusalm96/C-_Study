using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _038_Method_local
{
    class Program
    {
        public static int Sum(int a, int b)
        {
            PrintInput();
            return a + b;

            //접근 지정자 사용 불가!
            void PrintInput()
            {
                Console.WriteLine($"입력1: {a} 입력2: {b}");
            }
        }

        public static void LocalPrint(int num)
        {
            switch (num)
            {
                case 1:
                    PrintNum();
                    break;

                case 100:
                    PrintNum();
                    break;

                default:
                    PrintNum();
                    break;
            }

            void PrintNum()
            {
                Console.WriteLine($"PrintNum 입력: {num}");
            }
        }

        static void Main(string[] args)
        {
            Sum(10, 20);
            LocalPrint(1);
            LocalPrint(100);
            LocalPrint(54454);

            PrintHelloWorld();

            void PrintHelloWorld()
            {
                Console.WriteLine("Hello World");
            }

            PrintHelloWorld();
        }
    }
}
