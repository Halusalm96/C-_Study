using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _031_String
{
    class Program
    {
        static void Main(string[] args)
        {
            //문자열 기초
            {
                char[] str = { 'a', 'b', 'c', 'd' }; //"abcd".ToCharArray();
                for (int i = 0; i < str.Length; i++)
                {
                    Console.Write($"{str[i]}");
                }
            }

            //레퍼런스 체크하기.
            //레퍼런스 = 메모리 위치
            /*  값 타입 vs 참조 타입:
                    값 타입은 데이터를 직접 저장합니다.
                        예: int, float, bool
                        값 타입끼리 복사하면, 값 자체를 복사합니다.
                    참조 타입은 데이터의 메모리 위치를 저장합니다.
                        예: string, class, array
                        참조 타입끼리 복사하면, 동일한 메모리 위치를 참조합니다. */

            {
                Console.Write("\n  레퍼런스 체크하기\n");

                string str1 = "abcdefgh"; //""리터럴..
                string str2 = str1;
                // 일치하는지 판단
                if (Object.ReferenceEquals(str1, str2))
                {
                    Console.WriteLine("동일한 레퍼런스");
                }

                int num1 = 100;
                int num2 = num1;
                if (Object.ReferenceEquals(num1, num2))
                {
                    Console.WriteLine("동일한 레퍼런스");
                }
                else
                {
                    Console.WriteLine("동일한 레퍼런스 아님");
                }
            }

            {
                Console.Write("\n String 기초\n");

                string str1 = "Hello World";
                Console.WriteLine($"{str1}");

                //초기화 방법
                char[] ch1 = { 'H', 'e', 'l', 'l', 'o', ' ', 'W', 'o', 'r', 'l', 'd' };
                string str2 = new string(ch1);

                //==
                if (str1 == str2)
                {
                    Console.WriteLine("str1 == str2");
                }

                //Equals
                if (str1.Equals(str2))
                {
                    Console.WriteLine("str1 Equals str2");
                }

                Console.WriteLine($"str1.Length: {str1.Length}");
                Console.WriteLine($"str1.GetType(): {str1.GetType()}");
                Console.WriteLine($"+= : {str2 += "HHHHH"}");

                var str3 = string.Format("{0} {1} {2} {0}", "Hi", "Hello", "Goold");
                Console.WriteLine($"str3: {str3}");

                string str4 = "c:/user/document/hello.cs";

                //파일이름 hello.cs가 필요(Substring)
                int lastIndex = str4.LastIndexOf("/") + 1;
                Console.WriteLine($"Substring: {str4.Substring(lastIndex, (str4.Length - lastIndex))}");
                Console.WriteLine($"lastIndex: {lastIndex} str4.Length - lastIndex: {str4.Length - lastIndex}");

                string str5 = "abcdefghijk";
                Console.WriteLine($"str5: {str5}");
                if (str5.Contains("d") || str5.Contains("i"))
                {
                    str5 = str5.Replace("d", " ");
                    str5 = str5.Replace("i", " ");
                }
                Console.WriteLine($"Replace str5: {str5}");
                Console.WriteLine($"ToUpper str5: {str5.ToUpper()}");

                string trimStr5 = str5.Trim(); //앞뒤 공백 제거만 중간에 있는것은 유지디된다.
                Console.WriteLine($"Trim str5: {trimStr5}");

                string whiteSpaceStr = trimStr5.Replace(" ", "");
                Console.WriteLine($"whiteSpaceStr: {whiteSpaceStr}");

                string str6 = "AA, BB, CC, DD, EE";
                string[] arrayStrs = str6.Split(',');
                for (int i = 0; i < arrayStrs.Length; i++)
                {
                    {
                        Console.Write($"{arrayStrs[i]} ");
                    }
                }
            }
        }
    }
}
