public static class FreizeitAktionen
{
    // All methods must match delegate signature:
    // (string, int) → int
    // This is required so delegate can point to any of these methods

    public static int Lesen(string buchtitel, int kapitel)
    {
        // Demonstrates delegate calling a normal method
        int dauer = 2;

        Console.WriteLine($"Ich lese Kapitel {kapitel} des Buchs {buchtitel}.");

        // Delegate must return value defined in signature
        return dauer;
    }

    public static int BlumenGiessen(string blume, int milliliter)
    {
        // Shows that delegate can call completely different logic
        // as long as signature is identical
        int anzahlBlumen = 3;

        Console.WriteLine($"Ich gieße jede {blume} mit {milliliter} ml Wasser.");

        return anzahlBlumen;
    }

    public static int FilmGucken(string filmtitel, int anzahlFreunde)
    {
        // Demonstrates reuse of same delegate for another activity
        int besucher = 67;

        Console.WriteLine($"Ich gucke im Kino mit {anzahlFreunde} Freund{(anzahlFreunde != 1 ? "en" : "")} den Film {filmtitel}.");

        return besucher;
    }
}
