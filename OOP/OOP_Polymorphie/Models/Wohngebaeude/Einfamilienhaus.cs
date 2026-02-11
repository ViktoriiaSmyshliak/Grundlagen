using OOP.Extentions;

namespace OOP.OOP_Polymorphie.Models.Wohngebaeude
{
    // Einfamilienhaus
    public class Einfamilienhaus : Wohnhaus
{
    public bool Einbaukueche { get; private set; }

    public Einfamilienhaus(
        int gesamtnutzflaecheQm,
        int gartenQm,
        double miete,
        bool einbaukueche)
        : base(gesamtnutzflaecheQm, gartenQm, miete)
    {
        Einbaukueche = einbaukueche;
    }

        public override void Print()
    {
        base.Print();
        Console.WriteLine($"Einbaukueche: {Einbaukueche.ToJaNein()}");
    }
}

}
