using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _019_OperatorEsc
{
    class Program
    {
        public class AA { }
        static void Main(string[] args)
        {
            //삼항연산자(?:)
            {
                int num = 10;
                bool isNum = (num == 10) ? true : false; //(조건식) ? 참 : 거짓;
                int selectNum = num != 10 ? 10 : 0;

                Console.WriteLine($"isNum: {isNum}");
                Console.WriteLine($"selectNum: {selectNum}");
            }

            //null병합연산자(??) - 왼쪽의 함수 값이 null 이면 오른쪽 함수 값으로 변환
            {
                Console.WriteLine("\n null병합연산자(??)");

                int? nullNum1 = null;
                int num1 = 100;
                int? nullNum2 = null;
                int num2 = 1000;
                int? nullNum3 = 999;

                int result1 = nullNum1 ?? num1;
                Console.WriteLine($"result1: {result1}");

                int result2 = nullNum1 ?? nullNum2 ?? num2;
                Console.WriteLine($"result2: {result2}");

                int result3 = nullNum2 ?? nullNum3 ?? num2;
                Console.WriteLine($"result3: {result3}");
            }

            //typeof
            {
                Console.WriteLine($"{typeof(int)}");
                AA aa = new AA();
                Console.WriteLine($"{typeof(AA)}");
                Console.WriteLine($"{aa.GetType()}");

                Console.WriteLine(aa.GetType() == typeof(AA) ? "AA의 객체입니다." : "AA의 객체가 아닙니다.");
            }
        }
    }
}
