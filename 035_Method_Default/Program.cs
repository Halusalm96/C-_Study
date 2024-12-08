using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _035_Method_Default
{
    class Program
    {
        //디폴트 매개변수
        //static void PrintDefalt(int num1, int num2, string text = "")
        static void PrintDefalt(int num1, int num2 = 0, string text = "")
        {
            Console.WriteLine($"num1: {num1}");
            Console.WriteLine($"num2: {num2}");
            Console.WriteLine($"text: {text}");
        }

        static void Print(string[] arrayString)
        {
            if (arrayString == null) return;

            for (int i = 0; i < arrayString.Length; i++)
            {
                Console.WriteLine($"{i}: {arrayString[i]}");
            }
        }

        static void PrintParam(params string[] arrayString)
        {
            if (arrayString == null) return;

            for (int i = 0; i < arrayString.Length; i++)
            {
                Console.WriteLine($"{i}: {arrayString[i]}");
            }
        }

        static void Main(string[] args)
        {
            //디폴트 매개변수
            {
                PrintDefalt(10);
                PrintDefalt(10, 20);
                PrintDefalt(10, 20, "AAA");
            }

            //명명된 인수
            {
                PrintDefalt(num1: 10);
                PrintDefalt(10, text: "AAAA");
                PrintDefalt(text: "AA", num1: 10);
            }

            //params키워드
            {
                Print(new string[] { "AA", "BB" });
                //Print("AA", "BB");    //에러: 배열은 불가
                //Print();              //에러: 배열을 불가
                Print(null);

                PrintParam(new string[] { "AA", "BB" });
                PrintParam("AA", "BB");
                PrintParam();
                PrintParam(null);
            }
        }
    }
}
