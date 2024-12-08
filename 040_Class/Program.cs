using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _040_Class
{
    public class AA
    {
        //멤버 변수(state)
        public int num;
        public float fNum;
        public string text;

        //멤버 함수(행동)
        public AA()
        {

        }

        public void SetNum(int _num)
        {
            num = _num;
        }

        public void Print()
        {
            Console.WriteLine($"num: {num}  fNum: {fNum}  text: {text}");
        }
    }

    public class Car
    {

    }

    class Program
    {
        static void Main(string[] args)
        {
            AA aa; //레퍼런스 이름 선언(객체X)
            aa = new AA();  //Instance(객체O)

            aa.num = 100;
            aa.SetNum(100);
            aa.Print();

            AA bb = new AA();
            bb.num = 10;
            bb.fNum = 20.0f;
            bb.text = "BB";
            bb.Print();

            Car Sendan = new Car();
            Car coupe, Weagon; //int num1, num2
            Car SUV = new Car(), VEN = new Car();
            Car Hatchback;
            Hatchback = new Car();
        }
    }
}
