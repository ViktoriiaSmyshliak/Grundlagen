using OOP.Extentions;

namespace OOP.OOP_Polymorphie.Models.Geschaeftsgebaeude
{

// Buero
public class Buero : Geschaeftshaus
{
    public bool Notstromversorgung { get; private set; }

    public Buero(
        int gesamtnutzflaecheQm,
        double pacht,
        bool notstromversorgung)
        : base(gesamtnutzflaecheQm, pacht)
    {
        Notstromversorgung = notstromversorgung;
    }

    public override void Print()
    {
        base.Print();
        Console.WriteLine($"Notstromversorgung: {Notstromversorgung.ToJaNein()}");
    }
}

}
