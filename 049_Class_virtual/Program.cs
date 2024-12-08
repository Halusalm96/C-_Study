using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _049_Class_virtual
{
    //vitual기초(가상함수 기초)
    class Super
    {
        public Super() { }
        public virtual void Print()
        {
            Console.WriteLine("Super::Print()");
        }

        public virtual void HelloWorld()
        {
            Console.WriteLine("Super::HelloWorld()");
        }

        public virtual int GetNum()
        {
            Console.WriteLine("Super::GetNum()");
            return 0;
        }

        public void TestMethod()
        {
            Console.WriteLine("Super::TestMethod()");
        }

        //public static virtual void Method() { }   //static은 불가
        //private virtual void Test() { }               //private접근 지정자 사용불가..
    }

    class AA : Super
    {
        public AA() : base()
        {

        }

        public override void Print()
        {
            //base.Print();
            Console.WriteLine("AA::Print()");
        }

        public override void HelloWorld()
        {
            //base.HelloWorld();
            Console.WriteLine("AA::HelloWorld()");
        }

        public override int GetNum()
        {
            //return base.GetNum();
            Console.WriteLine("AA::GetNum()");
            return 1000;
        }
    }

    class BB : Super
    {
        public BB() : base()
        {
        }
        public override void Print()
        {
            //base.Print();
            Console.WriteLine("BB::Print()");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Super aa1 = new Super();
            aa1.Print();

            Super aa2 = new AA();
            aa2.Print();
            aa2.HelloWorld();
            int num = aa2.GetNum();
            Console.WriteLine("num: " + num);
            aa2.TestMethod();

            //결론: 하나의 데이터로 처리가 가능하다.
            {
                AA[] instancesAA = { new AA(), new AA(), new AA(), new AA() };
                BB[] instancesBB = { new BB(), new BB(), new BB(), new BB() };

                foreach (var item in instancesAA)
                {
                    item.Print();
                }

                foreach (var item in instancesBB)
                {
                    item.Print();
                }

                Super[] instances = { new AA(), new AA(), new AA(), new AA(), new BB(), new BB(), new BB(), new BB() };

                foreach (var item in instances)
                {
                    item.Print();
                }
            }
        }
    }
}
