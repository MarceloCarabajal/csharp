partial class Program{
    static void Collections(){
        List<string> names = ["Ana", "Luis", "Carlos"];
        names.Add("María");
        ShowNames(names);
        WriteLine("Despues de remover a Luis");
        names.Remove("Luis");
        ShowNames(names);

        Dictionary<int, string> students = new(){
            {1, "Ana"},
            {2, "Luis"},
            {3, "Carlos"}
        };
        students.Add(4, "María");
        WriteLine("Diccionario de estudiantes:");
        ShowStudents(students);
        WriteLine("Despues de remover al estudiante con ID 2");
        students.Remove(2);
        ShowStudents(students);

        HashSet<string> users = ["admin", "user1", "user2"];
        users.Add("user3");
        users.Add("operator");
        users.Add("admin"); // No se agrega porque ya existe
        WriteLine("Conjunto de usuarios:");
        ShowUsers(users);
        WriteLine("Despues de remover al usuario 'user1'");
        users.Remove("user1");
        ShowUsers(users);

    }
    private static void ShowNames(List<string> names){
    foreach(var name in names){
        Console.WriteLine($"Nombre: {name}");
        }
    }
    private static void ShowStudents(Dictionary<int, string> students){
        foreach(var student in students){
            Console.WriteLine($"ID: {student.Key}, Nombre: {student.Value}");
        }
    }
    private static void ShowUsers(HashSet<string> users){
        foreach(var user in users){
            Console.WriteLine($"Usuario: {user}");
        }
    }
}

