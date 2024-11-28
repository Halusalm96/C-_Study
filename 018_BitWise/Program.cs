using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _018_BitWise
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2진수
            {
                sbyte byteNum1 = 0b00001111;
                sbyte byteNum2 = 0b_0000_0011;

                var resultValue = byteNum1 & byteNum2;

                Console.WriteLine($"byteNum1 & byteNum2: {byteNum1 & byteNum2}");
                Console.WriteLine($"Type: {resultValue.GetType()}");
                Console.WriteLine(Convert.ToString(resultValue, 2));

                resultValue = byteNum1 | byteNum2;
                Console.WriteLine($"byteNum1 | byteNum2: {byteNum1 | byteNum2}");
                Console.WriteLine(Convert.ToString(resultValue, 2));
            }

            //<< - 오른쪽에 0을 n개 추가한다 / >> - 왼쪽에서 0을 n개 추가한다.
            {
                Console.WriteLine("\n >>, <<(Shift)");

                uint uintOption = 0x01;
                // uintOption, 2 - 위에 있는 2는 2진수를 뜻한다.
                Console.WriteLine(Convert.ToString(uintOption, 2));
                Console.WriteLine(Convert.ToString(uintOption << 1, 2));
                Console.WriteLine(Convert.ToString(uintOption << 2, 2));

                uintOption = 0b0000_1000;
                Console.WriteLine(Convert.ToString(uintOption >> 1, 2));
                Console.WriteLine(Convert.ToString(uintOption >> 2, 2));
            }

            //^ - 비트의 숫자를 반전 시킴, ~ - 두 비트가 같으면 0, 다르면 1
            {
                Console.WriteLine("\n ^, ~");


                uint a = 0b_1111_1000;

                Console.WriteLine(Convert.ToString(~a, 2));
                Console.WriteLine(Convert.ToString(~~a, 2));

                uint b = 0b_1001_1010;
                uint c = 0b_1111_1111;
                Console.WriteLine(Convert.ToString(b ^ c, 2));

                //1001_1010
                //--------- ^
                //1111_1111
                //0110_0101
            }
        }
    }
}
