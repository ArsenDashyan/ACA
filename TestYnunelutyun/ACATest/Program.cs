using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ACATest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            int[,] array = new int[,] { {1,2,3 }, {4,5,6 },{7,8,9 } };
            GetReflectionArray(array);

            Console.WriteLine(new string('-', 20));

            Console.WriteLine($"Թվի թվանշանների գումարը, մինչև ստացվի միանիշ թիվ - {GetNumberDigitSumRekursive(67)}\n");

            Console.WriteLine(new string('-', 20));

            int[] arr = new int[] { 12, 3, 4, 7, 8, 9, 34, 56, -3, -45, -6, 0 };
            GetMinItemArray(arr);

            Console.WriteLine(new string('-', 20));

            int[] arr1 = new int[] { 1, 12, -5, -6, 50, 3 };
            Console.WriteLine(GetSubarrayMaxAverageValue(arr1, 4));

            Console.ReadLine();
        }

        #region Xndir 1

        public static void GetReflectionArray(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[j, i] + " ");
                }
                Console.WriteLine();
            }
        }

        #endregion

        #region Xndir 2
        public static int GetNumberDigitSumRekursive(int num)
        {
            int res = 0, sum = 0;
            List<int> list = new List<int>();

            while (num != 0)
            {
                list.Add(num % 10);
                num = (num - num % 10) / 10;
            }
            foreach (var item in list)
            {
                sum += item;
            }
            if (sum - sum % 10 != 0)
            {
                res = GetNumberDigitSumRekursive(sum);
            }
            else
            {
                res = sum;
            }
            return res;
        }

        private static int GetNumberItemSum(int sum)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Xndir 3

        public static void GetMinItemArray(int[] arr)
        {
            int min = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (min > arr[i])
                {
                    min = arr[i];
                }
            }
            Console.WriteLine($"Array min item is {min}");
        }

        #endregion

        #region Xndir 4
        public static double GetSubarrayMaxAverageValue(int[] arr, int count)
        {
            List<int> list = new List<int>();
            double res = 0;

            if (count < arr.Length)
            {
                for (int i = 0; i < arr.Length - count + 1; i++)
                {
                    int j = i, sum = 0;
                    while (j < count + i)
                    {
                        sum += arr[j];
                        j++;
                    }
                    list.Add(sum);
                }
                res = (double)list.Max() / count;
            }
            else 
            {
                Console.WriteLine("Նշված քանակը գերազանցում է զանգվածի չափը!!!");
            }

            return res;
        }
        #endregion


    }
}
