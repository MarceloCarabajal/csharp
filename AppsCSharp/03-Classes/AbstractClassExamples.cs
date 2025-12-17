partial class Program
{
    static void AbstractClassExamples()
    {
        HomeAppliance myWasher = new WashingMachine() { Brand = "LG" };
        HomeAppliance myMicrowave = new Microwave() { Brand = "Samsung" };
        myWasher.ShowBrand();
        myWasher.TurnOn();
        myMicrowave.ShowBrand();
        myMicrowave.TurnOn();
    }
}

abstract class HomeAppliance
{
    public string? Brand { get; set; }
    public abstract void TurnOn();
    public void ShowBrand()
    {
        WriteLine($"La marca del electrodoméstico es {Brand}");
    }
}

class WashingMachine : HomeAppliance
{
    public override void TurnOn()
    {
        WriteLine("La lavadora está encendida");
    }
}

class Microwave : HomeAppliance
{
    public override void TurnOn()
    {
        WriteLine("El microondas está encendido");
    }
}