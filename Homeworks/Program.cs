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

            matrix.InitRandomValues();

            Console.WriteLine("Исходная матрица");
            matrix.PrintMatrix(matrix.Values);

            Console.ReadKey();
        }
    }
}
