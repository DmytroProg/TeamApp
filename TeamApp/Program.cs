
using TeamApp;

var service = new MathService();

while (true)
{
    ShowMenu();
    var option = Console.ReadLine();

    switch (option)
    {
        default:
            Console.WriteLine("\nSelect valid option!\n");
            break;
        case "1":
            Console.Write("\nEnter circle radius: ");
            if (!double.TryParse(Console.ReadLine(), out double radius))
            {
                Console.WriteLine("\nEnter valid radius!\n");
            }
            var circleArea = service.GetCircleArea(radius);
            Console.WriteLine($"\nCircle area: {circleArea}\n");
            break;
        case "2":
            Console.Write("\nEnter square side: ");
            if (!double.TryParse(Console.ReadLine(), out double side))
            {
                Console.WriteLine("\nEnter valid side!\n");
            }
            var squareArea = service.GetSquareArea(side);
            Console.WriteLine($"\nSquare area: {squareArea}\n");
            break;
        case "3":
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
            var triangleArea = service.GetTriangleArea(triangleBase, triangleHeight);
            Console.WriteLine($"\nTriangle area: {triangleArea}\n");
            break;
        case "4":
            Console.WriteLine("\nBye-bye...");
            return;
    }
}
static void ShowMenu()
{
    Console.Write("1.Get Circle Area\n2.Get Square Area\n3.Get Triangle Area\n4.Exit\nSelect option: ");
}