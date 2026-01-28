namespace Grundlagen.Extentions
{
    public static class BoolExtensions
{
    // Extension Method: erweitert den Typ bool um eine zusätzliche Methode.
    // Die Methode steht allen bool-Werten im gesamten Projekt zur Verfügung.

    public static string ToJaNein(this bool value) => value ? "Ja" : "Nein";
}

}
