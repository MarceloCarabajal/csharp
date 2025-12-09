partial class Program
{
    static void Visibility()
    {
        Jedi jedi = new Jedi();
        jedi.PowerLevel = 5000;
        jedi.LightSaberColor = "Verde";

        jedi.UseForce();
        WriteLine(jedi.PublicField);
        //WriteLine(jedi.PrivateField); // Error: No se puede acceder al campo privado
        //WriteLine(jedi.ProtectedField); // Error: No se puede acceder al campo protegido
        //jedi.RevealSecrets();

        Sith sith = new Sith();
        sith.PowerLevel = 6000;
        sith.LightSaberColor = "Rojo";
        sith.UseForce();
        // sith.ShowProtected();
    }
}

interface IForceUser
{
    int PowerLevel { get; set; }
    string? LightSaberColor { get; set; }
    void UseForce();
}

class Jedi : IForceUser
{
    public string PublicField = "Soy un Jedi y mi poder es conocido por todos";
    private string PrivateField = "Mis pensamientos son secretos";
    protected string ProtectedField = "El lado oscuro no debe conocer mis habilidades";
    public int PowerLevel { get; set; }
    public string? LightSaberColor { get; set; }
    public void UseForce()
    {
        WriteLine($"Soy un Jedi con un sable de luz de color {LightSaberColor} y un nivel de poder de {PowerLevel}");
    }
    private void Meditate()
    {
        WriteLine("Meditando para aumentar mi nivel de poder");
        //PowerLevel += 10;
    }
    protected void Train()
    {
        WriteLine("Entrenando para mejorar mis habilidades");
        //PowerLevel += 5;
    }
    public void RevealSecrets()
    {
        WriteLine(ProtectedField);
        WriteLine(PrivateField);
        Meditate();
    }
}

class Sith : Jedi, IForceUser
{
    public new void UseForce()
    {
        WriteLine($"Soy un Sith con un sable de luz de color {LightSaberColor} y un nivel de poder de {PowerLevel}");
    }   
    public void ShowProtected()
    {
        WriteLine(ProtectedField);
        Train();
    }
}