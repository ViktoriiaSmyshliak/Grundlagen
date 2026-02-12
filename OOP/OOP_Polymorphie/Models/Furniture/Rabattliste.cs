// Stores only discount-capable catalog articles using Dictionary
// Uses Bestellnummer as key and works via IRabatt interface contract
public class Rabattliste
{
    private Dictionary<string, IRabatt> rabattliste = new();

    // Adds only discount-capable articles (IRabatt) to the list
    public void Hinzufuegen(IRabatt artikel)
    {
        rabattliste.Add((artikel as Artikel).Bestellnummer, artikel);
    }

    // Displays all discount articles with full product data and discount value
    public void Anzeigen()
    {
        foreach (IRabatt rabattArtikel in rabattliste.Values)
        {
            Artikel artikel = rabattArtikel as Artikel;

            Console.WriteLine(
                $"{artikel.Bestellnummer} - " +
                $"{artikel.HERSTELLER} {artikel.MODELL} - " +
                $"{artikel.Nettopreis:F2} EUR: " +
                $"{rabattArtikel.Rabatt:F2}%");
        }
    }
}
