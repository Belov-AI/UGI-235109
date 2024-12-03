using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            if (!TryInputNumber("Введите число n", out n))
            {
                Console.ReadKey();
                return;
            }
            
            if(n < 1)
            {
                Console.WriteLine("Число n должно быть натуральным");
                Console.ReadKey();
                return;
            }

            int k = 0;
            if (!TryInputNumber("Введите число k", out k))
            {
                Console.ReadKey();
                return;
            }

            if (k < 1)
            {
                Console.WriteLine("Число k должно быть натуральным");
                Console.ReadKey();
                return;
            }

            int counter = 0;

            for(var number = 1; number <= n; number++)
            {
                var temp = number;
                var sum = 0;

                while (temp > 0)
                {
                    sum += temp % 10;
                    temp /= 10;
                }

                //будем печатать числа в строку через запятую
                if (sum == k)
                {
                    Console.Write($"{number}, ");
                    counter++; //считаем, сколько чисел нашли
                }
                    
            }

            if (counter == 0)
                Console.WriteLine($"Натуральных чисел, не превосходящих  {n} с суммой цифр {k} нет");
            else 
                Console.WriteLine("\b\b "); //стираем последнюю запятую

            Console.ReadKey();
        }

        static bool TryInputNumber(string message, out int number)
        {
            Console.WriteLine(message);
            var input = Console.ReadLine();

            if (!int.TryParse(input, out number))
            {
                Console.WriteLine("Ошибка ввода");
                return false;
            }

            return true;
        }
    }
}
