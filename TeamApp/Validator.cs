using System.Text.RegularExpressions;

namespace TeamApp;

//expert
public static class Validator
{
    public static bool IsEmailValid(string email)
    {
        var regex = new Regex(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");

        return regex.IsMatch(email);
    }
    public static bool IsPasswordValid(string password)
    {
        var regex = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[!@#$%^&*])[A-Za-z\d!@#$%^&*]{8,}$");

        return regex.IsMatch(password);
    }
    public static bool IsPhoneNumberValid(string phoneNumber)
    {
        var regex = new Regex(@"^\+\d{1,3}[\s\-()]?\d{1,4}[\s\-()]?(\d{1,4}[\s\-()]?){1,4}\d{1,4}$");

        return regex.IsMatch(phoneNumber);
    }
}
// hello? how are you?
