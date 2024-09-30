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
            double angleInDegees = 15;
            double angleInRadians = angleInDegees * Math.PI / 180;
            double sin = Math.Sin(angleInRadians);
            double cos = Math.Cos(angleInRadians);

            Console.WriteLine("sin(15°) = " + Math.Round(sin, 3));
            Console.WriteLine("cos(15°) = " + Math.Round(cos, 3));

            angleInDegees = 37;
            angleInRadians = angleInDegees * Math.PI / 180;
            sin = Math.Sin(angleInRadians);
            cos = Math.Cos(angleInRadians);

            Console.WriteLine("sin(37°) = " + Math.Round(sin, 3));
            Console.WriteLine("cos(37°) = " + Math.Round(cos, 3));

            angleInDegees = 113;
            angleInRadians = angleInDegees * Math.PI / 180;
            sin = Math.Sin(angleInRadians);
            cos = Math.Cos(angleInRadians);

            Console.WriteLine("sin(113°) = " + Math.Round(sin, 3));
            Console.WriteLine("cos(113°) = " + Math.Round(cos, 3));

            Console.WriteLine();
            Console.WriteLine("Введите значение угла в градусах");
            angleInDegees = double.Parse(Console.ReadLine());

            angleInRadians = angleInDegees * Math.PI / 180;
            sin = Math.Sin(angleInRadians);
            cos = Math.Cos(angleInRadians);

            Console.WriteLine("sin(" + angleInDegees + "°) = " + Math.Round(sin, 3));
            Console.WriteLine("cos(" + angleInDegees + "°)) = " + Math.Round(cos, 3));

            Console.ReadKey();
        }
    }
}
