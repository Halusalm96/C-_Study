using System;

namespace _009_Var
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // var - 지역 변수로만 사용 가능 / 클래스 안에서, 함수의 반환형, 함수의 파라미터, null 초기값 으로 사용 불가

            var numVar = 100;
            var numFVar = 0.00314f;

            Console.WriteLine($"numVar : {numVar}");
            Console.WriteLine($"numFVar : {numFVar}");
        }
    }
}
