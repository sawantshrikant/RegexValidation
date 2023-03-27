using System;
using System.Text.RegularExpressions;

namespace RegexValidation
{
    public class ValidatePinCode
    {
        public const string PIN_CODE = "^[1-9]{1}[0-9]{2}\\s{0,1}[0-9]{3}$";

        public void Validate(string input, string regexPattern)
        {
            if (string.IsNullOrEmpty(input))
            {
                throw new ArgumentException("Input cannot be null or empty.");
            }

            Regex regex = new Regex(regexPattern);

            if (regex.IsMatch(input))
            {
                Console.WriteLine("Validation successful.");
            }
            else
            {
                Console.WriteLine("Validation unsuccessful.");
            }
        }

        public void ValidateEmail(string email)
        {
            Regex regex = new Regex("^[0-9a-zA-Z]+[.+-_]{0,1}[0-9a-zA-Z]+[@][a-zA-Z]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,3}){0,1}");

            if (string.IsNullOrEmpty(email))
            {
                throw new ArgumentException("Email cannot be null or empty.");
            }

            if (regex.IsMatch(email))
            {
                Console.WriteLine("Email validation successful.");
            }
            else
            {
                Console.WriteLine("Email validation unsuccessful.");
            }
        }
    }
}
