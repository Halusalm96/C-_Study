using System;

using AA = NameAA.AA; //별명 사용..

using NameBB.subBB;
using BBB = NameBBB.subBBB.BBB;

//namespace기초(class, interface, struct, enum, delegate)
namespace NameAA
{
    public class AA
    {
        public AA()
        {
            Console.WriteLine("NameAA AA Instance");
        }
    }

    struct MyStruct
    {

    }

    enum MyEnum
    {

    }

    delegate void Print();
}

namespace NameAAA
{
    public class AA
    {
        public AA()
        {
            Console.WriteLine("NameAAA AA Instance");
        }
    }
}

namespace NameBB
{
    namespace subBB
    {
        class BB
        {
            public BB()
            {
                Console.WriteLine("NameBB_subBB_BB Instance");
            }
        }
    }
}

namespace NameBBB.subBBB
{
    class BBB
    {
        public BBB()
        {
            Console.WriteLine("NameBBB_subBBB_BBB Instance");
        }
    }
}

namespace _045_Class_namespace
{
    class Program
    {
        static void Main(string[] args)
        {
            //namespace기초
            {
                AA aa1 = new AA();
                NameAAA.AA aa2 = new NameAAA.AA();
            }

            //namespace중첩
            {
                BB bb = new BB();

                BBB bbb = new BBB();
            }
        }
    }
}
