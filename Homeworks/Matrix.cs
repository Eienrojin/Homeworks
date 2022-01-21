using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworks
{
    internal class Matrix
    {
        public double[,] values { get; set; }

        public Matrix(int columns, int rows)
        {
            Columns = columns;
            Rows = rows;

            double[,] values = new double[Rows, Columns];
        }

        public int Columns { get; set; }
        public int Rows { get; set; }
        public double[,] MatrixValues { get; set; }

        public void PrintMatrix(double[,] values)
        {
            for (int i = 0; i < Columns; i++)
            {
                for (int j = 0; j < Rows; j++)
                {
                    Console.Write($"{values[i, j]}\t");
                }
                Console.WriteLine();
            }
        }
    }
}
