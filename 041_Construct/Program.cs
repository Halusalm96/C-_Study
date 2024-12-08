using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _041_Construct
{
    class Program
    {
        class AA
        {
            private int num1;
            private string text;

            public AA() //디폴트 생성자
            {
                num1 = 0;
                text = "";
            }

            public AA(int _num1)
            {
                num1 = _num1;
            }

            public AA(int _num1, string _text)
            {
                num1 = _num1;
                text = _text;
            }

            public void Print()
            {
                Console.WriteLine("num1: " + num1);
                Console.WriteLine("text: " + text);
            }
        }

        //생성자는 분석하기 쉽고, 유연하게 코딩할 수 있도록 도움을 준다.
        class BB
        {
            private int num1;
            private int num2;

            public BB() { }

            public BB(int n1, int n2)
            {
                num1 = n1;
                num2 = n2;
            }

            public void SetNum(int n1, int n2)
            {
                num1 = n1;
                num2 = n2;
            }

            public void Print()
            {
                Console.WriteLine("num1: " + num1);
                Console.WriteLine("num2: " + num2);
            }
        }

        class CopyTest
        {
            private int num;
            private string text;

            public CopyTest() { }

            public CopyTest(int n, string t)
            {
                num = n;
                text = t;
            }

            //복사 생성자..
            public CopyTest(CopyTest copyInstance)
            {
                num = copyInstance.num;
                text = copyInstance.text;
            }

            public void SetData(int n, string t)
            {
                num = n;
                text = t;
            }

            public void Print()
            {
                Console.WriteLine($"num: {num}");
                Console.WriteLine($"text: {text}");
            }
        }

        static void Main(string[] args)
        {
            AA aa = new AA(10);
            aa.Print();

            AA aaa = new AA(10, "text");
            aaa.Print();

            BB bb = new BB(10, 10);
            bb.Print();
            bb.SetNum(100, 100);

            CopyTest copyTest = new CopyTest(100, "hello");
            CopyTest cloneTest = new CopyTest(copyTest);

            copyTest.Print();
            cloneTest.Print();

            cloneTest.SetData(5000, "world");
            copyTest.Print();
            cloneTest.Print();

            //copyTest = null;
            //cloneTest.Print();

            Console.WriteLine("\n=== cloneTest2 ====\n");

            CopyTest cloneTest2 = copyTest;
            copyTest.Print();
            cloneTest2.Print();

            cloneTest2.SetData(5000, "world");
            copyTest.Print();
            cloneTest2.Print();

            //copyTest = null;
            //cloneTest2.Print();
        }
    }
}
