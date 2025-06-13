using System.Text.RegularExpressions;

namespace TeamApp;

//expert
public class Validator
{
    public bool IsValidEmail(string email)
    {
        if (string.IsNullOrWhiteSpace(email))
        {
            throw new ArgumentNullException("Email cannot be empty or whitespace.");
        }

        var regex = new Regex(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");

        if (!regex.IsMatch(email))
        {
            throw new ArgumentException("Email must be in a valid format, e.g. user@example.com.");
        }
        return true;
    }
    public bool IsValidPassword(string password)
    {
        if (string.IsNullOrWhiteSpace(password))
        {
            throw new ArgumentNullException("Password cannot be empty or whitespace.");
        }

        var regex = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[!@#$%^&*])[A-Za-z\d!@#$%^&*]{8,}$");

        if (!regex.IsMatch(password))
        {
            throw new ArgumentException("Password must be at least 8 characters long and include at least one uppercase letter, one lowercase letter, one digit, and one special character (!@#$%^&*).");
        }

        return true;
    }
    public bool IsValidPhoneNumber(string phoneNumber)
    {
        if (string.IsNullOrWhiteSpace(phoneNumber))
        {
            throw new ArgumentNullException("Phone number cannot be empty or whitespace.");
        }

        var regex = new Regex(@"^\+\d{1,3}[\s\-()]?\d{1,4}[\s\-()]?(\d{1,4}[\s\-()]?){1,4}\d{1,4}$");

        if (!regex.IsMatch(phoneNumber))
        {
            throw new ArgumentException("Phone number must start with a +country code and contain only digits, spaces, dashes, or parentheses in a valid format.");
        }

        return true;
    }
}
