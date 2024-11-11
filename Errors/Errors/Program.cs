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
            Console.WriteLine("Введите числитель");
            var numerator = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите знаменатель");
            var denominator = int.Parse(Console.ReadLine());

            Console.WriteLine($"{numerator} / {denominator} = {GetQuotient(denominator, denominator)}");

            Console.ReadKey();
        }

        static double GetQuotient(int x, int y)
        {
            try
            {
                return x / y;
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
