using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sum = 0;
            int sign = 1;
            int number = 0;

            do
            {
                Console.WriteLine("Введите очередной член последовательности");
                if(!TryInputNumber(out number))
                {
                    Console.ReadKey();
                    return;
                }

                sum += number * sign;
                sign *= -1;

            } while (number != 0);

            Console.WriteLine($"Знакочередующаяся сумма равна {sum}");

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
