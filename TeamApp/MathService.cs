namespace TeamApp;

public class MathService
{
    public double GetCircleArea(double r)
    {
        return Math.PI * r * r;
    }
    public double GetSquareArea(double a)
    {
        return a * a;
    }
    public double GetTriangleArea(double a,double h)
    {
        return 0.5 * a * h;
    }
}
