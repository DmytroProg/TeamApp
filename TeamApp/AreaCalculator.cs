using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamApp
{
    public static class AreaCalculator
    {
        public static double  CalculateCircleArea(double radius)
        {
            return Math.PI * radius * radius;
        }

        public static double CalculateSquareArea(double side)
        {
            return side * side;
        }

        public static double CalculateTriangleArea(double Base, double height)
        {
            return 0.5 * Base * height;
        }
    }
}
