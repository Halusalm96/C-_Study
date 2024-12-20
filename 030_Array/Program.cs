using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _030_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //                0     1    2      3    4    5
            char[] Tiles = { '─', '┼', '□', '★', '○', ' ' };

            // 2차 함수
            int[][] Maps =
            {
                // 2차 배열 선언
                new int[] {1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
                new int[] {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                new int[] {1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
                new int[] {5, 2, 4, 5, 5, 1, 1, 5, 5, 5, 3, 5, 5, 1, 1, 1, 1, 5, 5, 5},
                new int[] {1, 1, 1, 1, 5, 5, 5, 5, 5, 5, 1, 1, 1, 5, 5, 5, 5, 5, 1, 1},
                new int[] {1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 5, 5, 5, 3, 2},
                new int[] {1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
                new int[] {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
            };

            for (int i = 0; i < Maps.Length; i++)
            {
                for (int j = 0; j < Maps[i].Length; j++)
                {
                    Console.Write($"{Tiles[Maps[i][j]]}");
                }
                Console.WriteLine();
            }
        }
    }
}
