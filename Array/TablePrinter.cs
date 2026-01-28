public class TablePrinter
{
    private readonly Action print;
    private readonly string emptyStr;

    // string[,]
    public TablePrinter(string[,] table, string emptyStr = "NULL")
    {
        this.emptyStr = emptyStr;
        print = () => Print2D(table);
    }

    // string[][]
    public TablePrinter(string[][] table, string emptyStr = "NULL")
    {
        this.emptyStr = emptyStr;
        print = () => PrintJagged(table);
    }

    public void Print()
    {
        print();
    }

    // Methode zum Ausgeben einer 2D-Tabelle
    private void Print2D(string[,] table)
    {
        // Anzahl der Zeilen der Tabelle
        int rows = table.GetLength(0);

        // Anzahl der Spalten der Tabelle
        int cols = table.GetLength(1);

        // Array für die maximale Breite jeder Spalte
        int[] widths = new int[cols];

        // Erster Durchlauf:
        // Spaltenbreiten berechnen
        for (int i = 0; i < rows; i++)
        {
            // Alle Spalten der aktuellen Zeile prüfen
            for (int j = 0; j < cols; j++)
            {
                // Wert normalisieren (leer oder null → Ersatztext)
                string value = Normalize(table[i, j]);

                // Maximale Länge für diese Spalte merken
                widths[j] = Math.Max(widths[j], value.Length);
            }
        }

        // Zweiter Durchlauf:
        // Tabelle formatiert ausgeben
        for (int i = 0; i < rows; i++)
        {
            // Jede Spalte der aktuellen Zeile ausgeben
            for (int j = 0; j < cols; j++)
            {
                // Wert erneut normalisieren
                string value = Normalize(table[i, j]);

                // Wert mit Leerzeichen auffüllen und ausgeben
                //Console.Write($"{value.PadRight(widths[j] + 5)} ");
                Console.Write($"| {value.PadRight(widths[j] +3)}");
            }

            // Neue Zeile nach jeder Tabellenzeile
            Console.WriteLine();
        }
        PrintSeparator();
    }

    private string Normalize(string? value)
    {
        return string.IsNullOrEmpty(value) ? emptyStr : value;
    }

    private void PrintJagged(string[][] table)
    {
        var normalized = table
            .Select(r => r.Select(v => string.IsNullOrEmpty(v) ? emptyStr : v).ToArray())
            .ToArray();

        int cols = normalized[0].Length;

        int[] widths = Enumerable.Range(0, cols)
            .Select(c => normalized.Max(r => r[c].Length))
            .ToArray();

        foreach (var row in normalized)
        {
            for (int j = 0; j < cols; j++)
                Console.Write($"{row[j].PadRight(widths[j] + 5)} ");

            Console.WriteLine();
        }
        PrintSeparator();
    }

    private void PrintSeparator()
    {
       int width = Console.WindowWidth - 1;
        Console.WriteLine(new string('-', width));
    }

}
