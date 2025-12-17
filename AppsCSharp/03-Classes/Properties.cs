partial class Program
{
    static void Properties()
    {
        Animal animal = new Animal("Selva");
        animal.Species = "Tigre";
        animal.Age = 5;
        WriteLine($"Especie: {animal.Species}");
        WriteLine($"Categoría: {animal.Category}");
        WriteLine($"Edad: {animal.Age}");
        WriteLine($"Hábitat: {animal.Habitat}");    

    }
}

class Animal
{
    //Propiedades
    public string Species { get; set; } = "Desconocida";
    public string Category {get;} = "Vertebrado";
    private int age;
    public int Age
    {
        get { return age; }
        set 
        { 
            if(value < 0)
                throw new ArgumentException("La edad no puede ser negativa.");
            age = value; 
        }
    }

    public string Habitat { get;}

    public Animal(string habitat)
    {
        Habitat = habitat;
    }

}