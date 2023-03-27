﻿using System;
using System.Text.RegularExpressions;

namespace RegexValidation
{
    public class ValidatePinCode
    {
        public void Validation(string pincode)
        {
            Regex regex = new Regex(@"^\d{3}(?:-?\d{3})?");

            if (string.IsNullOrEmpty(pincode))
            {
                throw new ArgumentException("PIN code cannot be null or empty.");
            }

            if (regex.IsMatch(pincode))
            {
                Console.WriteLine("Validation successful.");
            }
            else
            {
                Console.WriteLine("Validation unsuccessful.");
            }
        }
    }
}
