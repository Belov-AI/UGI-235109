using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число элементов массива");

            int n;

            if (!int.TryParse(Console.ReadLine(), out n) || n < 0)
            {
                Console.WriteLine("Ошибка ввода");
                Console.ReadKey();
                return;
            }

            var numbers = new double[n];
            var rnd = new Random();

            for (int i = 0; i < numbers.Length; i++)
                numbers[i] = rnd.NextDouble();

            PrintArray(numbers);

            NormalizeArray(numbers);
            PrintArray(numbers);

            Console.WriteLine($"Сумма произведений a[i] * i равна {CalculalateSumOfProducts(numbers)}");

            PrintArray(GetAveragePartialSquaresSums(numbers));
            
            Console.ReadKey();
        }

        static void PrintArray(double[] array)
        {
            foreach (var element in array)
                Console.Write($"{element:F4} ");

            Console.WriteLine();
        }

        static void NormalizeArray(double[] array)
        {
            if (array.Length == 0)
                return;

            double sum = 0;

            foreach (var element in array)
                sum += element;

            if (sum == 0)
                return;

            for (int i = 0;i < array.Length;i++)
                array[i] /= sum;
        }

        static double CalculalateSumOfProducts(double[] array)
        {
            double result = 0;

            for(var i = 0; i < array.Length;i++)
                result += array[i] * i;

            return result;
        }

        static double[] GetAveragePartialSquaresSums(double[] array)
        {
            if(array.Length == 0)
                return new double[0];

            double[] result = new double[array.Length];
            double partialSum = 0;

            for (var k = 0; k < array.Length; k++)
            {
                partialSum += array[k] * array[k];
                result[k] = partialSum / (k + 1);
            }

            return result;
        }
    }
}
