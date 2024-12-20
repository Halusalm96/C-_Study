using System;

namespace _029_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            // 다차원 배열(2, 3차원)

            // 2차원 ({}전체 인덱스 중, 해당 {}안에 있는 인덱스
            {
                int[,] array2D = new int[,]  //Row, Column(4 * 2)
                {
                    {0, 0},
                    {1, 1},
                    {2, 2},
                    {3, 3},
                };

                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        Console.Write($"[{i}][{j}]: {array2D[i, j]} ");
                    }
                }
            }

            Console.WriteLine();

            {
                int[,,] array3D = new int[,,]
                {
                    //   j           j
                    { {0, 0, 0}, {1, 1, 1} }, //i
                    { {2, 2, 2}, {3, 3, 3} }  //i
                };

                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        for (int k = 0; k < 3; k++)
                        {
                            Console.Write($"[{i}][{j}][{k}]: {array3D[i, j, k]} ");
                        }
                    }
                    Console.WriteLine();
                }
            }

            {
                Console.WriteLine("\n가변 배열");

                int[][] array2D = new int[3][];

                array2D[0] = new int[1];
                array2D[1] = new int[] { 0, 1 };
                array2D[2] = new int[3] { 0, 1, 2 };

                Console.WriteLine(array2D[0][0]);
                Console.WriteLine($"array2D[0].Length: {array2D[0].Length}");

                Console.WriteLine(array2D[1][0]);
                Console.WriteLine(array2D[1][1]);
                Console.WriteLine($"array2D[1].Length: {array2D[1].Length}");

                Console.WriteLine(array2D[2][0]);
                Console.WriteLine(array2D[2][1]);
                Console.WriteLine(array2D[2][2]);
                Console.WriteLine($"array2D[2].Length: {array2D[2].Length}");

                int[][] array2DD = new int[][]
                {
                    new int[]{0, 1, 2, 4},
                    new int[]{1, 2, 4},
                    new int[]{2, 4},
                    new int[]{2}
                };
            }
        }
    }
}
