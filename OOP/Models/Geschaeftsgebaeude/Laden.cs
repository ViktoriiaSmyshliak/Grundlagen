namespace Grundlagen.OOP.Models.Geschaeftsgebaeude
{
    // Laden
    public class Laden : Geschaeftshaus
{
    public int VerkaufsflaecheQm { get; private set; }

    public Laden(
        int gesamtnutzflaecheQm,
        double pacht,
        int verkaufsflaecheQm)
        : base(gesamtnutzflaecheQm, pacht)
    {
        VerkaufsflaecheQm = verkaufsflaecheQm;
    }

    public override void Print()
    {
        base.Print();
        Console.WriteLine($"Verkaufsflaeche: {VerkaufsflaecheQm} qm");
    }
}

}
