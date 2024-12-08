using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _051_Class_Abstract
{
    abstract class Super
    {
        public int num;
        private int privateNum;
        protected int protectedNum;

        public Super() { }

        public abstract void PrintAbstract(); //상속 받는 곳에서 반드시 재정의 한다.

        private void Print()
        {
            Console.WriteLine("Super::Print()");
        }

        public virtual void PrintVirtual()
        {
            Console.WriteLine("Super::PrintVirtual()");
        }

        //public static abstract void StaticTest() { } //사용 불가
        //public virtual abstract void Test() { }
    }

    class AA : Super
    {
        public AA() : base() { }

        public override void PrintAbstract()
        {
            Console.WriteLine("AA::PrintAbstract()");
        }

        public override void PrintVirtual()
        {
            base.PrintVirtual();
            Console.WriteLine("AA::PrintVirtual()");
        }
    }

    class BB : Super
    {
        public override void PrintAbstract()
        {
            Console.WriteLine("BB::PrintAbstract()");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Super super = new Super(); //추상클래스 abstract클래스는 인스턴스 불가!!

            AA aa = new AA();
            aa.PrintAbstract();
            aa.PrintVirtual();

            Super aa1 = new AA();
            aa1.PrintAbstract();
            aa1.PrintVirtual();

            Super bb = new BB();
            bb.PrintAbstract();
            bb.PrintVirtual();
        }
    }
}
