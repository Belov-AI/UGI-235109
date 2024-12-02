using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество филиалов компании");
            int n;

            if (!TryInputNumber(out n))
            {
                Console.ReadKey();
                return;
            }

            int maxIncome = int.MinValue;
            string maxIncomeDeparment = "";

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Введите название филиала");
                var department = Console.ReadLine();
                Console.WriteLine("Введите годовой доход филиала");

                int income;
                if(!TryInputNumber(out income))
                {
                    Console.ReadKey();
                    return;
                }

                if(income > maxIncome)
                {
                    maxIncome = income;
                    maxIncomeDeparment = department;
                }
            }

            Console.WriteLine($"Филиал {maxIncomeDeparment} имеет наибольий годовой доход {maxIncome} руб.");

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
