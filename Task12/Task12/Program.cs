using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число m от 5 до 20");
            int m;

            if (!TryInputNumber(out m))
            {
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Введите целое число n от 5 до 20");
            int n;

            if (!TryInputNumber(out n))
            {
                Console.ReadKey();
                return;
            }

            if (m < 5 || m > 20 || n < 5 || n > 20 )
            {
                Console.WriteLine("Числа не удовлетворяют неравенству 5 <= m,n <= 20");
                Console.ReadKey();
                return;
            }

            Console.WriteLine();

            var matrix = new int[m, n];

            var rnd = new Random();

            for (int i = 0; i< matrix.GetLength(0); i++)
                for (int j = 0; j< matrix.GetLength(1); j++)
                    matrix[i, j] = rnd.Next(100);

            PrintMatrix(matrix);
            Console.WriteLine();

            var columnIndex = GetIndexOfColumnWithMinimalLastElement(matrix);

            if (columnIndex < 0)
                Console.WriteLine("Нет столбца, удовлетворяющего условию задачи");
            else
                Console.WriteLine($"Столбец с индексом {columnIndex} подходит");

            Console.WriteLine();

            var diff = GetMaxMinDifferecies(matrix);

            for (int i = 0; i < diff.Length; i++)
                Console.WriteLine($"Строка {i} - разность равна {diff[i]}");

            Console.ReadKey();
        }

        static bool TryInputNumber(out int number)
        {
            number = 0;
            if (!int.TryParse(Console.ReadLine(), out int n))
            {
                Console.WriteLine("Ошибка ввода");
                return false;
            }

            number = n;
            return true;
        }

        static void PrintMatrix(int[,] matrix)
        {
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                    Console.Write($"{matrix[i,j],2} ");

                Console.WriteLine();
            }
        }

        static int GetIndexOfColumnWithMinimalLastElement(int[,] matrix)
        {
            var index = -1;

            for (var j = 0; j < matrix.GetLength(1); j++)
            {
                var isBadCoumn = false;
                for(var i = 0; i < matrix.GetLength(0) - 1; i++)
                    if (matrix[i, j] < matrix[matrix.GetLength(0) - 1, j])
                    {
                        isBadCoumn = true;
                        break;
                    }

                if(isBadCoumn)
                    continue;
                else
                {
                    index = j;
                    break;
                }
            }

            return index;
        }

        static int[] GetMaxMinDifferecies(int[,] matrix)
        {
            var result = new int[matrix.GetLength(0)];

            for(var i = 0; i<matrix.GetLength(0); i++)
            {
                var min = int.MaxValue;
                var max = int.MinValue;

                for(var j = 0;j < matrix.GetLength(1); j++)
                {
                    if (matrix[i,j] < min)
                        min = matrix[i,j];

                    if (matrix[i,j] > max)
                        max = matrix[i,j];
                }

                result[i] = max - min;
            }


            return result;
        }
    }
}
