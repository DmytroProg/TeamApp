namespace TeamApp;

public static class MathService
{
    public static void GetCircleArea()
    {
        Console.Write("\nEnter circle radius: ");
        if (!double.TryParse(Console.ReadLine(), out double radius))
        {
            Console.WriteLine("\nEnter valid radius!\n");
        }

        Console.WriteLine($"\nCircle area: {Math.PI * radius * radius}\n");
    }
    public static void GetSquareArea()
    {
        Console.Write("\nEnter square side: ");
        if (!double.TryParse(Console.ReadLine(), out double side))
        {
            Console.WriteLine("\nEnter valid side!\n");
        }
        Console.WriteLine($"\nSquare area: {side * side}\n");
    }
    public static void GetTriangleArea()
    {
        Console.Write("\nEnter the base of the triangle: ");
        if (!double.TryParse(Console.ReadLine(), out double triangleBase))
        {
            Console.WriteLine("\nEnter valid base!\n");
        }
        Console.Write("\nEnter the height of the triangle: ");
        if (!double.TryParse(Console.ReadLine(), out double triangleHeight))
        {
            Console.WriteLine("\nEnter valid height!\n");
        }
        Console.WriteLine($"\nTriangle area: {0.5 * triangleBase * triangleHeight}\n");
    }
}
