using System;
using static System.Console;

using static _046_Class_static.AA;

namespace _046_Class_static
{
    //1. 객체를 생성하지 않아도 접근 가능하다.
    class AA
    {
        public int num;
        public static int sNum;
        public static int instanceNum;

        public AA()
        {
            ++instanceNum;
            Console.WriteLine("instanceNum: " + instanceNum);
        }

        public void AddStaticNum()
        {
            ++sNum;
        }

        public void Print()
        {
            Console.WriteLine("num: " + num);
            Console.WriteLine("sNum: " + sNum);
        }

        //static 함수(정적 함수)는 반드시 정적 변수만 사용 가능!!
        public static void StaticPrint()
        {
            //Console.WriteLine("num: " + num); //에러: 정적 변수가 아니므로..
            WriteLine("StaticPrint sNum: " + sNum);
            WriteLine("StaticPrint instanceNum: " + instanceNum);
        }
    }

    class SingletonTest
    {
        private int num;

        //1. 생성자를 private
        private SingletonTest() { num = 0; }

        //2. 객체생성이 유일하다(static)..
        private static SingletonTest instance = null;

        //3. 외부에서 접근이 가능한 함수를 제공..
        public static SingletonTest GetInstance()
        {
            if (instance == null)
            {
                instance = new SingletonTest();
            }

            return instance;
        }

        public void AddNum()
        {
            ++num;
        }

        public void Print()
        {
            Console.WriteLine($"num: {num}");
        }
    }

    //중첩된 정적 메소드
    namespace NameAA
    {
        namespace NameAAA
        {
            public class AAA
            {
                public static void Print()
                {
                    Console.WriteLine("NameAA_AAA_Print");
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //static 기초
            {
                AA.sNum = 1000;

                AA aa1 = new AA();
                AA aa2 = new AA();

                aa1.num = 100;
                aa2.num = 200;

                aa1.AddStaticNum();
                aa1.Print();

                aa2.AddStaticNum();
                aa1.Print();
                aa2.Print();

                StaticPrint();

                AA[] arrayAA = new AA[10];
                arrayAA[0] = new AA();
                arrayAA[1] = new AA();
            }

            //싱글톤 패턴 처리 => 메니저 클래스..
            {
                SingletonTest st1 = SingletonTest.GetInstance();
                SingletonTest st2 = SingletonTest.GetInstance();

                Console.WriteLine("객체가 동일한가? " + st1.Equals(st2));

                st1.AddNum();
                st2.AddNum();

                st1.Print();
                st2.Print();
            }

            {
                SingletonTest st3 = SingletonTest.GetInstance();
                st3.Print();
            }

            {
                NameAA.NameAAA.AAA.Print();
            }
        }
    }
}
