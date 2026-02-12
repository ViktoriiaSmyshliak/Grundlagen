// Office chair furniture product
// Supports discount via IRabatt interface
public class Buerostuhl : Moebel, IRabatt
{
    public Buerostuhl(string hersteller, string modell, string bestellnummer, double nettopreis)
        : base(hersteller, modell, bestellnummer, nettopreis)
    {
    }

    public double Rabatt { get; private set; }

    public void NeuerRabatt(double rabatt)
    {
        Rabatt = rabatt;
    }

}
