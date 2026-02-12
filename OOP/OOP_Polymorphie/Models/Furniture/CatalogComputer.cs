// Catalog computer base class used only for interface task hierarchy
public abstract class CatalogComputer : Artikel
{
    protected CatalogComputer(string hersteller, string modell, string bestellnummer, double nettopreis)
        : base(hersteller, modell, bestellnummer, nettopreis)
    {
    }
}
