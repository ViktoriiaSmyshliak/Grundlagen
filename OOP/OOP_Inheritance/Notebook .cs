using OOP.OOP_Inheritance;

public class Notebook : Computer
{
    public Notebook(short ram, string hersteller, string modell)
        : base(ram, STANDARD_HDD, hersteller, modell) { }

    public Notebook(int hdd, string hersteller, string modell)
        : base(STANDARD_RAM, hdd, hersteller, modell) { }

    public Notebook(string hersteller, string modell)
        : base(STANDARD_RAM, STANDARD_HDD, hersteller, modell) { }

    public Notebook(short ram, int hdd, string hersteller, string modell)
        : base(ram, hdd, hersteller, modell) { }

    public Notebook()
    {
    }
}
