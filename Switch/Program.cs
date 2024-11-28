using System;

namespace _021_Switch
{
    public enum TEST { A, B, C, D, }
    class Program
    {
        static void Main(string[] args)
        {
            {
                int num = 15654;

                switch (num)
                {
                    case 10:
                        Console.WriteLine("이 수는 10이다.");
                        break;

                    case 0:
                        Console.WriteLine("이 수는 0이다.");
                        break;

                    default:
                        Console.WriteLine("이 수는 default");
                        break;
                }
            }

            {
                TEST test = TEST.A;

                // case에서 엔터를 치면 or이라는 뜻
                switch (test)
                {
                    case TEST.A:
                    case TEST.B:
                        Console.WriteLine("test는 A, B");
                        break;

                    case TEST.C:
                    case TEST.D:
                        Console.WriteLine("test는 C, D");
                        break;
                    default:
                        Console.WriteLine("default");
                        break;
                }

                if (test == TEST.A || test == TEST.B)
                {
                    Console.WriteLine("test는 A, B");
                }
                else if (test == TEST.C || test == TEST.D)
                {
                    Console.WriteLine("test는 C, D");
                }
                else
                {
                    Console.WriteLine("default");
                }
            }
        }
    }
}
