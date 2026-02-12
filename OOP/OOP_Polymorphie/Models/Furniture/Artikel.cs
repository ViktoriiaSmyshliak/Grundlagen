// Base class for all shop catalog items
// Contains shared product data
public abstract class Artikel
{
    public string HERSTELLER { get; private set; }
    public string MODELL { get; private set; }
    public string Bestellnummer { get; private set; }
    public double Nettopreis { get; private set; }

    protected Artikel(string hersteller, string modell, string bestellnummer, double nettopreis)
    {
        HERSTELLER = hersteller;
        MODELL = modell;
        Bestellnummer = bestellnummer;
        Nettopreis = nettopreis;
    }
}
