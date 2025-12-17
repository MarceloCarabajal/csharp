using System.Globalization;

partial class Program
{
    static void ConversionToDateTime()
    {
        CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("es-AR");

        int friends = int.Parse("12");
        double cost = 25.50;
        DateTime birthday = DateTime.Parse("2025-11-20");
        WriteLine($"Tienes {friends} amigos. Tu cumpleaños es el {birthday:D}.");
        WriteLine($"El costo de la entrada sera: {cost:C}.");
    }
}