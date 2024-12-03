using System;

namespace _027_Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            // Stopwatch - 시간 측정 클래스 -> 시작, 끝, 재시작 기능 있음
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();

            int i = 0;
            for (; i < int.MaxValue; i++)
            {
                if (i == 50000000)
                {
                    break;
                }
                //Console.Write($"{i} ");
            }

            Console.Write($"{i} ");

            if (sw.IsRunning)
            {
                sw.Stop();

                Console.WriteLine($"Time: {sw.ElapsedMilliseconds.ToString()} ms");
                Console.WriteLine($"Time: {sw.Elapsed.ToString()}");
                Console.WriteLine("Time: {0:hh\\:mm\\:ss}", sw.Elapsed);
            }
        }
    }
}
