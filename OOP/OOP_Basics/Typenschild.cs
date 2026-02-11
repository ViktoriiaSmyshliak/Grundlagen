namespace OOP.OOP_Basics
{
    public struct Typenschild
    {
        public string Hersteller;
        public string Modell;
        public string Seriennummer;

        // ===== Constructors =====

        public Typenschild(string hersteller)
        {
            Hersteller = hersteller;
            Modell = "";
            Seriennummer = "";
        }

        public Typenschild(string hersteller, string modell)
        {
            Hersteller = hersteller;
            Modell = modell;
            Seriennummer = "";
        }

        public Typenschild(string hersteller, string modell, string seriennummer)
        {
            Hersteller = hersteller;
            Modell = modell;
            Seriennummer = seriennummer;
        }

        // ===== Methods =====

        public void Drucken()
        {
            const int width = 78;

            Console.WriteLine(new string('*', width));

            PrintLine("Hersteller", Hersteller, width);
            PrintLine("Modell", Modell, width);
            PrintLine("Seriennummer", Seriennummer, width);

            Console.WriteLine(new string('*', width));
        }

        private void PrintLine(string label, string value, int width)
        {
            string content = $"* {label,-15} : {value}";
            Console.WriteLine(content.PadRight(width - 1) + "*");
        }
    }

}
