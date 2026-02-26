using System;
using System.Globalization;

public class MitarbeiterLinq
{
    public string Name { get; }
    public string Vorname { get; }
    public Abteilung Abteilung { get; }
    public double Gehalt { get; }
    public DateTime Geburtstag { get; }

    public MitarbeiterLinq(
        string name,
        string vorname,
        Abteilung abteilung,
        double gehalt,
        string geburtstag)
    {
        Name = name;
        Vorname = vorname;
        Abteilung = abteilung;
        Gehalt = gehalt;

        // parse fixed German date format independent of system culture
        Geburtstag = DateTime.ParseExact(
            geburtstag,
            "dd.MM.yyyy",
            CultureInfo.InvariantCulture);
    }
}