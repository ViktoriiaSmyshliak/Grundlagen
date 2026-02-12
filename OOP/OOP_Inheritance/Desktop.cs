
namespace OOP.OOP_Inheritance
{
    public class Desktop : Computer
    {
        public string Gehaeuse { get; set; }
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
        public sealed override void Schalten()
        {
            base.Schalten();
            Console.WriteLine("...Desktop...");
        }

        public double Rabatt { get; private set; }

        public void SetRabatt(double rabatt)
        {
            if (rabatt >= 0 && rabatt <= 100)
                Rabatt = rabatt;
        }
    }
}
