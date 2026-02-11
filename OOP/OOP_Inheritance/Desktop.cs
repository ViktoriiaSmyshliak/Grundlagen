
namespace OOP.OOP_Inheritance
{
    public class Desktop : Computer
{
    public Desktop(short ram, string hersteller, string modell)
        : base(ram, STANDARD_HDD, hersteller, modell) { }

    public Desktop(int hdd, string hersteller, string modell)
        : base(STANDARD_RAM, hdd, hersteller, modell) { }

    public Desktop(string hersteller, string modell)
        : base(STANDARD_RAM, STANDARD_HDD, hersteller, modell) { }

    public Desktop(short ram, int hdd, string hersteller, string modell)
        : base(ram, hdd, hersteller, modell) { }

        public Desktop()
        {
        }
    }

}
