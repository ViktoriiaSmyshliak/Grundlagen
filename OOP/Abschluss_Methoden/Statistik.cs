public class Statistik
{
    public bool Auswerten(
    in string titel,
    List<int> werte,
    out double durchschnitt,
    int breite = 20,
    ConsoleColor farbe = ConsoleColor.Cyan)
{
    if (breite < 20) breite = 20;

    Console.WindowWidth = Math.Max(20, breite) + 7;
    Console.WindowHeight = 5;
    Console.Clear();
    Console.ResetColor();

    Console.WriteLine($"{titel} (1..{breite})");

    for (int i = 1; i <= breite; i++)
    {
        Console.CursorLeft = 6 + i;
        if (i % 5 == 0)
            Console.Write("|", Console.ForegroundColor = ConsoleColor.Yellow);
        else
            Console.Write(".", Console.ForegroundColor = ConsoleColor.White);
    }

    Console.WriteLine();

    bool invalid = false;
    double total = 0;

    Console.ForegroundColor = farbe;

    foreach (var v in werte)
    {
        Console.WindowHeight++;

        total += v; // IMPORTANT: count ALL values for average

        Console.Write($"{v,3}: ", Console.ForegroundColor = ConsoleColor.Yellow);

        if (v < 1 || v > breite)
        {
            Console.WriteLine("ungültig!");
            invalid = true;
            continue;
        }

        for (int i = 1; i <= breite; i++)
        {
            if (i == v)
                Console.Write("*", Console.ForegroundColor = farbe);
            else
                Console.Write(" ");
        }

        Console.WriteLine();
    }

    Console.ResetColor();

    durchschnitt = werte.Count > 0 ? total / werte.Count : 0;

    return invalid;
}

}
