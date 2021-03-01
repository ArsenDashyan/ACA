using System;

namespace LowerTriangularItems
{
    class Matrix
    {
        public static int[][] GetLowTri(int[,] array)
        {
            if (array.GetLength(0) == array.GetLength(1))
            {
                int[][] result = new int[array.GetLength(1)][];

                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j <= i; j++)
                    {
                        result[i] = new int[j + 1];
                    }
                }
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j <= i; j++)
                    {
                        result[i][j] = array[i, j];
                    }
                }
                return result;
            }
            else
            {
                Console.WriteLine("Non correct matrix");
                return null;
            }
            
        }

        public static void Print(int[][] arr)
        {
            foreach (var arrItem in arr)
            {
                foreach (var item in arrItem)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            }
        }
        public static void Print(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i,j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
