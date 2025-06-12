using TeamApp;


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
            MathService.GetCircleArea();
            break;
        case "2":
            MathService.GetSquareArea();
            break;
        case "3":
            MathService.GetTriangleArea();
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