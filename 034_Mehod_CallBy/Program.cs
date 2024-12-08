using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _034_Mehod_CallBy
{
    class Program
    {
        static public void SwapValue(int num1, int num2)
        {
            int temp = num1;
            num1 = num2;
            num2 = temp;

            Console.Write("SwapValue: ");
            Print(num1, num2);
        }

        static public void SwapRef(ref int num1, ref int num2)
        {
            int temp = num1;
            num1 = num2;
            num2 = temp;

            Console.Write("SwapRef: ");
            Print(num1, num2);
        }

        static public void Print(int num1, int num2)
        {
            Console.WriteLine($"num1: {num1}  num2: {num2}");
        }

        public struct sData
        {
            public int _num1;
            public int _num2;

            public sData(int num1, int num2)
            {
                _num1 = num1;
                _num2 = num2;
            }
        }

        static void SwapStructValue(sData s1, sData s2)
        {
            sData temp = s1;
            s1 = s2;
            s2 = temp;

            PrintStruct(s1, s2);
        }

        static void SwapStructRef(ref sData s1, ref sData s2)
        {
            sData temp = s1;
            s1 = s2;
            s2 = temp;

            PrintStruct(s1, s2);
        }

        static public void PrintStruct(sData s1, sData s2)
        {
            Console.WriteLine($"s1: {s1._num1} s1:{s1._num2}");
            Console.WriteLine($"s2: {s2._num1} s2:{s2._num2}");
        }

        static void Main(string[] args)
        {
            {
                int num1 = 100;
                int num2 = 500;

                SwapValue(num1, num2);
                Print(num1, num2);

                SwapRef(ref num1, ref num2);
                Print(num1, num2);
            }

            {
                sData s1 = new sData(0, 0);
                sData s2 = new sData(500, 500);

                SwapStructValue(s1, s2);
                PrintStruct(s1, s2);

                SwapStructRef(ref s1, ref s2);
                PrintStruct(s1, s2);
            }
        }
    }
}
