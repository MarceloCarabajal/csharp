partial class Program
{
    static void AnonymousFunctions()
    {
        WriteLine($"Square of 5 is: {square(5)}");
        WriteLine($"Square of 6 is: {lambdaSquare(6)}");
        List<int> numbers = [1, 2, 3, 4, 5];
        var evenNumbers = numbers.Where(n => n % 2 == 0);
        foreach (var even in evenNumbers)
        {
            WriteLine($"Even number: {even}");
        }
    }
    static Func<int, int> square = delegate (int number)
    {
        return number * number;    
    };

    static Func<int, int> lambdaSquare = number => number * number;
}