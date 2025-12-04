partial class Program
{
    static void Conditionals()
    {
        int age = 19;
        if (age > 18)
        {
            WriteLine("Eres mayor de edad.");
        }
        else
        {
            WriteLine("Eres menor de edad.");
        }

        // ternario
        string resultado = (age > 18) ? "Mayor de edad" : "Menor de edad";
        WriteLine(resultado);

        // Multiple condiciones
        int temperature = 30;
        if (temperature > 30)
        {
            WriteLine("Hace calor.");
        }
        else if (temperature < 15)
        {
            WriteLine("Hace frío.");
        }
        else
        {
            WriteLine("El clima es agradable.");
        }

        // switch
        int day = 3;
        switch (day)
        {
            case 1:
                WriteLine("Lunes");
                break;
            case 2:
                WriteLine("Martes");
                break;
            case 3:
                WriteLine("Miércoles");
                break;
            case 4:
                WriteLine("Jueves");
                break;
            case 5:
                WriteLine("Viernes");
                break;
            case 6:
                WriteLine("Sábado");
                break;
            case 7:
                WriteLine("Domingo");
                break;
            default:
                WriteLine("Día inválido");
                break;
        }
        // switch expresión
        string dayMeesage = day switch
        {
            1 => "Lunes",
            2 => "Martes",
            3 => "Miércoles",
            4 => "Jueves",
            5 => "Viernes",
            6 => "Sábado",
            7 => "Domingo",
            _ => "Día inválido"
        };
        WriteLine(dayMeesage);
    }
}