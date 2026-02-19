using OOP.OOP_Basics;
using OOP.OOP_Inheritance;
using OOP.OOP_Polymorphie.Interfaces;
using OOP.OOP_Polymorphie.Models;
using OOP.OOP_Polymorphie.Models.Geschaeftsgebaeude;
using OOP.OOP_Polymorphie.Models.Wohngebaeude;
using OOP.Services;

public static class AppRunner
{

    public static void RunComputerBasics()
    {
        Computer pc = new Computer();

        pc.Hersteller = "Dell";
        pc.SpeicherGB = 16;

        Console.WriteLine($"Manufacturer: {pc.Hersteller}");
        Console.WriteLine($"Memory (GB): {pc.SpeicherGB}");

        Console.WriteLine($"Disk Capacity (GB): {pc.GetFestplattenKapazitaet()}");

        Computer dummy = null;

        pc.Hersteller = "Asus";

        pc.SpeicherGB = -8;

        pc.SpeicherGB = 16;
        Console.WriteLine(pc.SpeicherBytes);
    }

    public static void RunComputerMethoden()
    {
        Computer pc = new Computer();

        pc.Hersteller = "Asus";
        pc.SpeicherGB = 8;

        Console.WriteLine(pc.Hersteller);
        Console.WriteLine(pc.SpeicherGB);

        int hdd = pc.FormatHDD();
        Console.WriteLine("Gesamtgröße: " + hdd + " GB");

        pc.NetzteilAendern();
        Console.WriteLine("Spannung: " + pc.Spannung);

        pc.Schalten(true);
        pc.Schalten(false);
    }

    public static void RunComputerKonstruktoren()
    {
        Computer desktop = new Computer(8, 4000);
        Computer notebook = new Computer(4, 2000);
        Computer server = new Computer(32, 8000);

        Console.ReadKey();
    }

    public static void RunComputerKonstanten()
    {
        Computer pc = new Computer("ASUS");

        Console.WriteLine($"Class constant STANDARD_HERSTELLER = {Computer.STANDARD_HERSTELLER}");
        Console.WriteLine($"Instance Modell = {pc.Modell}");
        Console.WriteLine($"Instance Seriennummer = {pc.Seriennummer}");

        Console.ReadKey();
    }

    public static void RunComputerStaticVerwaltung()
    {
        var pc1 = new Computer(8, 2000, "ASUS");
        var pc2 = new Computer(16, 4000, "Dell");
        var pc3 = new Computer(32, 8000, "HP");

        Console.WriteLine();
        Computerverwaltung.ListeZeigen();

        Console.ReadKey();
    }

    public static void RunRechteckKreis()
    {
        while (true)
        {
            Console.WriteLine("Rechteck:");

            Rechteck r = new Rechteck();

            Console.Write("Seite A: ");
            r.SeiteA = Convert.ToDouble(Console.ReadLine());

            Console.Write("Seite B: ");
            r.SeiteB = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Flaeche = {r.Flaeche}");
            Console.WriteLine($"Umfang = {r.Umfang}");
            Console.WriteLine($"Diagonale = {r.Diagonale}");

            Console.WriteLine();

            Console.WriteLine("Kreis:");

            Kreis k = new Kreis();

            Console.Write("Durchmesser: ");
            k.Durchmesser = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Flaeche = {k.Flaeche}");
            Console.WriteLine($"Umfang = {k.Umfang}");

            Console.WriteLine();
            Console.WriteLine("Nochmal? Abbruch mit [X]");

            string input = Console.ReadLine();
            if (input?.ToUpper() == "X")
                break;

            Console.Clear();
        }
    }

    public static void RunAktion()
    {
        Aktion aktion = new Aktion();
        Aktion reaktion = new Aktion();

        int arg = 100;

        aktion.WertAendern(reaktion, arg);

        Console.WriteLine($"reaktion.Wert = {reaktion.Wert}, arg = {arg}");

        aktion.ArgAendern(ref arg);
        Console.WriteLine($"arg nach ref = {arg}");

        aktion.ArgInitialisieren(out arg);
        Console.WriteLine($"arg nach out = {arg}");

        aktion.ArgAnzeigen(in arg);
        Console.WriteLine($"arg nach in = {arg}");

        aktion.ParameterVerwenden(100, "hallo");
        aktion.ParameterVerwenden(100, "hallo", 1.234f);
        aktion.ParameterVerwenden(100, "hallo", 0.1f, false);
        aktion.ParameterVerwenden(100, "hallo", doit: false);

        aktion.ParameterVerwenden(100, "hallo", werte: new byte[] { 1, 2, 3 });
    }

