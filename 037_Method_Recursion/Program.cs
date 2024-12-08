using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _037_Method_Recursion
{
    class Program
    {
        //종료 조건에 주의!!
        static uint AddLoop(uint num)
        {
            return (num > 0 ? num + AddLoop(num - 1) : 0);
            /*if(num == 0)
            {
                return 0;
            }
            else
            {
                return num + AddLoop(num - 1); //5 + 4 + 3 + 2 + 1 + 0
            }*/
        }

        static uint AddLoopFor(uint num)
        {
            uint total = 0;

            for (uint i = num; i > 0; i--)
            {
                total += i;
            }

            return total;
        }

        static void SortSelect(int[] numbers, int startIndex)
        {
            if (startIndex >= numbers.Length)
                return;

            var minIndex = startIndex;
            for (int i = startIndex + 1; i < numbers.Length; i++)
            {
                if (numbers[minIndex] > numbers[i])
                {
                    minIndex = i;
                }
            }

            int temp = numbers[startIndex];
            numbers[startIndex] = numbers[minIndex];
            numbers[minIndex] = temp;

            SortSelect(numbers, startIndex + 1);
        }

        static void PrintArray(int[] array)
        {
            foreach (var item in array)
            {
                Console.Write(item + "   ");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("AddLoop: " + AddLoop(5));
            Console.WriteLine("AddLoopFor: " + AddLoopFor(5));

            //Console.WriteLine("AddLoop: " + AddLoop(1000000));
            Console.WriteLine("AddLoop: " + AddLoopFor(1000000));

            int[] array = { 3, 53, 23, 1, 103, 55 };
            PrintArray(array);

            Console.WriteLine();
            SortSelect(array, 3);
            PrintArray(array);

            Console.WriteLine();
            SortSelect(array, 0);
            PrintArray(array);
        }
    }
}
