partial class Program
{
    static void Inheritance()
    {
        HowgartsStudent student = new HowgartsStudent(){Name="Harry Potter", House="Gryfindor"};
        HogwartsProfessor professor = new HogwartsProfessor(){Name="Severus Snape", Subject="Pociones"};

        student.Greet();
        professor.Greet();
    }
}

class Character
{
    public string? Name { get; set;}
    public virtual void Greet()
    {
        WriteLine($"Hola, soy {Name}");
    }
}

class HowgartsStudent : Character
{
    public string? House { get; set; }
    public override void Greet()
    {
        WriteLine($"Hola, soy {Name} y pertenezco a la casa {House}");
    }
}

class HogwartsProfessor : Character
{
    public string? Subject {get; set;}
    public override void Greet()
    {
        WriteLine($"Hola, soy el profesor {Name}");
    }
    public void MySubject()
    {
        WriteLine($"Enseño {Subject} en Hogwarts");
    }

}