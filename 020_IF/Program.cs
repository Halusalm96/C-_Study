using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _020_IF
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                if (true)
                {
                    Console.WriteLine("조건이 참");
                }
                else
                {
                    Console.WriteLine("조건이 거짓");
                }
            }

            {
                int num1 = 101;
                int num2 = 100;

                if (num1 == num2)
                {
                    Console.WriteLine("두개의 수는 같다");
                }
                else
                {
                    Console.WriteLine("두개의 수는 다르다");
                }

                if (num1 % 2 == 0)
                {
                    Console.WriteLine("이 수는 짝수다.");
                }
                else
                {
                    Console.WriteLine("이 수는 홀수다.");
                }
            }

            //if ~ else if ~ else
            {
                int num = 105;

                if (num == 100)
                {
                    Console.WriteLine("이 수는 100");
                }
                else if (num < 100)
                {
                    Console.WriteLine("이 수는 100보다 작다");
                }
                else
                {
                    Console.WriteLine("이 수는 100보다 크다");
                }
            }

            //if문에 중첩
            {
                int num = 10;

                if (num < 100)
                {
                    if (num > 10)
                    {
                        Console.WriteLine("이 수는 10보다 크다.");
                    }
                    else
                    {
                        Console.WriteLine("이 수는 10보다 작거나 같다.");
                    }
                }
            }
        }
    }
}
