using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Errors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numerator, denominator;

            if (!InputNumber("Введите числитель", out numerator))
                return;

            if (!InputNumber("Введите знаменатель", out denominator))
                return;

            Console.WriteLine($"{numerator} / {denominator} = " +
                $"{GetQuotient(numerator, denominator)}");

            Console.ReadKey();
        }

        static bool InputNumber(string message, out int number)
        {
            while (true)
            {
                string input;
                number = 0;


                Console.WriteLine(message + " (Enter - отказ от ввода)");
                input = Console.ReadLine();

                if (input == "")
                    return false;

                if (!int.TryParse(input, out number))
                {
                    Console.WriteLine("Ошибка ввода");
                    continue;
                }
                else
                    break;

            }

            return true;
        }

        static double GetQuotient(int x, int y)
        {
            try
            {
                return (double)x / y;
            }
            catch 
            {
                if (x  > 0)
                    return double.PositiveInfinity;
                else if (x == 0)
                    return 0;
                else
                    return double.NegativeInfinity;
            }            
        }
    }
}
