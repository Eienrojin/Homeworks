using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Matrix matrix = new Matrix(3, 3);

            InitRandomValues(matrix.values);

            Console.WriteLine("Исходная матрица");
            matrix.PrintMatrix(matrix.values);

            Console.ReadKey();
        }

        static double InitRandomValues(double[,] array)
        {
            Random random = new Random();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i,j] = random.Next(1, 10);
                    return array[i, j];
                }
            }
        }
    }
}
