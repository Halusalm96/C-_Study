using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//1. 동일한 이름의 파라미터를 사용하는 경우..
//2. 객체를 파라미터로 가지는 경우..
//3. 자신의 인스턴스를 리턴값으로 가지는 경우..
//4. 생성자를 호출하는 this..
namespace _044_Class_this
{
    class Program
    {
        class AA
        {
            private int num1, num2;

            public AA(int num1) //1. 동일한 이름의 파라미터를 사용하는 경우..
            {
                this.num1 = num1;
            }

            public AA(int num1, int num2) : this(num1) //4. 생성자를 호출하는 this..
            {
                this.num2 = num2;

                BB bb = new BB(this); //2. 객체를 파라미터로 가지는 경우..
            }

            public AA GetInstance() //3. 자신의 인스턴스를 리턴값으로 가지는 경우..
            {
                return this;
            }

            public void SetData(int num1, int num2)
            {
                this.num1 = num1;
                this.num2 = num2;
            }

            public void Print()
            {
                Console.WriteLine($"num1: {num1},  num2: {num2}");
            }
        }

        class BB
        {
            AA aa;

            public BB(AA aa)
            {
                Console.WriteLine("BB객체에서 AA의 인스턴스 참조");
                this.aa = aa;
            }
        }

        static void Main(string[] args)
        {
            {
                AA aa = new AA(10, 10);
                aa.Print();
            }

            {
                AA aa1 = new AA(100, 100);
                AA aa2 = aa1.GetInstance();

                aa1.Print();
                aa2.Print();

                aa2.SetData(5000, 5000);
                aa1.Print();
                aa2.Print();
            }
        }
    }
}
