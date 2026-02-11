namespace OOP.OOP_Inheritance
{
    public class Computer
    {
        /* =========================
           Class Constants
        ========================= */

        public const string STANDARD_HERSTELLER = "Eigenbau";

        public const short STANDARD_SPANNUNG = 230;
        public const int STANDARD_HDD = 2000;
        public const short STANDARD_RAM = 8;

        /* =========================
           Fields
        ========================= */

        private int hddGB;
        private int _speicherGB;
        private short _spannung = STANDARD_SPANNUNG;

        /* =========================
           Instance "Constants" (readonly)
        ========================= */

        public readonly string Modell;

        public string Seriennummer { get; }

        /* =========================
           Properties
        ========================= */

        public string Hersteller;

        public int SpeicherGB
        {
            get => _speicherGB;
            set
            {
                if (value >= 0) _speicherGB = value;
                else Console.WriteLine("Der Speicher darf nicht negativ sein!");
            }
        }

        public long SpeicherBytes => SpeicherGB * 1024L * 1024 * 1024;

        public short Spannung
        {
            get => _spannung;
            private set => _spannung = value;
        }

        public bool Zustand { get; private set; }

        public string USB { get; set; } = "nicht angeschlossen";

        /* =========================
           Constructors
        ========================= */

        public Computer(
            string hersteller = STANDARD_HERSTELLER,
            string modell = "")
            : this(STANDARD_RAM, STANDARD_HDD, hersteller, modell) { }

        public Computer(
            int hddGB,
            string hersteller = STANDARD_HERSTELLER,
            string modell = "")
            : this(STANDARD_RAM, hddGB, hersteller, modell) { }

        public Computer(
            short speicherGB,
            string hersteller = STANDARD_HERSTELLER,
            string modell = "")
            : this(speicherGB, STANDARD_HDD, hersteller, modell) { }

        public Computer(
            short speicherGB,
            int hddGB,
            string hersteller = STANDARD_HERSTELLER,
            string modell = "")
        {
            this.hddGB = hddGB;
            SpeicherGB = speicherGB;
            Hersteller = hersteller;

            Modell = string.IsNullOrEmpty(modell) ? "Mein i7" : modell;

            Seriennummer = Guid.NewGuid().ToString("N");

            // register object globally
            Computerverwaltung.Hinzufuegen(this);

            ShowConfig();
        }

        /* =========================
           Public Methods
        ========================= */

        public int GetFestplattenKapazitaet() => hddGB;

        public int FormatHDD()
        {
            Console.WriteLine($"Die Festplatte mit {hddGB} GB wird formatiert...");
            return hddGB;
        }

        public void NetzteilAendern()
        {
            Console.Write("Neue Spannung eingeben: ");
            int value = Convert.ToInt32(Console.ReadLine());

            if (value <= 0)
            {
                Console.WriteLine("Das Netzteil wurde nicht geändert.");
                return;
            }

            Spannung = (short)value;
        }

        public void Schalten(bool einschalten)
        {
            if (Zustand == einschalten)
            {
                Console.WriteLine(einschalten
                    ? "Der Computer ist bereits eingeschaltet!"
                    : "Der Computer ist bereits ausgeschaltet!");
                return;
            }

            Zustand = einschalten;

            Console.WriteLine(einschalten
                ? "Der Computer wurde eingeschaltet."
                : "Der Computer wurde ausgeschaltet.");
        }

        /* =========================
           Helpers
        ========================= */

        private void ShowConfig()
        {
            Console.WriteLine(
                $"Computer {Hersteller}, Modell {Modell}, SN {Seriennummer}, RAM {SpeicherGB} GB, HDD {hddGB} GB");
        }
    }
}
