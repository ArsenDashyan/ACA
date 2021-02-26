using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork3
{
    class Matrix
    {
        public static void PrintArray(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        public static void Print((int,int) tupl, int w, int h)
        {
            Console.SetCursorPosition(tupl.Item1,tupl.Item2);
            Console.Write('*');
            for (int i = 0; i < h; i++)
            {
                Console.SetCursorPosition(tupl.Item1 +i, tupl.Item2);
                Console.Write('*');
            }
            for (int i = 0; i < w; i++)
            {
                Console.SetCursorPosition(tupl.Item1, tupl.Item2+i);
                Console.Write('*');
            }
            for (int i = 0; i < h; i++)
            {
                Console.SetCursorPosition(tupl.Item1 + i, tupl.Item2+w);
                Console.Write('*');
            }
            for (int i = 0; i < w; i++)
            {
                Console.SetCursorPosition(tupl.Item1+h, tupl.Item2 + i);
                Console.Write('*');
            }
        }
        public static void PrintArray(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + "   ");
            }
            Console.WriteLine();
        }

        #region Lower Triangular Matrix
        public static int[,] LowerTriaMat(int[,] arr)
        {
            int[,] arrNew = new int[arr.GetLength(0), arr.GetLength(1)];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (i < j)
                        arrNew[i, j] = 0;
                    else
                        arrNew[i, j] = arr[i, j];
                }
            }
            return arrNew;
        }

        #endregion

        #region Merge Array

        public static int[] GetNewArray(int[] arr1, int[] arr2)
        {
            int[] max = MaxArray(arr1, arr2);
            int[] min = MinArray(arr1, arr2);
            int[] newArr = new int[max.Length];
            int count = 0;
            while (count != max.Length)
            {
                for (int i = 0; i < min.Length; i++)
                {
                    newArr[count] = min[i];
                    count++;
                    if (count == max.Length)
                    {
                        break;
                    }
                }
            }
            return newArr;
        }
        public static int[] MergeArray(int[] arr1, int[] arr2)
        {
            int[] max = MaxArray(arr1, arr2);
            int[] result = new int[max.Length];
            if (arr1.Length < arr2.Length)
            {
                int[] newArr = GetNewArray(arr1, arr2);
                for (int i = 0; i < arr2.Length; i++)
                {
                    result[i] = newArr[i] + arr2[i];
                }
                return result;
            }
            else
            {
                int[] newArr = GetNewArray(arr1, arr2);
                for (int i = 0; i < arr1.Length; i++)
                {
                    result[i] = newArr[i] + arr1[i];
                }
                return result;
            }
        }
        public static int[] MaxArray(int[] arr1, int[] arr2)
        {
            if (arr1.Length < arr2.Length)
            {
                return arr2;
            }
            else
            {
                return arr1;
            }
        }
        public static int[] MinArray(int[] arr1, int[] arr2)
        {
            if (arr1.Length > arr2.Length)
            {
                return arr2;
            }
            else
            {
                return arr1;
            }
        }

        #endregion

        #region Delete element from Array

        public static int[] DeleteElement(int[] arr, int index)
        {
            int[] result = new int[arr.Length - 1];
            if (index <= arr.Length)
            {
                for (int i = 0; i < index; i++)
                {
                    result[i] = arr[i];
                }
                for (int i = index + 1; i < arr.Length; i++)
                {
                    result[i-1] = arr[i];
                }
            }
            else
            {
                Console.WriteLine("Index out of range");
                return arr;
            }
            return result;
        }

        #endregion

        #region Rectangles

        public static void Overlapping()
        {
            int widht = 3;
            int height = 7;
            var tupl = (3, 5);
            
        }

        #endregion

    }
}
