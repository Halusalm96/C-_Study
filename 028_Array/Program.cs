using System;

namespace _028_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //배열의 기초..
            {
                Console.WriteLine("배열의 기초");

                int[] arrays = new int[10]; //[0][1][2] ... [9]

                for (int i = 0; i < arrays.Length; i++)
                {
                    Console.Write($"[{i}]: {arrays[i]} ");
                }
            }

            //배열의 선언 방법
            {
                Console.WriteLine("배열의 선언 방법");

                int[] array1 = { 0, 1, 2, 4 };
                int[] array2 = new int[] { 0, 1, 2, 4 };
                int[] array3;
                array3 = new int[] { 0, 1, 2, 4 };
                //array3 = { 0, 1, 2, 4 }; //에러..

                for (int i = 0; i < array1.Length; i++)
                {
                    Console.Write($"[{i}]: {array1[i]} ");
                }
                Console.WriteLine();

                for (int i = 0; i < array2.Length; i++)
                {
                    Console.Write($"[{i}]: {array2[i]} ");
                }
                Console.WriteLine();

                for (int i = 0; i < array3.Length; i++)
                {
                    Console.Write($"[{i}]: {array3[i]} ");
                }
            }

            //배열에서 지원되는 함수
            {
                Console.WriteLine("\n 배열에서 지원되는 함수");

                int[] numbers = { 50, 36, 99, 67 };
                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.Write($"[{i}]: {numbers[i]} ");
                }

                Console.WriteLine("\n 배열 복사");
                int[] copyNumbers;
                copyNumbers = (int[])numbers.Clone();

                for (int i = 0; i < copyNumbers.Length; i++)
                {
                    Console.Write($"[{i}]: {copyNumbers[i]} ");
                }

                Console.WriteLine("\n 배열 정렬");
                Array.Sort(numbers);
                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.Write($"[{i}]: {numbers[i]} ");
                }

                Console.WriteLine("\n 배열 Copyto");
                int[] copyNumber3 = new int[10];
                numbers.CopyTo(copyNumber3, 3);
                for (int i = 0; i < copyNumber3.Length; i++)
                {
                    Console.Write($"[{i}]: {copyNumber3[i]} ");
                }

                Console.WriteLine("\n 배열 초기화");
                Array.Clear(numbers, 0, numbers.Length);
                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.Write($"[{i}]: {numbers[i]} ");
                }
            }

            //foreach
            {
                Console.WriteLine("\n foreach");

                int[] nums = new int[5] { 0, 1, 3, 4, 5 };

                foreach (var item in nums)
                {
                    //item = 1000; //에러..
                    Console.Write($"item: {item} ");
                }

                Console.WriteLine("\n for");
                for (int i = 0; i < nums.Length; i++)
                {
                    nums[i] = i * 100;
                    Console.Write($"nums: {nums[i]} ");
                }
            }
        }
    }
}