    public static void RunMenuSystem()
    {
        Konsole konsole = new Konsole();
        konsole.Menu("C# OOP: Abschlussübung Methoden");

        Console.Write("Das Programm wird beendet mit: ");
        Console.ForegroundColor = konsole.Farbe;
        Console.WriteLine(konsole.Text);
        Console.ResetColor();
    }

    public static void RunStatistik()
    {
        Statistik statistik = new Statistik();

        string titel = "Auswertung I";
        bool invalid = statistik.Auswerten(
            titel,
            new List<int> { 1, 12, 18, 46, 34, 25 },
            out double avg,
            25,
            ConsoleColor.Cyan);

        ShowResult(invalid, avg);

        titel = "Auswertung II";
        invalid = statistik.Auswerten(
            titel,
            new List<int> { 7, 12, 17, 22, 20, 22, 17, 12, 7 },
            out avg,
            25,
            ConsoleColor.Red);

        ShowResult(invalid, avg);

        titel = "Auswertung III";
        invalid = statistik.Auswerten(
            titel,
            new List<int> { 5, 15, 25, 35, 40, 39, 38, 37 },
            out avg,
            40,
            ConsoleColor.Green);

        ShowResult(invalid, avg);
    }

    static void ShowResult(bool invalid, double avg)
    {
        Console.WriteLine($"Durchschnittswert {avg:F2}");

        if (!invalid)
            Console.WriteLine("Alle Werte ok.");
        else
            Console.WriteLine("Ungültige Werte!");

        Console.ReadKey();
        Console.Clear();
    }

    public static void RunTypenschild()
    {
        Typenschild schild = new Typenschild("Dell", "Vostro", "ABCDE12345");

        schild.Drucken();

        Console.ReadKey();
    }

    public static void RunStructPropertyProblem()
    {
        Person ich = new Person("Thomas", "Meyer");

        Console.WriteLine($"Ich bin {ich.Name.Vorname} {ich.Name.Nachname}");

        // Important: struct must be changed via temp copy
        Name temp = ich.Name;
        temp.Vorname = "Max";
        ich.Name = temp;

        Console.WriteLine($"Ich bin {ich.Name.Vorname} {ich.Name.Nachname}");
    }

    public static void RunInheritance()
    {
        Desktop d = new Desktop((short)16, 4000, "Dell", "OptiPlex");
        Notebook n = new Notebook((short)8, 2000, "HP", "EliteBook");
        Server s = new Server((short)32, 8000, "IBM", "Power");

        d.Schalten(true);
        n.Schalten(true);
        s.Schalten(true);
    }

    public static void TypUntersuchen(object obj)
    {
        Console.WriteLine($"Typ: {obj.GetType().Name}");

        Console.WriteLine($"Ist Server: {obj is Server}");
        Console.WriteLine($"Ist Desktop: {obj is Desktop}");
        Console.WriteLine($"Ist Notebook: {obj is Notebook}");
        Console.WriteLine($"Ist Computer: {obj is Computer}");
        Console.WriteLine($"Ist Object: {obj is object}");

        Console.WriteLine();
    }

    public static void RunTypPruefung()
    {
        Computer computer = new Computer();
        Desktop desktop = new Desktop();
        Notebook notebook = new Notebook();
        Server server = new Server();

        server.Raid = "RAID 5";

        TypUntersuchen(computer);
        TypUntersuchen(desktop);
        TypUntersuchen(notebook);
        TypUntersuchen(server);

        Console.WriteLine("---- Server in Desktop Variable ----");

        desktop = server;

        TypUntersuchen(desktop);

        Console.WriteLine("---- Casting ----");

        if (desktop is Server dummy)
        {
            Console.WriteLine(dummy.Raid);
        }

        Console.WriteLine("---- Null Safe ----");

        Server nullDummy = null;

        Console.WriteLine(nullDummy?.Raid);

        Console.ReadKey();
    }

