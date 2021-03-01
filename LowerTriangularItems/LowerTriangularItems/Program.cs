using System;

namespace LowerTriangularItems
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            Matrix.Print(array);

            Console.WriteLine(new string('-',20));

            var arr = Matrix.GetLowTri(array);
            Matrix.Print(arr);

            Console.ReadLine();
        }
    }
}
