using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_decimal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                decimal dcNum = 123123123.12314M; //수치 접미사 (M, m)
                Console.WriteLine($"dcNum : {dcNum}");
            }

            // 타입 & 크기
            {
                Console.WriteLine("\n 타입 & 크기");

                decimal dcNum = 123123123.12314M; //수치 접미사 (M, m)
                Console.WriteLine($"Type: {dcNum.GetType()} sizeof: {sizeof(decimal)} byte");
            }

            // 저장 가능 범위
            {
                Console.WriteLine("\n 저장 가능 범위");

                decimal minDecimal = decimal.MinValue;
                decimal maxDecimal = decimal.MaxValue;

                Console.WriteLine($"minDecimal: {minDecimal}");
                Console.WriteLine($"maxDecimal: {maxDecimal}");
            }
        }
    }
}
