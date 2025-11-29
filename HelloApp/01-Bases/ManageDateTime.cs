partial class Program {
    static void ShowTime() {
        DateTime now = DateTime.Now;
        DateTime today = DateTime.Today;
        DateTime nowWeekAgo = now.AddDays(-7);
        DateTime customDate = new DateTime(2025, 12, 25);

        DayOfWeek dayOfWeek = now.DayOfWeek;

        Console.WriteLine($"Fecha y hora actual: {now}");
        Console.WriteLine($"Fecha actual (sin hora): {today}");
        Console.WriteLine($"Fecha y hora hace una semana: {nowWeekAgo.ToString("yyyy-MM-dd")}"); //to string para dejar solo la fecha
        Console.WriteLine($"Fecha personalizada: {customDate}");
        Console.WriteLine($"Día de la semana actual: {dayOfWeek}");
    }
}