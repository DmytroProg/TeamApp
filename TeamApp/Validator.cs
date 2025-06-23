using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TeamApp
{
    public static class Validator
    {

        public static bool IsEmailValid(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            string pattern = @"^[\w\.-]+@[\w\.-]+\.\w+$";
            return Regex.IsMatch(email, pattern);
        }


        public static bool IsPasswordValid(string password)
        {
            if (string.IsNullOrWhiteSpace(password))
                return false;

            string pattern = @"^(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,20}$";
            return Regex.IsMatch(password, pattern);
        }


        public static bool IsPhoneNumberValid(string phone)
        {
            if (string.IsNullOrWhiteSpace(phone))
                return false;


            string pattern = @"^\+380\d{9}$";
            return Regex.IsMatch(phone, pattern);
        }
    }
}
