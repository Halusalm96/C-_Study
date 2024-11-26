using System;

namespace _007_Const
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Const - 고정값을 정하다
            int num = 100;
            num = 0;
            Console.WriteLine($"num : {num}");

            const int Const_Num = 200;
            Console.WriteLine($"Const_Num : {Const_Num}");
            // Const_Num = 0; 에러: 상수이기 때문에 값의 변경 불가능

            const double Pl = 3.14;

            {
                const int number = 100;

                int num1 = number + 1;
                int num2 = number + 2;
                int num3 = number + 3;
                int num4 = number + 4;
                int num5 = number + 5;

                // number = 1000; 에러

                Console.WriteLine($"num5 : {num5}");

            }
        }
    }
}
