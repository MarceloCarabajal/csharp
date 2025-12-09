using System.Net.Http.Headers;

partial class Program
{
    static void ProductSalesDemo()
    {
        Inventory inventory = new Inventory(); 
        Product laptop = new("Laptop", 1200.00, 5);
        Product mouse = new Product("Mouse", 100.00, 10);

        inventory.AddProduct(laptop);
        inventory.AddProduct(mouse);
        // inventory.ShowInventory();
        // laptop.Sell(3);
        // mouse.Sell(12);
        // inventory.ShowInventory();
    }
    /*
=============
🏆 Ejercicio 
=============
*/
// 1. Crear una clase "Bus" con las siguientes propiedades:
//    - Brand (public)
//    - Model (public)
//    - Year (public)
//    - Price (public)
//    - TotalKilometers (public)
//
// 2. Implementar un constructor para inicializar los valores.
// 3. Agregar un método "Drive(int kilometers)" que aumente el kilometraje.
// 5. Agregar un método "ShowPrice()" que nos devuelva el precio del bus.
// 6. Crear una clase "Fleet" que administre una lista de buses.
//    - Método para agregar buses a la flota.
//    - Método mostrar el listado de buses.
//
// 7. Instanciar al menos tres objetos de la clase Bus, agregarlos a la Fleet y simular la conducción de 5000.
// 8. Mostrar los detalles de la flota antes y después de la conducción.
    static void BusFleet()
    {
        Bus bus1 = new Bus("Mercedes-Benz", "Sprinter", 2020, 80000, 25000);
        Bus bus2 = new Bus("Volvo", "B9R", 2018, 120000, 5000);
        Bus bus3 = new Bus("Scania", "K360", 2019, 110000, 3000);

        Fleet fleet = new Fleet();
        fleet.AddBus(bus1);
        fleet.AddBus(bus2);
        fleet.AddBus(bus3);

        fleet.ShowFleet();

        bus1.Drive(3000);
        bus2.Drive(2000);
        
        fleet.ShowFleet();
    }
    
}
class Product
    {
        public string? Name { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
    
        public Product(string name, double price, int stock)
        {
            Name = name;
            Price = price;
            Stock = stock;
        }
        public void ShowInfo()
        {
            WriteLine($"Producto: {Name}, Precio: {Price}, Stock: {Stock}");
        }
        public bool Sell(int quantity)
        {
            if(quantity <= Stock)
            {
                Stock -= quantity;
                WriteLine($"Venta exitosa de {quantity} unidad(es) de {Name}.");
                return true;
            }
            else
            {
                WriteLine($"No hay suficiente stock para vender {quantity} unidad(es) de {Name}.");
                return false;
            }
        }
        
    }

class Inventory

    {
        private List<Product> products = new List<Product>();
        public void AddProduct(Product product)
        {
            products.Add(product);
            WriteLine($"Producto {product.Name} agregado al inventario.");
        }
        public void ShowInventory()
        {
            WriteLine("Inventario Actual:");
            foreach(var product in products)
            {
                product.ShowInfo();
            }
        }
    }
class Bus
{
    public string? Brand { get; set; }
    public string? Model { get; set; }  
    public int Year { get; set; }
    public double Price { get; set;  }
    public double TotalKilometers { get; set; }

    public Bus(string brand, string model, int year, double price, double totalKilometers)
    {
        Brand = brand;
        Model = model;
        Year = year;
        Price = price;
        TotalKilometers = totalKilometers;
    }
    public void Drive(int kilometers)
    {
        TotalKilometers += kilometers;
        WriteLine($"El bus {Brand} {Model} ha conducido {kilometers} kilómetros. Total kilómetros: {TotalKilometers}");
    }
    public void ShowPrice()
    {
        WriteLine($"El precio del bus {Brand} {Model} es: {Price:C}");
    }
}

class Fleet
{
    private List<Bus> buses = new List<Bus>();

    public void AddBus(Bus bus)
    {
        buses.Add(bus);
        WriteLine($"Bus {bus.Brand} {bus.Model} agregado a la flota.");
    }

    public void ShowFleet()
    {
        WriteLine("Listado de Buses en la Flota:");
        foreach(var bus in buses)
        {
            WriteLine($"Marca: {bus.Brand}, Modelo: {bus.Model}, Año: {bus.Year}, Precio: {bus.Price:C}, Kilómetros Totales: {bus.TotalKilometers}");
        }
    }
}