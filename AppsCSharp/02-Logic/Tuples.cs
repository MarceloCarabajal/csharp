partial class Program
{
    static void Tuples()
    {
        (int, string) myTuple = (1, "Hello");
        WriteLine($"Item1: {myTuple.Item1}, Item2: {myTuple.Item2}");
        (int Number, string Text) myOtherTuple = (2, "World");
        WriteLine($"Number: {myOtherTuple.Number}, Text: {myOtherTuple.Text}");
        var operations = Operations(10, 5);
        WriteLine($"Sum: {operations.Sum}, Subtract: {operations.Subtract}");
        (int sum, int subtract) = Operations(20, 8);
        WriteLine($"Sum: {sum}, Subtract: {subtract}");
    }
    
    static (int Sum, int Subtract) Operations(int a, int b)
    {
        return (a + b, a - b);
    }
}