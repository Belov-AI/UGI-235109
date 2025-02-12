using Euclid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuclidConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var p = new Point() { X = 1, Y = 2 };

            var q = new Point();
            q.X = -1;
            q.Y = 3;

            PrintPoint(p);
            PrintPoint(q);
            
            PrintPoint(new Point(5, 6));

            var s = new Segment(p, q);

            Console.WriteLine(s.Length);

            Console.ReadKey();
        }

        static void PrintPoint(Point point)
        {
            Console.WriteLine($"Точка ({point.X}; {point.Y})");
        }
    }
}
