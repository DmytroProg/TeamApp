namespace TeamApp
{
    public class Area​​Figures
    {
        public double AreaTriangle(double baseLength, double height)
        {
            return 0.5 * baseLength * height;
        }


        public double AreaCircle(double radius)
        {
            return Math.PI * radius * radius;
        }

        public double AreaSquare(double sideLength)
        {
            return sideLength * sideLength;
        }
    }
}
