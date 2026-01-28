using System;

public static class OtherOperators
{
    public static void ConcatenationDemo()
    {
        int i = 100;

        // concatenate text with variable value
        string text = "Variable i = " + i;
        Console.WriteLine(text);

        // concatenate text, variable value and literal value
        text = "Variable i = " + i + 1;
        Console.WriteLine(text); // "1001" because of string concatenation

        // concatenate text with arithmetic expression
        text = "Variable i = " + (i + 1);
        Console.WriteLine(text); // "101"
    }

    public static void TernaryOperatorDemo()
    {
        Random zufallszahlen = new Random();

        // generate random hour between 0 and 23
        int uhrzeit = zufallszahlen.Next(0, 24);

        // ternary operator: morning or afternoon
        string tageszeit = uhrzeit < 12 ? "Vormittags" : "Nachmittags";
        Console.WriteLine($"{uhrzeit} Uhr {tageszeit}");

        // extended ternary operator with noon
        tageszeit = uhrzeit == 12
            ? "Mittags"
            : (uhrzeit < 12 ? "Vormittags" : "Nachmittags");

        Console.WriteLine($"{uhrzeit} Uhr {tageszeit}");
    }
}
