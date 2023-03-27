using System;
using RegexValidation;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter PIN code to validate:");
        string pinCode = Console.ReadLine();

        ValidatePinCode validatePinCode = new ValidatePinCode();
        validatePinCode.Validate(pinCode, ValidatePinCode.PIN_CODE);

        Console.WriteLine("Enter Email to validate:");
        string email = Console.ReadLine();

        validatePinCode.ValidateEmail(email);

        Console.ReadKey();
    }
}
