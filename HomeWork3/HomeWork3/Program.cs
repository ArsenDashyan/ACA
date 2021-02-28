using System;

namespace HomeWork3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            Matrix.PrintArray(array);

            Console.WriteLine(new string('-', 20));

            var arr = Matrix.LowerTriaMat(array);
            Matrix.PrintArray(arr);

            Console.WriteLine(new string('-', 20));

            int[] array1 = new int[] { 1, 2, 3, 4, 7, 8, 9, };
            Matrix.PrintArray(array1);

            int[] arr2 = new int[] { 4, 3, 7, 8, 9, 1, 0 };
            int[] arr1 = new int[] { 4, 5, 6 };
            int[] arr3 = Matrix.GetNewArray(arr2, arr1);
            Matrix.PrintArray(arr3);

            var res = Matrix.MergeArray(arr1, array1);
            Matrix.PrintArray(res);

            Console.WriteLine(new string('-', 20));

            var arr4 = Matrix.DeleteElement(array1, 6);
            Matrix.PrintArray(arr4);

            Console.WriteLine(new string('-', 20));


            Console.ReadLine();
        }
    }
}
