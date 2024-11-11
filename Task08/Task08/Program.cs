using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение аргумента функции");
            var x = double.Parse(Console.ReadLine());

            Console.WriteLine($"f({x} = {MyFunction(x)}");

            Console.ReadKey();
        }

        static double MyFunction(double x)
        {
            double result;

            if (x < -1)
                result = Math.Atan(x);
            else if (x > 1)
                result = 1 / x;
            else
                result = Math.Acos(x);
            
            return result;
        }
    }
}
