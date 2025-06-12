namespace TeamApp
{
    public class Area​​Figures
    {
        static public double AreaTriangle(double baseLength, double height)
        {
            return 0.5 * baseLength * height;
        }


        static public double AreaCircle(double radius)
        {
            return Math.PI * radius * radius;
        }


        static public double AreaSquare(double sideLength)
        {
            return sideLength * sideLength;
        }
    }
}
