using System.Runtime.InteropServices;

partial class Program
{
    static void TypeDifference()
    {
        int x = 5;
        int y = x;
        y = 10;
        Console.WriteLine($"x: {x}, y: {y}"); // x: 5, y: 10 

        Person person1 = new Person { Name = "Jorge" };
        Person person2 = person1;
        person2.Name = "Mercedes";
        Console.WriteLine($"person1.Name: {person1.Name}, person2.Name: {person2.Name}"); // person1.Name: Mercedes, person2.Name: Mercedes
    }
}

class Person{
    public string? Name { get; set; }
}