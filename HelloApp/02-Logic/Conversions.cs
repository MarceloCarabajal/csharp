partial class Program
{
    static void Conversions()
    {
        int number = 42;
        double decimalNumber = number; // Implicit conversion from int to double
        WriteLine($"Número entero: {number}, Número decimal: {decimalNumber}");

        double explicitDecimalNumber = 42.5;
        int integerNumber = (int)explicitDecimalNumber; // Explicit conversion from double to int
        WriteLine($"Número entero: {integerNumber}, Número decimal: {explicitDecimalNumber}");

        // convert o Parse
        string text = "123";
        int parsedNumber = int.Parse(text);
        WriteLine($"Texto: {text}, Número parseado: {parsedNumber}");

        // Convert class
        double anotherDecimalNumber = 56.7;
        int convertedNumber = Convert.ToInt32(anotherDecimalNumber);
        WriteLine($"Número decimal: {anotherDecimalNumber}, Número convertido: {convertedNumber}");
        int castedNumber = (int)anotherDecimalNumber;
        WriteLine($"Número decimal: {anotherDecimalNumber}, Número casteado: {castedNumber}");
    }
}