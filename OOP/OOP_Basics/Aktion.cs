public class Aktion
{
    public int Wert { get; set; }

    public void TuWas()
    {
        Console.WriteLine("Ich tue was für unbestimmte Zeit.");
    }

    public void TuWas(string aktion)
    {
        Console.WriteLine($"Ich {aktion} für unbestimmte Zeit.");
    }

    public void TuWas(int dauer)
    {
        Console.WriteLine($"Ich tue was für {dauer} Stunden.");
    }

    public void TuWas(string aktion, int dauer)
    {
        Console.WriteLine($"Ich {aktion} für {dauer} Stunden.");
    }

    public void WertAendern(Aktion paraAktion, int wert)
    {
        paraAktion.Wert = wert;
        wert = 999;
    }

    public void ArgAendern(ref int arg)
    {
        arg = 999;
    }

    public void ArgInitialisieren(out int arg)
    {
        arg = 888;
    }

    public void ArgAnzeigen(in int arg)
    {
        Console.WriteLine(arg);
    }

    // Base method required by theory
    public void ParameterVerwenden(int zahl, string text)
    {
        Console.WriteLine($"zahl={zahl}, text={text}");
    }

    // Extended version with optional + params (course defaults)
    public void ParameterVerwenden(
        int zahl,
        string text,
        float para = 0.1f,
        bool doit = true,
        params byte[] werte)
    {
        Console.WriteLine($"zahl={zahl}, text={text}, para={para}, doit={doit}");

        if (werte != null && werte.Length > 0)
        {
            Console.WriteLine(string.Join(",", werte));
        }
    }
}
