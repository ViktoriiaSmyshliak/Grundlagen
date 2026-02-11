namespace OOP.OOP_Inheritance
{
    public static class Computerverwaltung
    {
        private static Dictionary<string, Computer> computerliste;

        static Computerverwaltung()
        {
            computerliste = new Dictionary<string, Computer>();
        }

        public static void Hinzufuegen(Computer computer)
        {
            computerliste[computer.Seriennummer] = computer;
        }

        public static int GesamtAnzahl()
        {
            return computerliste.Count;
        }

        public static void ListeZeigen()
        {
            Console.WriteLine($"Gesamtanzahl Computer: {computerliste.Count}");
            Console.WriteLine();

            foreach (var computer in computerliste.Values)
            {
                Console.WriteLine(
                    $"Computer {computer.Hersteller}, Modell {computer.Modell}, SN {computer.Seriennummer}, RAM {computer.SpeicherGB} GB");
            }
        }
    }
}
