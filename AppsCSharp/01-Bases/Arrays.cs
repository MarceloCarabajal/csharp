partial class Program
{
    static void Arrays()
    {
        int[] numbers = new int[5];
        numbers[0] = 10;
        numbers[1] = 20;;

        //Directa
        int[] numbersArray = [1, 2, 3, 20, 30];
        // Indices
        Console.WriteLine($"First number: {numbersArray[0]}");
        Console.WriteLine($"Second number: {numbersArray[1]}");
        // Length
        Console.WriteLine($"Array Length: {numbersArray.Length}");
        // desde el final del arreglo ^
        Console.WriteLine($"Last number: {numbersArray[^1]}");
        Console.WriteLine($"Second to last number: {numbersArray[^2]}");
        // Rangos para obtener subarreglos ..
        int[] firstThree = numbersArray[..3];
        int[] fromIndexTwo = numbersArray[2..];
        Console.WriteLine($"First three numbers: {firstThree}");
        foreach(var number in firstThree)
        {
            Console.WriteLine(number);
        }
        Console.WriteLine($"Numbers from index 2: {fromIndexTwo}");
    }
}