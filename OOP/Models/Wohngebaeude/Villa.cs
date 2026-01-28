using Grundlagen.Extentions;
using Grundlagen.OOP.Models.Wohngebaeude;

namespace Grundlagen.OOP
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
