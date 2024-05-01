using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes_Classes
{
    class Circle
    {
        public static double Area(double radius)
        {
            return Math.Pow(radius, 2) * Math.PI;
        }
        public static double Circumefrence(double radius)
        {
            return radius * 2 * Math.PI;
        }
    }
}
