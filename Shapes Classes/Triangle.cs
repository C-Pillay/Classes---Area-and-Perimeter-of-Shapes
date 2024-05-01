using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes_Classes
{
    class Triangle
    {
        public static double Area(double tbase, double height)
        {
            return 0.5 * tbase * height;
        }
        public static double Perimeter(double s1, double s2, double s3)
        {
            return s1 + s2 + s3;
        }
    }
}
