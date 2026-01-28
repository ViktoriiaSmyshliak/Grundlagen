namespace Grundlagen.OOP.Models.Geschaeftsgebaeude
{
    // Basisklasse fuer Geschaeftsgebaeude
    public abstract class Geschaeftshaus : Gebaeude
{
    public double Pacht { get; protected set; }

    protected Geschaeftshaus(int gesamtnutzflaecheQm, double pacht)
        : base(gesamtnutzflaecheQm)
    {
        Pacht = pacht;
    }

    public override void Print()
    {
        base.Print();
        Console.WriteLine($"Pacht: {Pacht} EUR");
    }
}

}
