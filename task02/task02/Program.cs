using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину большого основания трапеции");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите длину малого основания трапеции");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите угол при основании трапеции в градусах");
            double alpha = Math.PI * double.Parse(Console.ReadLine()) / 180;

            double x = (a - b) / 2;
            double h = x * Math.Tan(alpha);
            double s = (a+ b) * h / 2;
            double y = x / Math.Cos(alpha);
            double p = 2 * y + a + b;

            Console.WriteLine("Площадь трапеции: " + Math.Round(s, 3));
            Console.WriteLine("Периметр трапеции: " + Math.Round(p, 3));

            Console.ReadKey();
        }
    }
}
