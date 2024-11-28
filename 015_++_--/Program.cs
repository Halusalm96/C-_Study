using System;

namespace _015______
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //기초
            {
                Console.WriteLine("전치증가, 후치증가");
                int num = 0;
                Console.WriteLine($"++num: {++num}");
                Console.WriteLine($"num++: {num++}");
                Console.WriteLine($"num: {num}"); //num = 2

                int total = num++ + 10;
                Console.WriteLine($"total: {total}");
                //num = 3
                total = ++num + 10; //num = 4
                Console.WriteLine($"total: {total}");
            }

            {
                Console.WriteLine("전치감소, 후치감소");
                float fNum = 10.5f;
                Console.WriteLine($"--fNum: {--fNum}");
                Console.WriteLine($"fNum--: {fNum--}");
                Console.WriteLine($"fNum: {fNum}"); //fNum = 8.5f

                float fTotal = 10.0f + fNum--;
                Console.WriteLine($"fTotal: {fTotal}");
                //fNum = 7.5f
                fTotal = 10.0f + --fNum; //fNum = 6.5f
                Console.WriteLine($"fTotal: {fTotal}");
            }

            //복합 할당 연산자(+=, -=, /=, *=, %=)
            {
                // +=: A += B ==> A = A + B;
                // -=: A -= B ==> A = A - B;
                // /=: A /= B ==> A = A / B;
                // *=: A *= B ==> A = A * B;
                // %=: A %= B ==> A = A % B;

                int num = 0;
                num += 10;  //num = num + 10;
                Console.WriteLine($"num: {num}");
                num -= 6;  //num = num - 6;
                Console.WriteLine($"num: {num}");
                num *= 2;  //num = num * 2;
                Console.WriteLine($"num: {num}");
                num /= 2;  //num = num / 2;
                Console.WriteLine($"num: {num}");
                num %= 3;  //num = num % 3;
                Console.WriteLine($"num: {num}");
            }
        }
    }
}
