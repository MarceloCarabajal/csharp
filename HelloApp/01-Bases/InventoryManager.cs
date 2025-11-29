// 🏆 Ejercicio:
// - Mostrar el inventario actualizado después de cada compra. 


partial class Program
{
    static void InventoryManager()
    {
        string[] products = ["Laptop", "Tablet", "Smartphone", "Monitor", "Teclado"];
        int[] stock = [50, 30, 20, 15, 100];
        double[] prices = [999.99, 499.99, 799.99, 199.99, 49.99];
        // - Crear un menu con las opciones de 1. Comprar producto y 2. Salir.
        Console.WriteLine("1. Comprar producto");
        Console.WriteLine("2. Salir");
        Console.WriteLine("Seleccione una opción:");
   
        int option = int.Parse(Console.ReadLine()!);

        if(option == 1)
        {
            Console.WriteLine("Lista de productos:");
            Console.WriteLine("-----------------");
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine($"Producto: {products[i]}, Stock: {stock[i]}, Precio: {prices[i]:C}");
            }
            Console.WriteLine("\nIngrese el nombre del producto para verificar el stock:");
            string? inputProduct = Console.ReadLine();
            Console.WriteLine("Ingrese la cantidad a verificar:");
            int inputQuantity = int.Parse(Console.ReadLine()!);
            for(int i = 0; i < products.Length; i++)
            {
                if(products[i].Equals(inputProduct, StringComparison.OrdinalIgnoreCase))
                {
                    if(stock[i] >= inputQuantity)
                    {
                        double total = inputQuantity * prices[i];
                        stock[i] -= inputQuantity;
                        Console.WriteLine($"Hay suficiente stock de {products[i]}. El costo total es: ${total:C}");
                        Console.WriteLine($"Stock restante para el producto {products[i]}: {stock[i]} unidades.");
                    }
                    else
                    {
                        Console.WriteLine($"No hay suficiente stock de {products[i]}.");
                    }
                    return;
                }
            }
        } else if(option == 2)
        {
            Console.WriteLine("Gracias por su visita.");
            return;
        }
        else
        {
            Console.WriteLine("Opción no válida.");
        }
    }
}