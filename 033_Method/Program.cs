using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _033_Method
{
    class Program
    {
        //파라미터X, 리턴X
        static void PrintHello()
        {
            Console.WriteLine("Hello World");
            Console.WriteLine("11");
            Console.WriteLine("2");
            Console.WriteLine("3");
        }

        //파라미터O, 리턴X
        static void PrintValue(int x)
        {
            Console.WriteLine($"PrintValue: {x}");
        }

        static void Sum(int x, int y)
        {
            Console.WriteLine($"Sum: {x + y}");
        }

        //파라미터X, 리턴O
        static int GetMaxInt()
        {
            return int.MaxValue;
        }

        //파라미터O, 리턴O
        static int ReturnSum(int x, int y)
        {
            int total = x + y;
            return total;
        }

        struct SSudent
        {
            int _id;
            string _name;

            public SSudent(int id, string name)
            {
                _id = id;
                _name = name;
            }

            public int GetID()
            {
                return _id;
            }

            public string GetName()
            {
                return _name;
            }

            public void SetID(int id)
            {
                _id = id;
            }

            public void SetName(string name)
            {
                _name = name;
            }

            public void PrintData()
            {
                Console.WriteLine($"id: {_id}  name: {_name}");
            }
        }

        static void Main(string[] args)
        {
            PrintHello();
            PrintValue(10);

            Sum(10, 20);

            int maxValue = GetMaxInt();
            Console.WriteLine($"maxValue: {maxValue}");

            int sumValue = ReturnSum(10, 100);
            Console.WriteLine($"sumValue: {sumValue}");

            SSudent[] students = new SSudent[3];

            foreach (var item in students)
            {
                item.PrintData();
            }

            students[0].SetID(0);
            students[0].SetName("aa");

            students[1] = new SSudent(1, "bb");
            students[2] = new SSudent(2, "cc");

            foreach (var item in students)
            {
                item.PrintData();
            }
        }
    }
}
