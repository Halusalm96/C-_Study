using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _053_Class_Interface
{
    interface IAA
    {
        //int num; //멤버 변수..
        int num { get; set; }

        //void Print() { }           //함수의 정의만 가능
        //public void Print();      //접근 지정자도 사용 불가.. 8.0이상부터는 가능..
        void Print();
    }

    class AA : IAA
    {
        public int num { get; set; }

        public void Print()
        {
            Console.WriteLine("AA::Print()");
        }
    }

    class MyEqual : IEquatable<MyEqual>
    {
        public int num1;
        public int num2;

        public MyEqual(int num1, int num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }

        public bool Equals(MyEqual other)
        {
            return (this.num1 == other.num1 && this.num2 == other.num2);
        }
    }

    class DD : IAA, IDisposable
    {
        public DD()
        {
            Console.WriteLine("DD 인스턴스 생성..");
        }

        public int num { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Dispose()
        {
            Console.WriteLine("DD 인스턴스 소멸..");
        }

        public void Print()
        {
            throw new NotImplementedException();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            AA aa = new AA();
            aa.Print();

            IAA iaa = new AA();
            iaa.Print();

            {
                MyEqual m1 = new MyEqual(10, 10);
                MyEqual m2 = new MyEqual(10, 20);
                MyEqual m3 = new MyEqual(10, 10);

                Console.WriteLine("m1.Equals(m2): " + m1.Equals(m2));
                Console.WriteLine("m1.Equals(m3): " + m1.Equals(m3));
            }

            {
                using (DD dd = new DD())
                {
                    Console.WriteLine("실행중. . . .");
                }

                Console.WriteLine("실행 완료. . . .");
            }
        }
    }
}
