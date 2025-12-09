partial class Program
{
    static void TestingClass()
    {
        Vehicle toyota = new Vehicle();
        toyota.Brand = "Toyota";
        toyota.Model = "Corolla";
        toyota.Year = 2020;
        toyota.ShowInfo();

        Vehicle honda = new Vehicle{ Brand = "Honda", Model = "Civic", Year = 2019 };
        honda.ShowInfo();

        Vehicle ford = new Vehicle("Ford", "Mustang", 2021);;
        ford.ShowInfo();
    }
}

class Vehicle
{
    //Propiedades
    public string? Brand { get; set; }
    public string? Model { get; set; }
    public int Year { get; set; }
    //Constructor
    public Vehicle(string brand, string model, int year)
    {
        Brand = brand;
        Model = model;
        Year = year;
    }
    public Vehicle() { }
    //Métodos
    public void ShowInfo()
    {
        WriteLine($"Brand: {Brand}, Model: {Model}, Year: {Year}");
    }
}