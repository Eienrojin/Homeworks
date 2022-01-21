using System;

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
            /// <summary>
            /// Принимает значение от единицы до последней колонки матрицы
            /// </summary>

            row -= 1; //уменьшение значения, чтобы отчет был не от нуля

            for (int i = 0; i < values.GetLength(0); i++)
            {
                for (int j = 0; j < values.GetLength(1); j++)
                {
                    if (i == row)
                    {
                        continue;
                    }
                    else
                    {
                        Values[i, j] = Values[i, j] - Values[row, j];
                    }
                }
            }

            return Values;
        }
    }
}
