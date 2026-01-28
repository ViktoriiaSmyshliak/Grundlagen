using System;

public static class Strings
{
    // demonstrates how strings differ from other reference types
    public static void StringVsOtherReferenceTypes()
    {
        // string is immutable
        string a = "Hello";
        string b = a;

        // create a new string by modification
        b = b.Replace("H", "J");

        Console.WriteLine(a); // "Hello"
        Console.WriteLine(b); // "Jello"

        // key theory points:
        // - string is a reference type BUT immutable
        // - copying a string variable copies the reference
        // - any modification creates a NEW string object
    }

    // string properties and methods
    public static void StringOperations()
    {
        string hallo = "Hallo Welt!";

        // output the 3rd character (index 2)
        Console.WriteLine($"Das 3. Zeichen in \"{hallo}\" ist ein '{hallo[2]}'");

        // create string from char array
        char[] c = { '-', ' ', 'c', 'i', 'a', 'o', '!' };
        string str = new string(c);
        Console.WriteLine($"String aus char[] = {str}");

        // create string with 43 '*' characters
        str = new string('*', 43);
        Console.WriteLine(str);

        // output string length
        Console.WriteLine($"Länge des Strings: {hallo.Length} Zeichen");

        // upper and lower case
        Console.WriteLine($"in Großbuchstaben: {hallo.ToUpper()}");
        Console.WriteLine($"in Kleinbuchstaben: {hallo.ToLower()}");

        // starts with "!"
        Console.WriteLine($"beginnt mit \"!\"? {hallo.StartsWith("!")}");

        // ends with "!"
        Console.WriteLine($"endet mit \"!\"? {hallo.EndsWith("!")}");

        // contains "abc"
        Console.WriteLine($"enthält \"abc\"? {hallo.Contains("abc")}");

        // index of "ll"
        Console.WriteLine($"'ll' steht an Index-Position {hallo.IndexOf("ll")}");

        // last index of 'l'
        Console.WriteLine($"das letzte \"l\" steht an Index-Position {hallo.LastIndexOf('l')}");

        // first index of any character from char array c
        Console.WriteLine(
            $"erste Index-Pos. eines Zeichens aus char[]: {hallo.IndexOfAny(c)}"
        );

        // substring from index 6
        Console.WriteLine($"Teilstring ab Index-Position 6: {hallo.Substring(6)}");

        // 4 characters from index 6
        Console.WriteLine($"4 Zeichen ab Index-Position 6: {hallo.Substring(6, 4)}");

        // split string by space
        string[] teile = hallo.Split(' ');
        foreach (string teil in teile)
        {
            Console.WriteLine(teil);
        }

        // join array into string
        Console.WriteLine($"string-Array zusammenführen: {string.Join("", teile)}");

        // join array with separator
        Console.WriteLine(
            $"string-Array mit Trennzeichen zusammenführen: {string.Join("___", teile)}"
        );

        // insert text at index 6
        Console.WriteLine(
            $"String ab Index-Position 6 einfügen: {hallo.Insert(6, "schöne ")}"
        );

        // remove all characters from index 5
        Console.WriteLine(
            $"alle Zeichen ab Index-Position 5 entfernen: {hallo.Remove(5)}"
        );

        // remove 5 characters from index 5
        Console.WriteLine(
            $"5 Zeichen ab Index-Position 5 entfernen: {hallo.Remove(5, 5)}"
        );

        // pad left to length 20 with spaces
        Console.WriteLine(
            $"20 Zeichen, rechtsbündig, links Leerzeichen: >>>{hallo.PadLeft(20)}<<<"
        );

        // pad right to length 20 with dots
        Console.WriteLine(
            $"20 Zeichen, linksbündig, rechts Punkte: >>>{hallo.PadRight(20, '.')}<<<"
        );

        // trim spaces
        string abc = " a b c ";
        Console.WriteLine(abc.Trim());

        // trim characters from start
        string text = "--- Hallo Welt! ---";
        Console.WriteLine(text.TrimStart(c));

        // trim characters from end
        Console.WriteLine(text.TrimEnd(c));

        // trim characters from both sides
        Console.WriteLine(text.Trim(c));

        // replace substring
        Console.WriteLine(text.Replace("Welt", "Leute"));
    }
}
