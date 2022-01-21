using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworks
{
    internal class Matrix
    {
        private double[,] values;

        public Matrix(int columns, int rows)
        {
            Columns = columns;
            Rows = rows;

            values = new double[Rows, Columns];
        }

        public int Columns { get; set; }
        public int Rows { get; set; }
        public double[,] Values { get => values; set => values = value; }

        public void PrintMatrix()
        {
            for (int i = 0; i < values.GetLength(0); i++)
            {
                for (int j = 0; j < values.GetLength(1); j++)
                {
                    Console.Write($"{values[i, j]}\t");
                }
                Console.WriteLine();
            }
        }
        public void InitRandomValues()
        {
            Random random = new Random();

            for (int i = 0; i < values.GetLength(0); i++)
            {
                for (int j = 0; j < values.GetLength(1); j++)
                {
                    Values[i, j] = random.Next(1, 10);
                }
            }
        }

        //Вычитание как написано в задании
        public double[,] subtrMatrix(int row)
        {
            double[,] tempMatrix = values;
            row -= 1; //уменьшение значения, чтобы отчет был не от нуля
            
            for (int i = 0; i < values.GetLength(0); i++)
            {
                for (int j = 0;j < values.GetLength(1); j++)
                {
                    if (values[i, j] == values[row, j])
                    {
                        continue;
                    }
                    else
                    {
                        values[i, j] = values[i, j] - values[row, j];
                    }
                }
            }

            return tempMatrix;
        }
    }
}
