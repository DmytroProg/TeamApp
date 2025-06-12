namespace TeamApp
{
    public class Area​​Figures
    {
        static public double AreaTriangle(double baseLength, double height)
        {
            if (baseLength < 0 || height < 0)
            {
                throw new ArgumentException("Base length and height must be non-negative.");
            }
            return 0.5 * baseLength * height;
        }


        static public double AreaCircle(double radius)
        {
            if (radius < 0)
            {
                throw new ArgumentException("Radius must be non-negative.");
            }
            return Math.PI * radius * radius;
        }


        static public double AreaSquare(double sideLength)
        {
            if (sideLength < 0)
            {
                throw new ArgumentException("Side length must be non-negative.");
            }
            return sideLength * sideLength;
        }
    }
}
