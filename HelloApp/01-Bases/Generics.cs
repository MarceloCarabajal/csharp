
partial class Program
{
    static void Generics()
    {
        string[] names = { "Alice", "Bob", "Charlie" };
        int[] numbers = { 1, 2, 3, 34, 5 };
        Console.WriteLine($"Length of names array: {GetArrayLength(names)}");
        Console.WriteLine($"Length of numbers array: {GetArrayLength(numbers)}");

        Box<int> numberBox = new Box<int> { Content = 123 };
        Box<string> stringBox = new Box<string> { Content = "Hello Generics" };
        numberBox.Show();
        stringBox.Show();
    }

    // Metodos sin Generics
    // static int GetIntArrayLength(int[] array)
    // {
    //     return array.Length;
    // }

    // static string GetStringArrayLength(string[] array)
    // {
    //     return array.Length.ToString();
    // }

    // Metodo con Generics
    static int GetArrayLength<T>(T[] array)
    {
        return array.Length;
    }
}

// clase generica
class Box<T>
{
    public T? Content { get; set; }

    public void Show()
    {
        Console.WriteLine($"Box contains: {Content}");
    }
}