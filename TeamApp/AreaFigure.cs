namespace TeamApp
{
    public static class Area​​Figures
    {

        /// <summary>
        /// Calculates the area of a triangle given its base length and height.
        /// </summary>
        /// <param name="baseLength"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public static double AreaTriangle(double baseLength, double height)
        {
            if (baseLength < 0 || height < 0)
            {
                throw new ArgumentException("Base length and height must be non-negative.");
            }
            return 0.5 * baseLength * height;
        }


        /// <summary>
        /// Calculates the area of a circle given its radius.
        /// </summary>
        /// <param name="radius">The radius of the circle. Must be non-negative.</param>
        /// <returns>The area of the circle as a <see cref="double"/>.</returns>
        /// <exception cref="ArgumentException">Thrown if <paramref name="radius"/> is negative.</exception>
        public static double AreaCircle(double radius)
        {
            if (radius < 0)
            {
                throw new ArgumentException("Radius must be non-negative.");
            }
            return Math.PI * radius * radius;
        }

        /// <summary>
        /// Calculates the area of a square given the length of its side.
        /// </summary>
        /// <param name="sideLength">The length of one side of the square. Must be non-negative.</param>
        /// <returns>The area of the square, calculated as the square of <paramref name="sideLength"/>.</returns>
        /// <exception cref="ArgumentException">Thrown if <paramref name="sideLength"/> is negative.</exception>
        public static double AreaSquare(double sideLength)
        {
            if (sideLength < 0)
            {
                throw new ArgumentException("Side length must be non-negative.");
            }
            return sideLength * sideLength;
        }
    }
}
