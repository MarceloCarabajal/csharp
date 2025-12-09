
partial class Program
{
    static void Main(string[] args)
    {
        ShowEmployeesInformation();
        // Forzar la recoleccion de basura para ver el destructor en accion
        // GC.Collect();
        // Esperar a que se completen las finalizaciones
        // GC.WaitForPendingFinalizers();
    }
}