using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _025_break_contine
{
    class Program
    {
        static void Main(string[] args)
        {
            //break 기초
            {
                Console.WriteLine("\n break 기초");

                for (int i = 0; i < 10; i++)
                {
                    if (i == 5) break;

                    Console.WriteLine($"i: {i}");
                }

                int num = 0;
                while (true)  //무한루프.. for(;;) == while
                {
                    if (++num > 10) break;
                    Console.WriteLine($"num: {num}");
                }

                switch (num)
                {
                    case 10:
                    case 11:
                        Console.WriteLine($"switch num: {num}");
                        break;

                    default:
                        break;
                }
            }

            {
                Console.WriteLine("\n 대문자 소문자 출력");

                int numA = 65;              //A
                int length = (90 - numA);   //Z
                int smallAlpha = 97;        //a
                int smallAlphaLength = smallAlpha + length;

                for (int i = 0; i <= length; i++)
                {
                    Console.Write($"{(char)(numA + i)}  ");
                    for (int j = smallAlpha; j <= smallAlphaLength; j++)
                    {
                        if ((numA + i) == j - 32) //32:(97 - 65)
                        {
                            Console.Write($"{(char)j}  ");
                            break;
                        }
                    }
                    Console.WriteLine();
                }
            }

            //continue 기초
            {
                Console.WriteLine("\n continue 기초");

                int num = 0;

                for (int i = 0; i < 10; i++)
                {
                    if (i == 5 || i == 7 || i == 9)
                    {
                        continue;
                    }

                    Console.WriteLine($"i: {i}");
                }
            }

            {
                Console.WriteLine("\n 대문자 소문자 출력");

                int numA = 65;              //A
                int length = (90 - numA);   //Z
                int smallAlpha = 97;        //a
                int smallAlphaLength = smallAlpha + length;

                for (int i = 0; i <= length; i++)
                {
                    Console.Write($"{(char)(numA + i)}  ");
                    for (int j = smallAlpha; j <= smallAlphaLength; j++)
                    {
                        if ((numA + i) == j - 32) //32:(97 - 65)
                        {
                            Console.Write($"{(char)(numA + i)} ");
                            continue;
                        }

                        Console.Write($"{(char)j}  ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
