using OOP.OOP_Inheritance;

public sealed class Server : Desktop
{
    public string Raid { get; set; }

    public Server(short ram, string hersteller, string modell)
        : base(ram, hersteller, modell) { }

    public Server(int hdd, string hersteller, string modell)
        : base(hdd, hersteller, modell) { }

    public Server(string hersteller, string modell)
        : base(hersteller, modell) { }

    public Server(short ram, int hdd, string hersteller, string modell)
        : base(ram, hdd, hersteller, modell) { }

    public Server()
    {
    }
}
