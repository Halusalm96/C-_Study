using System;

namespace _012_WriteLine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 12345;
            float fNum = 0.01234153f;
            double dNum = 123456789.0;

            Console.WriteLine("{0}, {1}, {2}", num, fNum, dNum);
            Console.WriteLine("{0:D}, {0:D8}, {0:D3}", num);
            Console.WriteLine("{0}, {0:F}, {0:F3}, {0:F12}", fNum);
            Console.WriteLine("{0}, {0:E}, {0:E5}", dNum);
            Console.WriteLine("0x{0:X}", num);

            Console.WriteLine("{0:C3}, {1}", num, num.ToString("C"));
            Console.WriteLine("{0:N}, {0:N1}, {0:N3}", num);
            Console.WriteLine("{0:N}, {0:P1}, {0:P3}", num);

            double d1 = 12345.67891;
            Console.WriteLine($"{d1:##.##}");
            Console.WriteLine($"{d1:#.###}");
            Console.WriteLine($"{d1:0.00}");

            double d2 = 123456.78;
            Console.WriteLine($"{d2:#,##0.0} {d2:#,#}");

            double d3 = 11012345678;
            Console.WriteLine($"{d3:(###) ####-####}");
            double d4 = 01012345678;
            Console.WriteLine($"{d4:(0##) ####-####}");

        }
    }
}
