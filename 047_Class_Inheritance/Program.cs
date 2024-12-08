using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _047_Class_Inheritance
{
    class BaseAA
    {
        private string privateText;
        protected string protectedText;
        public int num;
        protected int testNum;

        public BaseAA()
        {
            privateText = "BaseAA privateText";
            Console.WriteLine("BaseAA");
        }

        public BaseAA(int num) : this()
        {
            Console.WriteLine("BaseAA(int num)");
            this.num = num;
        }

        protected void PrintprotectedText()
        {
            Console.WriteLine("protectedText: " + protectedText);
        }

        private void PrintprivateText()
        {
            Console.WriteLine("privateText: " + privateText);
        }

        protected void Printprotected()
        {
            Console.WriteLine("privateText: " + privateText);
        }

        public void Print()
        {
            Console.WriteLine("num: " + num);
        }

        public void SetTestNum(int n)
        {
            if (n >= 100)
            {
                Console.WriteLine("반드시 입력값을 100보다 작은 값을 넣어주세요.");
                return;
            }

            testNum = n;
        }

        public int GetTestNum()
        {
            return testNum;
        }
    }

    class AA : BaseAA
    {
        public AA()
        {
        }

        public AA(int num) : base(num)
        {
            protectedText = "protectedText - AA";
        }

        public void PrintprotectedTextAA()
        {
            base.PrintprotectedText();
            base.Printprotected();
        }
    }

    class BB : BaseAA
    {
        public BB(int num) : base(num)
        {
            protectedText = "protectedText - BB";
        }

        public void PrintprotectedTextAA()
        {
            base.PrintprotectedText();
            base.Printprotected();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //클래스 상속 기초
            {
                AA aa = new AA(100);
                aa.PrintprotectedTextAA();

                BB bb = new BB(3000);
                bb.PrintprotectedTextAA();
            }

            //접근 지정자 테스트..
            {
                AA aa = new AA();
                aa.Print();

                aa.SetTestNum(99);
                Console.WriteLine(aa.GetTestNum());

                BB bb = new BB(10);
                bb.SetTestNum(10);
                Console.WriteLine(bb.GetTestNum());
            }
        }
    }
}
