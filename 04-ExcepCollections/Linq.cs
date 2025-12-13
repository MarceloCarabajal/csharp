partial class Program
{
    static void Linq()
    {
        List<int> numbers = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
        List<int> evenNumbers = [];

        foreach (var number in numbers)
        {
            if (number % 2 == 0)
            {
                evenNumbers.Add(number);
            }
        }
        WriteLine("Números pares usando bucle foreach:");
        // Usando LINQ
        // sintaxis de consulta
        var evenNumbersLinqQuery = from num in numbers
                                   where num % 2 == 0
                                   select num;

        // sintaxis de método
        var evenNumbersLinqMethod = numbers.Where(num => num % 2 == 0);
        foreach (var even in evenNumbersLinqMethod)
        {
            WriteLine(even);
        }

        // Consultas simples
        List<MarvelCharacter> characters = new List<MarvelCharacter>
        {
            new MarvelCharacter { Name = "Peter Parker", Alias = "Spider-Man", Team = "Avengers" },
            new MarvelCharacter { Name = "Tony Stark", Alias = "Iron Man", Team = "Avengers" },
            new MarvelCharacter { Name = "Steve Rogers", Alias = "Captain America", Team = "Avengers" },
            new MarvelCharacter { Name = "Natasha Romanoff", Alias = "Black Widow", Team = "Avengers" },
            new MarvelCharacter { Name = "T'Challa", Alias = "Black Panther", Team = "Wakanda" },
            new MarvelCharacter { Name = "Stephen Strange", Alias = "Doctor Strange", Team = "Defenders" }
        };
        WriteLine("\nPersonajes de Marvel en los Avengers:");
        var avengers = from character in characters
                       where character.Team == "Avengers"
                       select $"{character.Alias} {character.Name}";
        var avengersMethod = characters
            .Where(c => c.Team == "Avengers")
            .Select(c => $"{c.Alias} {c.Name}");
        foreach (var avenger in avengersMethod)
        {
            WriteLine(avenger);
        }
        var uppercaseNamesQuery = from c in characters
                                  select c.Name?.ToUpper();
        var uppercaseNamesMethod = characters
            .Select(c => c.Name?.ToUpper());
        // WriteLine("\nNombres en mayúsculas:");
        // foreach (var name in uppercaseNamesMethod)
        // {
        //     WriteLine(name);
        // }
        var sortedQuery = from c in characters
                          orderby c.Name descending
                          select c.Name;
        var sortedMethod = characters
            .OrderByDescending(c => c.Name);
        // WriteLine("\nNombres ordenados descendentemente:");
        // foreach (var character in sortedMethod)
        // {
        //     WriteLine(character.Name);
        // }
        var firstThreeQuery = (from c in characters
                              select c).Take(3);
        var firstThreeMethod = characters
            .Take(3);
        WriteLine("\nPrimeros tres personajes:");
        foreach (var character in firstThreeMethod)
        {
            WriteLine(character.Name);
        }
    }
}
class MarvelCharacter
{
    public string? Name { get; set; }
    public string? Alias { get; set; }
    public string? Team { get; set; }
}




