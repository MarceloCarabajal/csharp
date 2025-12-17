partial class Program
{
    static void LoopGame()
    {
        int counter = 0;
        WriteLine("🎮 Pulse cualquier tecla para aumentar el contador");
        WriteLine("☝🏻 Pulse 'ESC' para salir del juego");
        while (true)
        {
            var key = ReadKey(true).Key;
            if (key == ConsoleKey.Escape)
            {
                WriteLine($"Has pulsado las teclas {counter} veces antes de salir.");
                WriteLine("🌠 Saliendo del juego...");
                break;
            }
            counter++;
        }
    }
}