partial class Program
{
    static void LoopsControlExamples()
    {
        for (int i = 1; i <= 10; i++)
        {
            if (i == 5)
            {
                continue; // Salta el número 5
            }

            if (i == 8)
            {
                break; // Termina el bucle cuando i es 8
            }

            WriteLine(i);
        }

        // return
        for (int i = 0; i < 10; i++)
        {
            if (i == 6)
            {
                //return; // Sale del método cuando i es 6
            }

            WriteLine(i);
        }

        // bucle infinito
        while (true)
        {
            WriteLine("Este bucle es infinito. Presiona Ctrl + C para detenerlo.");
            break; // Añadido para evitar un bucle infinito real durante la ejecución
        }

        // bucle infinito con for
        for (;;)
        {
            WriteLine("Este bucle for es infinito. Presiona Ctrl + C para detenerlo.");
            break; // Añadido para evitar un bucle infinito real durante la ejecución
        }
    }
}