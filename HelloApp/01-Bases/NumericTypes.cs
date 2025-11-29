partial class Program {
    static void ShowNumericTypes() {
        int integerNumber = 42;
        double doubleNumber = 3.14d;
        float floatNumber = 2.71f;
        long longNumber = 123456789L;
        decimal decimalNumber = 19.99m;

        Console.WriteLine($"int: {integerNumber}, double: {doubleNumber}, float: {floatNumber}, long: {longNumber}, decimal: {decimalNumber}");
    }
}