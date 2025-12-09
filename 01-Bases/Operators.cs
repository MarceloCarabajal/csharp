partial class Program
{
    static void Operators()
    {
        int number = 6;
        bool isEven = number % 2 == 0;
        bool isGreaterThanTen = number > 10;

        if(isEven && isGreaterThanTen)
        {
            Console.WriteLine($"{number} is even and greater than 10.");
        }
        else if(isEven || isGreaterThanTen)
        {
            Console.WriteLine($"{number} is either even or greater than 10.");
        }
        else
        {
            Console.WriteLine($"{number} is neither even nor greater than 10.");
        }

        // Operador ternario
        int age = 21;
        string category = age >= 18 ? "Adult" : "Minor";
        Console.WriteLine($"Age category: {category}");
    }
}