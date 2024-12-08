using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _055_Class_IS_AS
{
    class Base { }
    class AA : Base { }
    class BB : Base { }

    class Program
    {
        static void Main(string[] args)
        {
            //is기초(bool형 리턴)..
            //is키워드 캐스팅(형변화)을 확인하는 곳에서 사용
            {
                Base b1 = new AA();
                if (b1 is AA)
                {
                    Console.WriteLine("b1은 AA의 객체");
                }

                Base b2 = new Base();
                if (b2 is AA)
                {
                    Console.WriteLine("b2은 AA의 객체");
                }
                else
                {
                    Console.WriteLine("b2은 Base의 객체");
                }
            }

            //is 레퍼런스형이 아니고 밸류형에서도 사용 가능
            {
                int num = 100;
                object oNum = num;
                if (oNum is int)
                {
                    Console.WriteLine("oNum은 int형");
                }

                int? nullNum = null;
                if (nullNum is null)
                {
                    Console.WriteLine("nullNum is null");
                }
            }

            //object기초: 레퍼런스형, 힙영역에 할당
            {
                int a = 100;   //스택영역에 저장..
                object o = a; //boxing => a의 값을 박싱해서 힙에 저장..
                int c = (int)o; //unboxing => o에 값을 언박싱 스택에 저장..

                Console.WriteLine(a);
                Console.WriteLine(o);
                Console.WriteLine(c);
            }

            //as키워드: 캐스팅(형변환)에 사용. 레퍼런스형에만 사용 가능..
            //형변환이 불가하면 null반환..
            {
                object oBase = new Base();
                object oAA = new AA();

                AA aa1 = oAA as AA;
                if (aa1 != null)
                {
                    Console.WriteLine("oAA 캐스팅 성공");
                }

                AA aa2 = oBase as AA;
                if (aa2 != null)
                {
                    Console.WriteLine("oBase 캐스팅 성공");
                }
                else
                {
                    Console.WriteLine("oBase 캐스팅 불가");
                }

                int num = 100;
                //var varNum = num;
                // var varNum= num as int; //레퍼런스형만 가능
            }

            //7.0이상 패턴매칭
            {
                object[] instnaces = { new AA(), new BB(), new Base(), new AA() };

                foreach (var item in instnaces)
                {
                    if (item is AA)
                    {
                        var aa = item as AA;
                        Console.WriteLine(aa.ToString());
                    }

                    if (item is AA pattenAA)  //형변환과정을 줄일 수 있다. ==> 패턴 매칭..
                    {
                        Console.WriteLine(pattenAA.ToString());
                    }
                }
            }
        }
    }
}
