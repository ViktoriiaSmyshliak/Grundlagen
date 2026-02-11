public class Konsole
{
    public ConsoleColor Farbe { get; private set; }
    public string Text { get; private set; }

    ConsoleKey lastKey;

    public void Menu(string title)
    {
        Console.Title = title;
        ShowMenuLoop();
    }

    void ShowMenuLoop()
    {
        bool exit = false;

        do
        {
            Console.WriteLine("===== Hauptmenü =====");
            Console.WriteLine("[E] Text eingeben");
            Console.WriteLine("[F] Farbe wählen");
            Console.WriteLine("[A] Text ausgeben");
            Console.WriteLine("[X] Beenden");

            lastKey = Console.ReadKey(true).Key;

            switch (lastKey)
            {
                case ConsoleKey.E: InputText(); break;
                case ConsoleKey.F: SelectColor(); break;
                case ConsoleKey.A: PrintText(); break;
                case ConsoleKey.X: exit = true; break;
            }

        } while (!exit);
    }

    void InputText()
    {
        Console.Write("Bitte Text eingeben: ");
        Text = Console.ReadLine();
    }

    void SelectColor()
    {
        Console.WriteLine("Bitte Farbe wählen:");

        Console.WriteLine("[W] Weiß", Console.ForegroundColor = ConsoleColor.White);
        Console.WriteLine("[C] Cyan", Console.ForegroundColor = ConsoleColor.Cyan);
        Console.WriteLine("[Y] Gelb", Console.ForegroundColor = ConsoleColor.Yellow);
        Console.WriteLine("[G] Grün", Console.ForegroundColor = ConsoleColor.Green);

        Console.ResetColor();
        Console.WriteLine("[S] Standard");

        bool valid;

        do
        {
            valid = true;
            lastKey = Console.ReadKey(true).Key;

            switch (lastKey)
            {
                case ConsoleKey.W: Farbe = ConsoleColor.White; break;
                case ConsoleKey.C: Farbe = ConsoleColor.Cyan; break;
                case ConsoleKey.Y: Farbe = ConsoleColor.Yellow; break;
                case ConsoleKey.G: Farbe = ConsoleColor.Green; break;
                case ConsoleKey.S:
                    Console.ResetColor();
                    Farbe = Console.ForegroundColor;
                    break;
                default:
                    valid = false;
                    break;
            }

        } while (!valid);

        Console.Write("Gewählte Farbe: [");
        Console.Write($"{Farbe}", Console.ForegroundColor = Farbe);
        Console.ResetColor();
        Console.WriteLine("]");
    }

    void PrintText()
    {
        if (Farbe == default)
            Console.WriteLine("Es wurde noch keine Farbe gewählt!");

        if (Text == default)
            Console.WriteLine("Es wurde noch kein Text eingegeben!");
        else
            Console.WriteLine($"{Text} ({Text.Length} Zeichen)",
                Console.ForegroundColor = Farbe);

        Console.ResetColor();
    }
}
