// Base class for furniture catalog products
public abstract class Moebel : Artikel
{
    protected Moebel(string hersteller, string modell, string bestellnummer, double nettopreis)
        : base(hersteller, modell, bestellnummer, nettopreis)
    {
    }
}
