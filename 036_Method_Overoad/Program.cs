using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _036_Method_Overoad
{
    class Program
    {
        //오버로드
        //- 함수의 이름이 동일하다.
        //- 파라미터의 수 또는 파라미터의 자료형이 다른 경우 성립
        //- 리턴 데이터는 다른 경우라도 성립X
        static void SumInt(int a, int b)
        {
            Console.WriteLine($"SumInt: {a + b}");
        }

        static void SumFloat(float a, float b)
        {
            Console.WriteLine($"SumFloat: {a + b}");
        }

        static void Sum(int a, int b)
        {
            Console.WriteLine($"Sum: {a + b}");
        }

        static void Sum(float a, float b)
        {
            Console.WriteLine($"Sum: {a + b}");
        }

        struct SPlayer
        {
            int level;
            int exp;
            string name;

            public SPlayer(int _lv, int _exp)
            {
                level = _lv;
                exp = _exp;
                name = "";
            }

            public SPlayer(int _lv, int _exp = 10, string _name = "AA")
            {
                level = _lv;
                exp = _exp;
                name = _name;
            }

            public void Print()
            {
                Console.WriteLine($"level: {level} exp: {exp} name: {name}");
            }

            public int Print(string text)
            {
                Console.WriteLine(text);
                Console.WriteLine($"level: {level} exp: {exp} name: {name}");
                return 0;
            }
        }

        static void Main(string[] args)
        {
            SumInt(10, 10);
            SumFloat(10.0f, 10.01f);

            Sum(10, 10);
            Sum(10.0f, 10.01f);

            SPlayer player = new SPlayer(10, 100);
            player.Print();

            SPlayer player1 = new SPlayer(10);
            player1.Print();
            player1.Print("Result");
        }
    }
}
