
partial class Program
{
    static void Main(string[] args)
    {
        TaskMaster.Program.TaskMaster();
        // Forzar la recoleccion de basura para ver el destructor en accion
        // GC.Collect();
        // Esperar a que se completen las finalizaciones
        // GC.WaitForPendingFinalizers();
    }
}