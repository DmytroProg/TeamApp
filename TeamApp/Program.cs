using TeamApp;
/*Console.WriteLine("New commit");

Console.WriteLine("Hello world!");
Console.WriteLine("New commit");
Console.WriteLine("123");
static void ShowMenu()
{
    Console.Write("1.Get all hero\n2.Get hero by id\n3.Get all episode\n4.Get all episode order by name\n5.Exit\nSelect option: ");
}

Console.WriteLine("New text");

while (true)
{
    ShowMenu();
    var option = Console.ReadLine();

}*/


string phone = "+380964103615";
Console.WriteLine(Validator.IsPhoneNumberValid(phone));

string password = "Password1!";
Console.WriteLine(Validator.IsPasswordValid(password));

string email = "example@gmail.com";
Console.WriteLine(Validator.IsEmailValid(email));