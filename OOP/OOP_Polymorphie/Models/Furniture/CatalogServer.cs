// Server catalog product
// Inherits discount support from CatalogDesktop
public class CatalogServer : CatalogDesktop
{
    public CatalogServer(string hersteller, string modell, string bestellnummer, double nettopreis)
        : base(hersteller, modell, bestellnummer, nettopreis)
    {
    }
}
