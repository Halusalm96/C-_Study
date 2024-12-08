using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _042__Destructor
{
    class Program
    {
        class AA
        {
            public AA()
            {
                Console.WriteLine("AA 생성자 호출");
            }

            ~AA()
            {
                Console.WriteLine("AA 소멸자 호출");
            }

            public void Print()
            {
                Console.WriteLine("Print");
            }
        }

        //using, 상속, interface..
        class DiposeTest : IDisposable
        {
            public DiposeTest()
            {
                Console.WriteLine("DiposeTest 생성자 호출");
            }

            public void Dispose()
            {
                Console.WriteLine("Dispose 호출");
            }

            public void Print()
            {
                Console.WriteLine("Print");
            }
        }

        static void Main(string[] args)
        {
            {
                AA aa = new AA();
                aa.Print();
            }

            Console.WriteLine("AA 객체 사용 불가!!");

            {
                using (DiposeTest dt = new DiposeTest())
                {
                    dt.Print();
                    Console.WriteLine("DiposeTest 프로그램 실행중. . .");
                }

                Console.WriteLine("DiposeTest 객체 사용 불가!!");
            }

            Console.WriteLine("프로그램 종료");
        }
    }
}
