using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число a");
            int a;

            if(!TryInputNumber(out a))
            {
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Введите целое число b");
            int b;

            if(!TryInputNumber(out b))
            {
                Console.ReadKey();
                return;
            }

            if(a <= 0 || a > b)
            {
                Console.WriteLine("Числа не удовлетворяют неравенству 0 < a <= b");
                Console.ReadKey();
                return;
            }

            var product = 1;

            for (int i = a; i <= b; i++)
                product *= i;

            Console.WriteLine($"Произведение чисел от {a} до {b} равно {product}");

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
    }
}
