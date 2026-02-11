using OOP.Extentions;

namespace OOP.OOP_Polymorphie.Models.Geschaeftsgebaeude
{
    // Restaurant
    public class Restaurant : Geschaeftshaus
{
    public int AnzahlTische { get; private set; }
    public bool Aussenbewirtschaftung { get; private set; }

    public Restaurant(
        int gesamtnutzflaecheQm,
        double pacht,
        int anzahlTische,
        bool aussenbewirtschaftung)
        : base(gesamtnutzflaecheQm, pacht)
    {
        AnzahlTische = anzahlTische;
        Aussenbewirtschaftung = aussenbewirtschaftung;
    }
    public override void Print()
    {
        base.Print();
        Console.WriteLine($"Anzahl Tische: {AnzahlTische}");
        Console.WriteLine($"Aussenbewirtschaftung: {Aussenbewirtschaftung.ToJaNein()}");
    }
}

}
