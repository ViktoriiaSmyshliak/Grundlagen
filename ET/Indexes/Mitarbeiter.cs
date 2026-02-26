using System;
using System.Globalization;

class Mitarbeiter
{
    public string Name { get; private set; }
    public Abteilung Abteilung { get; private set; }
    public DateTime Geburtstag { get; private set; }

    public Mitarbeiter(string name, Abteilung abteilung, string geburtstag)
    {
        Name = name;
        Abteilung = abteilung;

        // parse date using fixed format to avoid culture-dependent errors
        Geburtstag = DateTime.ParseExact(
            geburtstag,
            "dd.MM.yyyy",
            CultureInfo.InvariantCulture);
    }

    public void Versetzen(Abteilung neueAbteilung)
    {
        Abteilung = neueAbteilung; // encapsulated department change
    }
}