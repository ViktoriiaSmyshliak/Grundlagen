using System.Collections.Generic;

class Belegschaft
{
    // internal storage of employees
    private readonly List<Mitarbeiter> mitarbeiterListe = new List<Mitarbeiter>();

    // adds a new employee to the collection
    public void NeuerMitarbeiter(string name, Abteilung abteilung, string geburtstag)
    {
        mitarbeiterListe.Add(new Mitarbeiter(name, abteilung, geburtstag));
    }

    // indexer 1: access employee by 1-based number (read-only)
    public Mitarbeiter this[int nummer]
    {
        get
        {
            return mitarbeiterListe[nummer - 1]; // convert to 0-based list index
        }
    }

    // indexer 2: returns birthday list by month and day
    // if tag == -1 → return all employees of the given month
    public List<Mitarbeiter> this[int monat, int tag]
    {
        get
        {
            var ergebnis = new List<Mitarbeiter>();

            foreach (var mitarbeiter in mitarbeiterListe)
            {
                bool monatStimmt = mitarbeiter.Geburtstag.Month == monat;
                bool tagStimmt = tag == -1 || mitarbeiter.Geburtstag.Day == tag;

                if (monatStimmt && tagStimmt)
                {
                    ergebnis.Add(mitarbeiter);
                }
            }

            return ergebnis; // return materialized result list
        }
    }

    // indexer 3: get or set department using employee object
    public Abteilung this[Mitarbeiter mitarbeiter]
    {
        get
        {
            return mitarbeiter.Abteilung; // return current department
        }
        set
        {
            mitarbeiter.Versetzen(value); // change department via encapsulated method
        }
    }
}