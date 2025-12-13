partial class Program{
    static string? amount;
    static void HandleException(){
        try
        {
            // int number = 10;
            // int result = number / 0;
            Console.WriteLine($"Ingrese un monto: ");
            amount = Console.ReadLine();
            if(string.IsNullOrEmpty(amount)){
                return;
            }
            if(double.TryParse(amount, out double amountValue)){
                // double amountValue = double.Parse(amount);
                WriteLine($"Monto ingresado: {amountValue:C}");
            }
            else {
                WriteLine("El formato del monto es incorrecto.");
            }

            ValidateAge(16);
         
        }
        catch (DivideByZeroException ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            WriteLine("Error: No se puede dividir por cero.");
            WriteLine($"Detalles del error: {ex.Message}");
        }
        catch(FormatException) when (!string.IsNullOrEmpty(amount) && amount.Contains("$") == true){
            WriteLine("Formato incorrecto: El monto no debe incluir el símbolo de moneda.");
        }
        catch(Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            WriteLine("Se ha producido un error inesperado.");
            WriteLine($"Detalles del error: {ex.Message}");
        }      
        finally
        {
            Console.ResetColor();
            WriteLine("Operación finalizada.");
        }

    }
    static void ValidateAge(int age){
        if(age < 18){
            throw new ArgumentException("El usuario debe ser mayor de edad.");
        }
    }
}