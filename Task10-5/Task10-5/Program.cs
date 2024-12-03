using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите натуральное число");

            int number;

            if(!int.TryParse(Console.ReadLine(), out number) || number < 1) 
            {
                Console.WriteLine("Ошибка ввода");
                Console.ReadKey();
                return;
            }

            Console.Write($"Делители {number}: ");

            //в общем случае делители будут найдены не в порядке возрастания,
            //зато количество итераций существенно сократится:
            //если n = ab и a <= b, то a <= sqrt(n)

            var sqrtN = Math.Sqrt(number); //вычислим заранее верхнюю границу для делителя,
                                           //чтобы не вычислять её при каждой проверке
                                           //условия выхода из цикла

            for(var a = 1; a <= sqrtN; a++)
            {
                if(number % a == 0)
                {
                    var b = number / a;
                    if (b != a)
                        Console.Write($"{a}, {b}, ");
                    else
                        Console.Write($"{a}, ");
                }
            }

            Console.WriteLine("\b\b "); //стираем запятую после последнего делителя

            Console.ReadKey();
        }
    }
}
