partial class Program
{
    static double CalculateArea(double width, double height)
    {
        return width * height;
    }
    static string EvaluateNumber(int number)
    {
        if (number > 0)
            return "Positive";
        else if (number < 0)
            return "Negative";
        else
            return "Zero";
    }
    static void Functions()
    {
        double area = CalculateArea(4.5, 2.3);
        WriteLine($"El área es: {area}");
        string evaluate = EvaluateNumber(-10);
        WriteLine($"El número es: {evaluate}");
    }
}