using System;

namespace _013_ReadLine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 기초
            {
                Console.Write("문장을 입력하세요 : ");
                var inputData = Console.ReadLine();
                Console.WriteLine($"입력한 값 : {inputData}");
                Console.WriteLine($"Type : {inputData.GetType()}");
            }

            // ReadLinej - 입력한 값을 가져오지만 string으로 가져와 숫자를 입력받고 싶을 시 변환 필요.
            {
                Console.Write("정수를 입력하세요 : ");
                var strNum1 = Console.ReadLine();
                Console.Write("정수를 입력하세요 : ");
                var strNum2 = Console.ReadLine();
                Console.WriteLine($"입력한 값 : 1번 - {strNum1} / 2번 - {strNum2}");

                var num1 = int.Parse(strNum1);
                var num2 = Convert.ToInt32(strNum2);
                Console.WriteLine($"num1 : {num1} / Type : {num1.GetType()}");
                Console.WriteLine($"num2 : {num2} / Type : {num2.GetType()}");
            }

            // Read - 맵앞에 문자 혹은 숫자만 가져온다.
            {
                Console.Write("문자를 입력하세요 : ");
                var readVar = Console.Read();
                Console.WriteLine($"입력한 문자 : {readVar} Type : {readVar.GetType()}");
                Console.WriteLine($"입력한 문자 : {(char)readVar}");
            }

            // ReadKey
            {
                ConsoleKeyInfo info;

                Console.Write("키를 누르세요 : ");
                info = Console.ReadKey();
                Console.WriteLine($"\n입력한 키는 : {info.Key}");

                // 보이고 싶지 않을 때
                Console.Write("키를 누르세요 : ");
                info = Console.ReadKey(true);
                Console.WriteLine($"\n입력한 키는 : {info.Key}");

                Console.Write("키를 누르세요 : ");
                info = Console.ReadKey(false);
                Console.WriteLine($"\n입력한 키는 : {info.Key}");

                Console.WriteLine($"\n입력한 키는 : {info.KeyChar}");
                Console.WriteLine($"\n입력한 키는 : {info.Modifiers}");
            }
        }
    }
}
