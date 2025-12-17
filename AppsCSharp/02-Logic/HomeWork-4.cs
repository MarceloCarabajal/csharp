partial class Program
{
  static void PrintMultiplicationTable(int number, int tableLimit = 10)
  {
    WriteLine($"Tabla de multiplicar del {number} desde 1 hasta {tableLimit}:");
    WriteLine("=========================================");
    for (int i = 1; i <= tableLimit; i++)
    {
      WriteLine($"{number} x {i} = {number * i}");
    }
    WriteLine("=========================================");
  }
  // 🏆 Ejercicio:
    // Crear un método llamado `PrintFactorialTable` que reciba un número 
    // y muestre el factorial de todos los números desde 1 hasta el número ingresado.
    // Ejemplo: PrintFactorialTable(5);
    // 1! = 1
    // 2! = 2
    // 3! = 6
    // 4! = 24
    // 5! = 120
  static void PrintFactorialTable(int number)
  {
    WriteLine($"Tabla de factoriales del numero {number} desde 1 hasta {number}:");
    WriteLine("=========================================");
    for (int i = 1; i <= number; i++)
        {
            WriteLine($"{i}! = {Factorial(i)} ");
        }
    WriteLine("=========================================");
  }
  static int Factorial(int n)
    {
        int result = 1;
        for (int i = 1; i <= n; i++)
        {
            result *= i;
        }
        return result;
    }
  
}