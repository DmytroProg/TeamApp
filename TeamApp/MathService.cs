namespace TeamApp;

public static class MathService
{
    public static double GetCircleArea(double radius)
    {
        if (radius <= 0)
        {
            throw new ArgumentException("Radius must be a positive number.");
        }
        return Math.PI* radius *radius;
    }
    public static double GetSquareArea(double side)
    {
        if (side <= 0)
        {
            throw new ArgumentException("Side must be a positive number.");
        }
        return side * side;
    }
    public static double GetTriangleArea(double triangleBase, double triangleHeight)
    {
        if (triangleBase <= 0)
        {
            throw new ArgumentException("Base must be a positive number.");
        }

        if (triangleHeight <= 0)
        {
            throw new ArgumentException("Height must be a positive number.");
        }
        return 0.5 * triangleBase * triangleHeight;
    }
}
