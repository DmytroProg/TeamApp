using System.Text.RegularExpressions;

namespace TeamApp
{
    //Напишіть клас валідатор.У класі мають бути методи для валідації пошти, паролю та номеру телефону.
    public static class Validation
    {
        /// <summary>
        /// Validates an email address.
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public static bool IsValidEmail(string email)
        {
            var pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern, RegexOptions.IgnoreCase);
        }



        /// <summary>
        /// Validates a phone number.
        /// </summary>
        /// <param name="phone"></param>
        /// <returns></returns>
        public static bool IsValidPhone(string phone)
        {
            return Regex.IsMatch(phone, @"^\d{10}$");
        }


        /// <summary>
        /// Validates a password.
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public static bool IsValidPassword(string password)
        {
            return Regex.IsMatch(password, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[A-Za-z\d]{8,}$");
        }
    }
}
