namespace Grundlagen.OOP.Models.Wohngebaeude
{
    // Basisklasse fuer Wohngebaeude
    public abstract class Wohnhaus : Gebaeude
{
    public int GartenQm { get; protected set; }
    public double Miete { get; protected set; }

    protected Wohnhaus(int gesamtnutzflaecheQm, int gartenQm, double miete)
        : base(gesamtnutzflaecheQm)
    {
        GartenQm = gartenQm;
        Miete = miete;
    }

    public override void Print()
    {
        base.Print();
        Console.WriteLine($"Garten: {GartenQm} qm");
        Console.WriteLine($"Miete: {Miete} EUR");
    }
}

}
