partial class Program
{
    static void Methods()
    {
        Car car = new Car();
        car.Model = "Yaris";
        car.Year = 2022;
        WriteLine(car.ShowInfo());
        // car.ShowMessage();
        // car.ShowMessage("Bienvenido a su nuevo automovil.");
        // car.ChangeModel("Corolla");
        // WriteLine(car.ShowInfo());
        // Car.GenerateInfo();

        // Un constructor
        Car sportCar = new Car("Mustang", 2021);
        WriteLine(sportCar.ShowInfo());

        // sintaxis simplificada
        Car collectionCar = new Car { Model = "Camaro", Year = 2020 };
        WriteLine(collectionCar.ShowInfo());

        // lista de objetos
        WriteLine("\nLista de automoviles:");
        List<Car> cars = new()
        {
            new Car() { Model = "Fiesta", Year = 2018 },
            new Car() { Model = "Focus", Year = 2019 },
            new Car() { Model = "Explorer", Year = 2020} 
        };
        foreach (var c in cars)
        {
            WriteLine(c.ShowInfo());
        }
    }
}

class Car
{
    public string? Model { get; set; }
    public int? Year { get; set; }

    // Constructor con parametros opcionales
    public Car(string? model = null, int? year = null)
    {
        Model = model;
        Year = year;
    }

    // Constructor por defecto
    public Car(){}

    // Destructor
    ~Car()
    {
        WriteLine($"El automovil {Model} ha sido destruido.");
    }

    public void ChangeModel(string newModel)
    {
        Model = newModel;
    }

    public string ShowInfo()
    {
        return $"Modelo: {Model}, Año: {Year}";
    }

    public void ShowMessage() => WriteLine("Este es un automovil.");
    public void ShowMessage(string message) => WriteLine(message);
    public static void GenerateInfo()
    {
        WriteLine("El automovil es uno de los medios de transporte mas utilizados.");
    }

}