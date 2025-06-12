using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamApp
{
    public class AreaCalculator
    {   
        public double CalculateCircleArea(double radius)
        {
            return Math.PI * radius * radius;
        }

        public double CalculateSquareArea(double side)
        {
            return side * side;
        }

        public double CalculateTriangleArea(double Base, double height)
        {
            return 0.5 * Base * height;
        }
    }
}
