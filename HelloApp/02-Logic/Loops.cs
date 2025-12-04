partial class Program
{
    static void Loops()
    {
        // while
        int counter = 1;
        while (counter <= 5)
        {
            WriteLine($"Contador while: {counter}");
            counter++;
        }

        // do while
        int number = 0;
        do
        {
            WriteLine($"Número do while: {number}");
            number++;
        } while (number < 3);

        // for
        for (int i = 0; i <= 5; i++)
        {
            WriteLine($"Contador for: {i}");
        }

        // foreach
        string[] fruits = { "Apple", "Banana", "Cherry" };
        foreach (string fruit in fruits)
        {
            WriteLine($"foreach - Fruit: {fruit}");
        }

        // List
        List<string> names = ["Alice", "Bob", "Charlie"];
        foreach (string name in names)
        {
            WriteLine($"List - Name: {name}");
        }
    }
}