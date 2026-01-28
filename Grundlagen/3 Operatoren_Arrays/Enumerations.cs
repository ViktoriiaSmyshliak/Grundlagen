using System;

public static class Enumerations
{
    // enumeration of months (default values: 0..11)
    public enum Monat
    {
        Januar,
        Februar,
        Maerz,
        April,
        Mai,
        Juni,
        Juli,
        August,
        September,
        Oktober,
        November,
        Dezember
    }

    // enumeration of months with explicit numeric values (1..12)
    public enum MonatMitNummer
    {
        Januar = 1,
        Februar = 2,
        Maerz = 3,
        April = 4,
        Mai = 5,
        Juni = 6,
        Juli = 7,
        August = 8,
        September = 9,
        Oktober = 10,
        November = 11,
        Dezember = 12
    }

    // enumeration of weekdays
    public enum Wochentag
    {
        Montag,
        Dienstag,
        Mittwoch,
        Donnerstag,
        Freitag,
        Samstag,
        Sonntag
    }

    // enumeration of animals
    // Vogel is the default value (0)
    public enum Tier
    {
        Vogel,
        Hund,
        Katze
    }

    public static void Months()
    {
        // current month (example)
        Monat monat = Monat.Dezember;

        // output month name
        Console.WriteLine(monat);

        // output month number using index + 1
        Console.WriteLine($"{monat} ist der {(int)monat + 1}. Monat des Jahres.");

        // using enum with explicit numeric values
        MonatMitNummer monatNummer = MonatMitNummer.Dezember;
        Console.WriteLine($"{monatNummer} ist der {(int)monatNummer}. Monat des Jahres.");
    }

    public static void Weekdays()
    {
        Wochentag wochentag = Wochentag.Mittwoch;

        // same output statement for both cases
        Console.WriteLine(
            wochentag == Wochentag.Samstag || wochentag == Wochentag.Sonntag
                ? $"Am {wochentag} habe ich frei."
                : $"Am {wochentag} muss ich lernen."
        );

        // assign Saturday
        wochentag = Wochentag.Samstag;

        Console.WriteLine(
            wochentag == Wochentag.Samstag || wochentag == Wochentag.Sonntag
                ? $"Am {wochentag} habe ich frei."
                : $"Am {wochentag} muss ich lernen."
        );
    }

    public static void Animals()
    {
        // default value is Vogel
        Tier tier = Tier.Katze;

        // output assigned animal
        Console.WriteLine(tier);

        // array with 5 elements "Vogel"
        Tier[] tiere = new Tier[5]
        {
            Tier.Vogel,
            Tier.Vogel,
            Tier.Vogel,
            Tier.Vogel,
            Tier.Vogel
        };

        Console.WriteLine(tiere.Length);
    }
}
