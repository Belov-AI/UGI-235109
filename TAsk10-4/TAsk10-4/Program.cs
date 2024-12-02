using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAsk10_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Натуральное число n");

            if(!int.TryParse(Console.ReadLine(), out n) || n < 1) 
            {
                Console.WriteLine("Ошибка ввода");
                Console.ReadKey();
                return;
            }

            var sum = 0;

            var temp = n;

            while(temp > 0)
            {
                var digit = temp % 10;
                sum += digit * digit;
                temp /= 10;
            }

            Console.WriteLine($"Сумма квадратов цифр числа {n} равна {sum}");

            Console.ReadKey();
        }
    }
}
