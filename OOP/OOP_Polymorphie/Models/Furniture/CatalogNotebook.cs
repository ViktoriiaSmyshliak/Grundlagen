// Notebook catalog product
// Does not support discount functionality
public class CatalogNotebook : CatalogComputer
{
    public CatalogNotebook(string hersteller, string modell, string bestellnummer, double nettopreis)
        : base(hersteller, modell, bestellnummer, nettopreis)
    {
    }
}
