// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


Console.WriteLine("New commit");

static void ShowMenu()
{
    Console.Write("1.Get all hero\n2.Get hero by id\n3.Get all episode\n4.Get all episode order by name\n5.Exit\nSelect option: ");
}

while (true)
{
    ShowMenu();
    var option = Console.ReadLine();

}