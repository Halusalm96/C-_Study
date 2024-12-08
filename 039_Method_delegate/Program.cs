using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _039_Method_delegate
{
    class Program
    {
        delegate void DelegatePrint();

        static void PrintHello()
        {
            Console.WriteLine("PrintHello");
        }

        static void PrintValue()
        {
            Console.WriteLine("PrintValue");
        }

        delegate void DelegatePrintSum(int a, int b);
        static void PrintSum(int a, int b)
        {
            Console.WriteLine("PrintSum: " + (a + b));
        }

        static void TestDelegate(int a, int b, DelegatePrintSum dSum)
        {
            Console.WriteLine("a: " + a + "  b: " + b);

            if (dSum != null)
            {
                Console.Write("TestDelegate ");
                dSum(a, b);
            }
        }

        static void Main(string[] args)
        {
            {
                //int num
                DelegatePrint dPrint = null;
                dPrint = PrintHello;
                dPrint();

                dPrint = PrintValue;
                dPrint();
            }

            {
                Console.WriteLine("멀티 캐스트 +=");

                DelegatePrint dPrint1 = PrintHello;
                dPrint1 += PrintValue;
                dPrint1 += PrintHello;
                dPrint1 += PrintHello;
                dPrint1();

                Console.WriteLine("멀티 캐스트 -=");
                dPrint1 -= PrintValue;
                dPrint1();
            }

            {
                Console.WriteLine("멀티 캐스트 Combine");
                DelegatePrint combineDelegate = (DelegatePrint)Delegate.Combine(new DelegatePrint[] { PrintValue, PrintHello, PrintValue });
                combineDelegate();

                Console.WriteLine("멀티 캐스트 Combine2");
                DelegatePrint aa = PrintHello;
                DelegatePrint bb = PrintValue;
                DelegatePrint cc = PrintHello;

                DelegatePrint combineDelegate2 = (DelegatePrint)Delegate.Combine(aa, bb, cc);
                combineDelegate2();

                Console.WriteLine("멀티 캐스트 Remove");
                DelegatePrint combineDelegate3 = (DelegatePrint)Delegate.Remove(combineDelegate2, bb);
                combineDelegate3();
            }

            DelegatePrintSum dPrintSum = PrintSum;
            dPrintSum(10, 10);

            {
                void Sum(int a, int b)
                {
                    Console.Write("Sum:" + (a + b));
                }

                TestDelegate(10, 20, Sum);
            }
        }
    }
}
