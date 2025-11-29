partial class Program
{
    static void DataStructures()
    {
        User pepe = new User { Id = 1, Name = "Pepe", Age = 30 };
        pepe.Greet();

        Point point = new Point { X = 10, Y = 20 };
        point.Display();

        CellPhone phone = new CellPhone("iPhone", 2020);
        Console.WriteLine($"CellPhone Model: {phone.Model}, Year: {phone.Year}");
    }
}

// Clases
class User
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public int Age { get; set; }

    public void Greet()
    {
        Console.WriteLine($"Hello, my name is {Name} and I am {Age} years old.");
    }
}

// Estructuras "Structs"
struct Point
{
    public int X { get; set; }
    public int Y { get; set; }

    public void Display()
    {
        Console.WriteLine($"Point coordinates: ({X}, {Y})");
    }
}

// Record
record CellPhone(string Model, int Year);