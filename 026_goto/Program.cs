using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _026_goto
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 100;

            // goto - 실행이 되면 실행문 실행 -> 선언한 실행문이 실행되어 그 부분의 실행문을 따라간다.

            // switch문 사용
            switch (num)
            {
                case 10:
                    Console.WriteLine($"goto num: {num}");
                    break;

                case 100:
                    goto case 10;

                default:
                    break;
            }

            // for문에서 사용
            {
                for (int i = 0; i < 100; i++)
                {
                    Console.Write($"i: {i}  ");

                    if (i == 10)
                    {
                        goto Finish;
                    }
                }

            Finish:
                Console.WriteLine("\n i: Goto Finish:");
            }
        }
    }
}
