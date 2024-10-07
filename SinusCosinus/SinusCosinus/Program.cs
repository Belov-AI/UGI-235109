using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinusCosinus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double angleInDegees;

            PrintSinusCosinus(15);
            PrintSinusCosinus(37);
            PrintSinusCosinus(113);

            Console.WriteLine();
            Console.WriteLine("Введите значение угла в градусах");
            angleInDegees = double.Parse(Console.ReadLine());
            PrintSinusCosinus(angleInDegees);

            Console.ReadKey();
        }

        private static void PrintSinusCosinus(double angleInDegees)
        {
            double angleInRadians = angleInDegees * Math.PI / 180;
            double sin = Math.Sin(angleInRadians);
            double cos = Math.Cos(angleInRadians);

            Console.WriteLine("sin(" + angleInDegees + "°) = " + Math.Round(sin, 3));
            Console.WriteLine("cos(" + angleInDegees + "°) = " + Math.Round(cos, 3));
        }
    }
}