    public static void RunMakler()
    {
        // Wohngebaeude
        Gebaeude haus = new Einfamilienhaus(
            gesamtnutzflaecheQm: 140,
            gartenQm: 300,
            miete: 1200,
            einbaukueche: true
        );

        Gebaeude villa = new Villa(
            gesamtnutzflaecheQm: 280,
            gartenQm: 800,
            miete: 3200,
            einliegerwohnung: true
        );

        // Geschaeftsgebaeude
        Gebaeude laden = new Laden(
            gesamtnutzflaecheQm: 90,
            pacht: 1500,
            verkaufsflaecheQm: 70
        );

        Gebaeude restaurant = new Restaurant(
            gesamtnutzflaecheQm: 200,
            pacht: 2800,
            anzahlTische: 25,
            aussenbewirtschaftung: true
        );

        Gebaeude buero = new Buero(
            gesamtnutzflaecheQm: 160,
            pacht: 2100,
            notstromversorgung: false
        );

        var list = new List<IPrintable>
        {
            haus,
            villa,
            laden,
            restaurant,
            buero
        };

        PrintHelper.PrintAll(list);
    }

    // Demonstrates polymorphism vs method hiding using direct calls and base-type array calls
    // Shows difference between override (runtime dispatch) and new (compile-time binding)
    public static void RunPolymorphism()
    {
        Console.WriteLine("===== DIRECT CALLS =====");

        Computer computer = new Computer();
        Desktop desktop = new Desktop();
        Notebook notebook = new Notebook();
        Server server = new Server();

        computer.Schalten();
        desktop.Schalten();
        notebook.Schalten();
        server.Schalten();

        Console.WriteLine();
        Console.WriteLine("===== ARRAY CALLS (Computer reference) =====");

        Computer[] computers =
        {
            computer,
            desktop,
            notebook,
            server
        };

        foreach (Computer currentComputer in computers)
        {
            Console.WriteLine($"Type in array: {currentComputer.GetType().Name}");
            currentComputer.Schalten();
            Console.WriteLine();
        }
    }

    // ================= INTERFACES ===================
    // Schnittstellen Aufgabe: IRabatt definieren und implementieren,
    // nur rabattfaehige Artikel in Rabattliste speichern und anzeigen
    // Interface task: define and implement IRabatt,
    // store and display only discount-capable products in Rabattliste
    // -------------------------------------------------
    public static void RunRabattliste()
    {
        // Catalog objects
    CatalogDesktop desktop = new("Dell", "OptiPlex 790", "C-DT001", 200.00);
    CatalogServer server = new("HP", "Z2 Mini G3", "C-SV001", 1200.00);
    Buerostuhl buerostuhl = new("Merax", "Chefsessel", "M-BS001", 180.00);

    // Assign discount values
    desktop.NeuerRabatt(15);
    server.NeuerRabatt(20);
    buerostuhl.NeuerRabatt(25);

    // Assign discount period (extended interface usage)
    buerostuhl.RabattVon = DateTime.Today;
    buerostuhl.RabattBis = DateTime.Today.AddDays(30);

    // Create discount list (works via IRabatt interface)
    Rabattliste rabattliste = new();

    rabattliste.Hinzufuegen(desktop);
    rabattliste.Hinzufuegen(server);
    rabattliste.Hinzufuegen(buerostuhl);

    // Output standard discount catalog
    Console.WriteLine("=== Rabattliste ===");
    rabattliste.Anzeigen();

    // Check extended interface availability
    Console.WriteLine();
    Console.WriteLine("=== IRabattVonBis Check ===");

    if (buerostuhl is IRabattVonBis extended)
    {
        Console.WriteLine($"Discount from: {extended.RabattVon:d}");
        Console.WriteLine($"Discount until: {extended.RabattBis:d}");
    }

    // Interface polymorphism test
    Console.WriteLine();
    Console.WriteLine("=== Interface Test ===");

    IRabatt test = buerostuhl;
    Console.WriteLine($"Discount: {test.Rabatt}%");

    if (test is IRabattVonBis ext)
    {
        Console.WriteLine($"From: {ext.RabattVon:d}");
        Console.WriteLine($"Until: {ext.RabattBis:d}");
    }

    Console.ReadKey();
    }

}

