
using RegexValidation;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter PIN code to validate:");
        string pinCode = Console.ReadLine();

        ValidatePinCode validatePinCode = new ValidatePinCode();
        validatePinCode.Validation(pinCode);
    }
}






