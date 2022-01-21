using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
ВАРИАНТ 4 (16 по списку)
Описать класс, реализующий тип данных «вещественная матрица». 
Реализовать вычитание строки заданного номера из всех остальных строк, кроме данной строки. 
*/

namespace Homeworks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Matrix matrix = new Matrix(3, 3);
            Matrix matrix1 = new Matrix(2, 4);

            matrix.InitRandomValues();
            matrix1.InitRandomValues();

            Console.WriteLine("Исходная матрица 1");
            matrix.PrintMatrix();

            Console.WriteLine("Исходная матрица 2");
            matrix1.PrintMatrix();

            matrix.Values = matrix.subtrMatrix(3); //третья колонка, а не вторая
            matrix1.Values = matrix1.subtrMatrix(1);

            Console.WriteLine("Измененная матрица 1");
            matrix.PrintMatrix();

            Console.WriteLine("Измененная матрица 2");
            matrix1.PrintMatrix();

            Console.ReadKey();
        }
    }
}
