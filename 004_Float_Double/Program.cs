using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_Float_Double
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                float fNum = 0.001f;
                double dNum = 12345678.9;

                Console.WriteLine($"fNum : {fNum}");
                Console.WriteLine($"dNum : {dNum}");
            }

            // 수치 접미사
            {
                Console.WriteLine("\n수치 접미사");

                float fNum = 0.00014F; // float (F, f)
                double dNum = 12345678.9d; // double (D, d)

                Console.WriteLine($"fNum : {fNum}");
                Console.WriteLine($"dNum : {dNum}");
            }

            // 타입 & 크기
            { 
                Console.WriteLine("\n타입 & 크기");

                float fNum = 0.0032f;

                Console.WriteLine($"Type : {fNum.GetType()} sizeof : {sizeof(float)} byte");
                Console.WriteLine($"Type : {1412451.14234.GetType()} sizeof : {sizeof(double)} byte");
            }

            // 저장 가능 범위
            {
                Console.WriteLine("\n저장 가능 범위");
                
                float minFloat = float.MinValue;
                float maxFloat = float.MaxValue;

                Console.WriteLine($"minFloat : {minFloat}");
                Console.WriteLine($"maxFloat : {maxFloat}");
            }

            // 지수 표현 방식
            {
                Console.WriteLine("\n지수 표현 방식");

                float fNum = 1.2345f;
                Console.WriteLine($"fNum: {fNum}");

                fNum = 12.345e-1f;//12.345 X 10(-1)
                Console.WriteLine($"fNum: {fNum}");

                fNum = 123.45e-2f;//123.45 X 10(-2)
                Console.WriteLine($"fNum: {fNum}");

                fNum = 0.12345e1f;//0.12345 X 10(1)
                Console.WriteLine($"fNum: {fNum}");

                fNum = 0.012345e2f;//0.012345 X 10(2)
                Console.WriteLine($"fNum: {fNum}");

                double dNum = 1e8;  //1.0 * 10(8)
                Console.WriteLine($"dNum: {dNum}");

                dNum = 0.1e9;  //0.1 * 10(9)
                Console.WriteLine($"dNum: {dNum}");

                //부동 소수점에 연산 오류
                fNum = 100000000000f;
                for (long i = 0; i < 100000000; i++)
                    fNum = fNum + 1f;
                Console.WriteLine($"fNum: {fNum}");
            }
        }
    }
}