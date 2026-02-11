using OOP.Extentions;

namespace OOP.OOP_Polymorphie.Models.Wohngebaeude
{
    // Villa
    public class Villa : Wohnhaus
{
    public bool Einliegerwohnung { get; private set; }

    public Villa(
        int gesamtnutzflaecheQm,
        int gartenQm,
        double miete,
        bool einliegerwohnung)
        : base(gesamtnutzflaecheQm, gartenQm, miete)
    {
        Einliegerwohnung = einliegerwohnung;
    }

    public override void Print()
    {
        base.Print();
        Console.WriteLine($"Einliegerwohnung: {Einliegerwohnung.ToJaNein()}");
    }
}

}
