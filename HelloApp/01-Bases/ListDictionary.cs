partial class Program
{
    static void ListDictionary()
    {
        List<string> names = new List<string>{"Tom", "Bob", "Alice"};
        names.Add("Sam");

        Console.WriteLine($"Total de nombres: {names.Count}");
        foreach (var name in names)
        {
            Console.WriteLine(name);
        }
        names.Remove("Bob");
        bool isPresent = names.Contains("Bob");
        Console.WriteLine($"¿Está Bob en la lista? {isPresent}");

        // Diccionario
        Dictionary<int, string> students = new Dictionary<int, string>
        {
            {1, "Tom"},
            {2, "Bob"},
            {3, "Alice"}
        };
        Console.WriteLine($"El estudiante con ID 2 es: {students[2]}");
        foreach (var student in students)
        {
            Console.WriteLine($"ID: {student.Key}, Name: {student.Value}");
        }
    }
}