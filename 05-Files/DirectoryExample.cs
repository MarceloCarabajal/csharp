partial class Program
{
    static void DirectoryExample()
    {
        var directoryPath = "./05-Files/";
        Directory.CreateDirectory($"{directoryPath}/OtherDirectory");
        if(Directory.Exists($"{directoryPath}/OtherDirectory"))
        {
            WriteLine("El directorio ya se ha creado correctamente.");
        }
        else
        {
            WriteLine("No se pudo crear el directorio.");
        }
        Directory.Delete($"{directoryPath}/DirEjemplo", true);
    }
}