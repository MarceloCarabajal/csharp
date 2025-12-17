// 🏆 Ejercicio:
// Crear un programa que calcule el salario mensual de un trabajador
// - Pedir al usuario su nombre, horas trabajadas y tarifa por hora
// - Calcular el sueldo y mostrarlo en pantalla

partial class Program {
    static void SalaryCalculator()
    {
        Console.WriteLine("Calculadora de Salario Mensual");
        Console.WriteLine("------------------------------");
        Console.Write("Ingrese su nombre: ");
        string? name = Console.ReadLine();
        Console.Write("Ingrese las horas trabajadas en el mes: ");
        double hoursInput = double.Parse(Console.ReadLine()!);
        Console.Write("Ingrese la tarifa por hora: ");
        double rateInput = double.Parse(Console.ReadLine()!);
        double salary = hoursInput * rateInput;
        Console.WriteLine($"El salario mensual de {name} es: {salary:C}");
    }
}