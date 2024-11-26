using System;

namespace _010_Nullable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Nullable - null이 사용 가능하게 만든다.
            //int? num = null;
            //double? dNum = null;

            int? num = 100;
            double? dNum = 3112312.1445d;

            Console.WriteLine($"num : {num}");
            Console.WriteLine($"num : {num.Value}");
            Console.WriteLine($"num : {num.HasValue}");
            Console.WriteLine($"num : {num.GetType()}");

            // 디폴트?? 값을 가져온다??
            Console.WriteLine($"num : {num.GetValueOrDefault()}");

            Console.WriteLine($"dNum : {dNum}");
            Console.WriteLine($"dNum : {dNum.Value}");
            Console.WriteLine($"dNum : {dNum.HasValue}");
            Console.WriteLine($"dNum : {dNum.GetType()}");

            num = null;
            Console.WriteLine($"num : {num.HasValue}");

            if (num != null)
                Console.WriteLine($"num : {num.GetType()}");

            // 변환
            {
                int? nullNum = 100;
                int numCast = (int)nullNum;

                Console.WriteLine($"nullNum : {numCast}"); 
            }
        }
    }
}