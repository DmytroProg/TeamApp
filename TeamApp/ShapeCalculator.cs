using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamApp;

public class ShapeCalculator
{
    public double CalculateCircleArea (double radius)
    {
        if (radius < 0)
        {
            throw new ArgumentException("nop. sob.");
        }
        return 3.14 * radius * radius;
    }
    public double CalculateSquareArea(double side)
    {
        if (side < 0)
            throw new ArgumentException("nop. sob.");
        return side * side; 
    }
    public double CalculateTriangleArea(double baseLength, double height)
    {
        if (baseLength < 0 || height < 0)
            throw new ArgumentException("nop. sob.");
        return 0.5 * baseLength * height;
    }
}
