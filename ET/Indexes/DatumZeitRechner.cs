using System;

class DatumZeitRechner
{
    // first indexer uses enum instead of magic strings
    public enum Anzeige
    {
        Datum,
        Zeit
    }

    // second indexer unit enum (nested for cohesion)
    public enum Einheit
    {
        Jahr,
        Monat,
        Woche,
        Tag,
        Stunde,
        Minute
    }

    // indexer 1: returns current date (long) or time (with seconds)
    public string this[Anzeige typ]
    {
        get
        {
            return typ switch
            {
                Anzeige.Datum => DateTime.Today.ToLongDateString(), // date only
                Anzeige.Zeit  => DateTime.Now.ToLongTimeString(),   // time incl. seconds
                _ => string.Empty
            };
        }
    }

    // indexer 2: adds difference to date or time depending on unit
    public string this[Einheit einheit, double differenz]
    {
        get
        {
            return einheit switch
            {
                // date-based operations (use Today)
                Einheit.Jahr   => DateTime.Today
                                      .AddYears((int)differenz)
                                      .ToLongDateString(),

                Einheit.Monat  => DateTime.Today
                                      .AddMonths((int)differenz)
                                      .ToLongDateString(),

                Einheit.Woche  => DateTime.Today
                                      .AddDays(differenz * 7)
                                      .ToLongDateString(),

                Einheit.Tag    => DateTime.Today
                                      .AddDays(differenz)
                                      .ToLongDateString(),

                // time-based operations (use Now)
                Einheit.Stunde => DateTime.Now
                                      .AddHours(differenz)
                                      .ToShortTimeString(),

                Einheit.Minute => DateTime.Now
                                      .AddMinutes(differenz)
                                      .ToShortTimeString(),

                _ => string.Empty
            };
        }
    }
}