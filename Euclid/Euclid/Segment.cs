using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Euclid
{
    public class Segment
    {
        public Point A;
        public Point B;

        public Segment(Point a, Point b)
        { 
            A = a;
            B = b;
        }

        public double Length => 
            Math.Sqrt((A.X - B.X) * (A.X - B.X) +
            (A.Y - B.Y) * (A.Y - B.Y));
    }
}
