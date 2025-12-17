partial class Program
{
    static void HandleNullable()
    {
        // No nullificable
        string firstName = "Carlos";
        // Nullificable
        string? lastName = null;

        Console.WriteLine($"First Name: {firstName}");
        if (lastName != null)
        {
            Console.WriteLine($"Last Name: {lastName}");
        }
        else
        {
            Console.WriteLine("Last Name is null");
        }
        // Using null-coalescing operator
        Console.WriteLine($"Last Name (with ??): {lastName ?? "No last name provided"}");
        // Operador de acceso nulo seguro ?.
        string? text = null;
        Console.WriteLine($"Text length: {text?.Length ?? 0}");
    }
}