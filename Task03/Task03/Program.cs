using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вваедите двузначное число");
            var number = int.Parse(Console.ReadLine());

            var units = number % 10;
            var tenths = number / 10;
            var result = number * 100 + units * 10 + tenths;

            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
