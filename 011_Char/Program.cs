using System;

namespace _011_Char
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 기초
            {
                char chA = 'A';
                char chHan = '한';

                Console.WriteLine($"chA : {chA}");
                Console.WriteLine($"chHan : {chHan}");
            }

            // 타입 크기
            {
                Console.WriteLine("\n 타입 크기");

                char chA = 'A';
                Console.WriteLine($"Type : {typeof(char)} \t Size of : {sizeof(char)} byte");
                Console.WriteLine($"Type : {chA.GetType()}");
            }

            // 저장 크기
            {
                Console.WriteLine("\n 저장 크기");

                int minValue = char.MinValue;
                int maxValue = char.MaxValue;

                Console.WriteLine($"char : {minValue} ~ {maxValue}");
            }

            // 리터럴
            {
                Console.WriteLine("\n 리터럴");

                char ch0 = 'j';
                char ch1 = '\u006A';
                char ch2 = '\x6A';
                char ch3 = (char)106;

                Console.WriteLine($"ch0 : {ch0}");
                Console.WriteLine($"ch1 : {ch1}");
                Console.WriteLine($"ch2 : {ch2}");
                Console.WriteLine($"ch3 : {ch3}");
            }

            // 변환
            {
                Console.WriteLine("\n 변환");

                char chVar = 'A';
                int numCh = chVar;
                Console.WriteLine($"numCh : {numCh}");

                numCh = 66;
                chVar = (char)numCh;
                Console.WriteLine($"chVar : {chVar}");

                int result = chVar + 'B';
                Console.WriteLine($"result : {result}");
            }
        }
    }
}
