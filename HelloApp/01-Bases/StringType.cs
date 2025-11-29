partial class Program {
    static void ShowStringTypes() {
        string name = "Juan";
        string message = "Hello, " + name + "!";
        string interpolatedMessage = $"Hello, {name}! Welcome to C# programming.";
        Console.WriteLine(message);
        Console.WriteLine(interpolatedMessage);

        Console.WriteLine($"Tu nombre tiene {name.Length} caracteres.");
        Console.WriteLine($"Tu nombre en mayúsculas es {name.ToUpper()}.");
        Console.WriteLine($"Tu nombre en minúsculas es {name.ToLower()}.");

        int number = 13;
        Console.WriteLine(number.ToString());
        bool isString = true;
        Console.WriteLine(isString.ToString());
    }
}