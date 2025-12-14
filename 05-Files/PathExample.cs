partial class Program
{
    static void PathExample()
    {
        var filePath = "./05-Files/file.txt";
        var fileName = Path.GetFileName(filePath);
        WriteLine($"File Name: {fileName}");
        var fileExtension = Path.GetExtension(filePath);
        WriteLine($"File Extension: {fileExtension}");
        var directoryName = Path.GetDirectoryName(filePath);
        WriteLine($"Directory Name: {directoryName}");
        var combinedPath = Path.Combine("C:", "Users", "User", "Documents", "file.txt");
        WriteLine($"Combined Path: {combinedPath}");
        var cullFilePath = Path.GetFullPath(filePath);
        WriteLine($"Full Path: {cullFilePath}");
    }
}