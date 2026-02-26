namespace ET.Core
{
    public static class AppRunner
    {
        public static void RunDelegates()
        {
            // ===== Delegate Variable Usage =====
            // Demonstrates:
            // - delegate as method reference container
            // - runtime switching of method logic

            FreizeitCallback callback;

            callback = FreizeitAktionen.Lesen;
            Freizeit.Beschaeftigen(callback, "Harry Potter", 3);

            callback = FreizeitAktionen.BlumenGiessen;
            Freizeit.Beschaeftigen(callback, "Rose", 200);

            callback = FreizeitAktionen.FilmGucken;
            Freizeit.Beschaeftigen(callback, "Matrix", 2);


            Console.WriteLine();


            // ===== Direct Delegate Call =====
            // Demonstrates simplified usage:
            // delegate variable is optional
            // method can be passed directly

            Freizeit.Beschaeftigen(FreizeitAktionen.Lesen, "Herr der Ringe", 1);
            Freizeit.Beschaeftigen(FreizeitAktionen.BlumenGiessen, "Tulpe", 150);
            Freizeit.Beschaeftigen(FreizeitAktionen.FilmGucken, "Avatar", 4);


            Console.WriteLine();


            // ===== Anonymous Method =====
            // Demonstrates:
            // - method created inline
            // - no named method required
            // - still must match delegate signature

            Freizeit.Beschaeftigen(
                delegate (string text, int number)
                {
                    Console.WriteLine($"Ich mache etwas anonym mit {text} und {number}.");
                    return 42;
                },
                "Test",
                5);


            Console.WriteLine();


            // ===== Lambda Expression =====
            // Demonstrates modern shorthand for anonymous methods

            Freizeit.Beschaeftigen(
                (text, number) =>
                {
                    Console.WriteLine($"Lambda Aktion mit {text} und {number}.");
                    return 99;
                },
                "Lambda",
                7);


            Console.ReadKey();
        }


        public static void RunEventsGenerator()
        {
            Zufallszahlengenerator generator1 = new("Generator 1");
            Zufallszahlengenerator generator2 = new("Generator 2");

            Gleitkommagenerator generator3 = new("Generator 3");
            Gleitkommagenerator generator4 = new("Generator 4");


            // ===== Handler (stored to allow unsubscribe) =====
            Zufallszahlengenerator.Groesser50EventHandler handler1 =
                (sender, e) =>
                {
                    var gen = sender as Zufallszahlengenerator;
                    Console.WriteLine($" => {gen.Name} hat die Zufallszahl {e.Zahl} erzeugt, die größer ist als 50.");
                };


            // ===== Subscriptions =====

            // generator1 reacts only to Groesser50
            generator1.Groesser50 += handler1;

            // generator2 reacts only to Gerade
            generator2.Gerade += (sender, e) =>
            {
                var gen = sender as Zufallszahlengenerator;
                Console.WriteLine($" => {gen.Name} hat die gerade Zufallszahl {e.Zahl} erzeugt.");
            };

            // generator3 (double) reacts only to Groesser50
            generator3.Groesser50 += (sender, e) =>
            {
                var gen = sender as Zufallszahlengenerator;
                Console.WriteLine($" => {gen.Name} hat die Gleitkommazahl {e.Gleitkommazahl:F2} erzeugt, die größer ist als 0.5.");
            };

            // generator4 (double) reacts only to Gerade
            generator4.Gerade += (sender, e) =>
            {
                var gen = sender as Zufallszahlengenerator;
                Console.WriteLine($" => {gen.Name} hat die Gleitkommazahl {e.Gleitkommazahl:F2} erzeugt, die durch 0.2 teilbar ist.");
            };


            Console.WriteLine("=== Integer Generatoren ===");
            RunIterations(generator1, 5);
            RunIterations(generator2, 5);
            Console.WriteLine();

            // ===== Unsubscribe example (same logic as task 1) =====
            Console.WriteLine("=== Abmelden Groesser50 von Generator 1 ===");

            generator1.Groesser50 -= handler1;

            RunIterations(generator1, 5);
            Console.WriteLine();

            Console.WriteLine("=== Float Generatoren ===");
            RunIterations(generator3, 5);
            RunIterations(generator4, 5);


            Console.ReadKey();
        }

        // Reused method from previous task (int-based output)
        private static void RunIterations(Zufallszahlengenerator generator, int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"--- Iteration {i + 1} ---");

                int zahl = generator.Erzeugen();

                Console.WriteLine($"Erzeugt: {zahl}");
                Console.WriteLine();
            }
        }

        public static void RunGenerics()
        {
            // ===== generic class Demo<T> =====
            // same class works with different types
            Demo<int> demoInt = new();
            demoInt.SetValue(10);
            Console.WriteLine(demoInt.Value);

            Demo<string> demoString = new();
            demoString.SetValue("Hello");
            Console.WriteLine(demoString.Value);

            Console.WriteLine();


            // ===== constraint test (ConDemo<T>) =====
            // one generic type (Basisklasse) can handle all derived types
            Basisklasse b = new() { Wert = 10 };
            Subklasse s = new() { Wert = 20 };
            Subsubklasse ss = new() { Wert = 30 };

            ConDemo<Basisklasse> con = new();

            con.ShowWert(b);
            con.ShowWert(s);
            con.ShowWert(ss);

            Console.WriteLine();


            // ===== extended generic class (T, R) =====
            // R must support new() → object is valid
            ConDemo<Basisklasse, object> conExtended = new();

            // generic method with additional type parameter M
            conExtended.Process<int>(b, 1);
            conExtended.Process<int>(s, 2);
            conExtended.Process<int>(ss, 3);

            Console.WriteLine();


            // ===== generic delegate =====
            // delegate references method with matching signature
            MyDelegate<string, int> del = FormatValue;

            string result = del(5);
            Console.WriteLine(result);

            Console.ReadKey();
        }

        // method used for delegate
        private static string FormatValue(int value)
        {
            return $"Value: {value}";
        }




        // TEST
        public static void RunAccountTest()
        {
            // Create a bank account
            Account account = new Account(200);

            // Add a reference to the PrintSimpleMessage method to the delegate
            account.RegisterHandler(PrintSimpleMessage);

            // Attempt to withdraw money twice in a row
            account.Take(100);
            account.Take(150);

            static void PrintSimpleMessage(string message) => Console.WriteLine(message);
        }

        public static void RunIndexer()
        {
            Belegschaft faGmbHCoKG = new Belegschaft();

            // add employees to internal list
            faGmbHCoKG.NeuerMitarbeiter("Hans Schulz", Abteilung.Buchhaltung, "12.04.1958");
            faGmbHCoKG.NeuerMitarbeiter("Anna Schmidt", Abteilung.Buchhaltung, "07.08.1974");
            faGmbHCoKG.NeuerMitarbeiter("Franz Meier", Abteilung.Vetrieb, "16.12.1958");
            faGmbHCoKG.NeuerMitarbeiter("Maria Müller", Abteilung.Vetrieb, "09.01.1998");
            faGmbHCoKG.NeuerMitarbeiter("Karl Ransauer", Abteilung.Entwicklung, "28.08.1964");
            faGmbHCoKG.NeuerMitarbeiter("Susanne Kiesling", Abteilung.Entwicklung, "20.11.2000");

            // ===== Zugriff per Nummer (1-based index) =====
            int nummer = 3;
            var mitarbeiter = faGmbHCoKG[nummer]; // internally maps to list[nummer - 1]

            Console.WriteLine($"[{nummer}] Name: {mitarbeiter.Name} " +
                              $"(geb.: {mitarbeiter.Geburtstag.ToShortDateString()}), " +
                              $"Abteilung: {mitarbeiter.Abteilung}");

            Console.WriteLine();

            // ===== Geburtstagsliste 12.04 =====
            foreach (var ma in faGmbHCoKG[4, 12]) // month=4, day=12
            {
                Console.WriteLine($"Name: {ma.Name} (geb.: {ma.Geburtstag.ToShortDateString()}), " +
                                  $"Abteilung: {ma.Abteilung}");
            }

            Console.WriteLine();

            // ===== Alle Mitarbeiter im August =====
            foreach (var ma in faGmbHCoKG[8, -1]) // day=-1 triggers month-only filter
            {
                Console.WriteLine($"Name: {ma.Name} (geb.: {ma.Geburtstag.ToShortDateString()}), " +
                                  $"Abteilung: {ma.Abteilung}");
            }

            Console.WriteLine();

            // ===== Versetzen per Indexer (object-based) =====
            Mitarbeiter schulz = faGmbHCoKG[1]; // get first employee (Hans Schulz)

            Console.WriteLine($"{schulz.Name} aus Abteilung {faGmbHCoKG[schulz]} " +
                              "wird versetzt in Abteilung Vetrieb");

            faGmbHCoKG[schulz] = Abteilung.Vetrieb; // set calls Versetzen()

            Console.WriteLine($"Name: {schulz.Name} (geb.: {schulz.Geburtstag.ToShortDateString()}), " +
                              $"neue Abteilung: {schulz.Abteilung}");
        }

        public static void RunDatumzeitrechner()
        {
            DatumZeitRechner heute = new DatumZeitRechner();

            // show current date in long format
            Console.WriteLine($"Heute ist {heute[DatumZeitRechner.Anzeige.Datum]}");

            // show current time including seconds
            Console.WriteLine($"Es ist jetzt {heute[DatumZeitRechner.Anzeige.Zeit]}");

            Console.WriteLine();

            // add or subtract date-based units (based on DateTime.Today)
            Console.WriteLine($"Heute vor einem Jahr: {heute[DatumZeitRechner.Einheit.Jahr, -1]}");
            Console.WriteLine($"Heute in 2 Monaten: {heute[DatumZeitRechner.Einheit.Monat, 2]}");
            Console.WriteLine($"Heute vor 6 Wochen: {heute[DatumZeitRechner.Einheit.Woche, -6]}");
            Console.WriteLine($"Heute in 35 Tagen: {heute[DatumZeitRechner.Einheit.Tag, 35]}");

            Console.WriteLine();

            // add or subtract time-based units (based on DateTime.Now)
            Console.WriteLine($"Jetzt vor 3,5 Stunden: {heute[DatumZeitRechner.Einheit.Stunde, -3.5]}");
            Console.WriteLine($"Jetzt in 90 Minuten: {heute[DatumZeitRechner.Einheit.Minute, 90]}");
        }


        public static void RunLambdaAndExpressionBodies()
        {
            // ================= LAMBDA ==================

            double zahl = 4.84;

            // initialize delegate using lambda expression
            MatheHandler mathe = x => Math.Round(x);

            Console.WriteLine($"Anonyme Methode: {zahl} gerundet = {mathe(zahl)}");

            // predicate example (returns boolean condition)
            DelegatePredicate istPositiv = d => d > 0;

            // projection example (transforms value)
            DelegateProjection inUInt = d => (uint)Math.Round(d);

            Console.WriteLine($"Predicate: {istPositiv(zahl)}");
            Console.WriteLine($"Projection: {inUInt(zahl)}");

            Console.WriteLine();

            // ================= EXPRESSION BODIES ==================

            ExpressionBodies eb = new ExpressionBodies(5);

            Console.WriteLine($"Quadrat: {eb.Quadrat}");

            eb.ZahlQuadrat = 3;
            Console.WriteLine($"ZahlQuadrat : {eb.ZahlQuadrat}");

            Console.WriteLine($"Summe mit 4: {eb.Summe(4)}");
        }

        public static void RunLinq()
        {
            List<MitarbeiterLinq> mitarbeiterliste = new List<MitarbeiterLinq>
            {
                new MitarbeiterLinq("Schmidt", "Hans", Abteilung.Buchhaltung, 2485, "12.04.1958"),
                new MitarbeiterLinq("Schulz", "Gabi", Abteilung.Vetrieb, 2743, "15.08.1979"),
                new MitarbeiterLinq("Ransauer", "Karl", Abteilung.Entwicklung, 4213, "28.08.1964"),
                new MitarbeiterLinq("Müller", "Maria", Abteilung.Vetrieb, 2196, "09.01.1998"),
                new MitarbeiterLinq("Schmidt", "Anna", Abteilung.Buchhaltung, 2876, "07.08.1974"),
                new MitarbeiterLinq("Meier", "Franz", Abteilung.Vetrieb, 3255, "16.12.1958"),
                new MitarbeiterLinq("Kiesling", "Susanne", Abteilung.Entwicklung, 3184, "20.11.2000")
            };

            // LINQ queries are executed only when enumerated (deferred execution)

            // -------- Projection: select only last names --------
            var namen = mitarbeiterliste.Select(ma => ma.Name);

            foreach (var name in namen)
                Console.WriteLine($"Mitarbeiter: {name}");

            Console.WriteLine();

            // -------- Grouping: group employees by department --------
            var gruppiert = mitarbeiterliste.GroupBy(ma => ma.Abteilung);

            foreach (var gruppe in gruppiert)
            {
                Console.WriteLine($"Abteilung: {gruppe.Key}");

                // iterate inside each group
                foreach (var ma in gruppe)
                    Console.WriteLine($"{ma.Name}, {ma.Vorname}");
            }

            Console.WriteLine();

            // -------- Filtering: only Buchhaltung employees --------
            var buchhaltung = mitarbeiterliste
                .Where(ma => ma.Abteilung == Abteilung.Buchhaltung);

            foreach (var ma in buchhaltung)
                Console.WriteLine($"{ma.Name}, {ma.Vorname}");

            Console.WriteLine();

            // -------- Sorting by department name (enum → string for alphabetical order) --------
            var sortAbteilung = mitarbeiterliste
                .OrderBy(ma => ma.Abteilung.ToString());

            foreach (var ma in sortAbteilung)
                Console.WriteLine($"{ma.Abteilung} - {ma.Name}");

            Console.WriteLine();

            // -------- Multi-level sorting: department → last name → first name --------
            var sortMehrfach = mitarbeiterliste
                .OrderBy(ma => ma.Abteilung.ToString())
                .ThenBy(ma => ma.Name)
                .ThenBy(ma => ma.Vorname);

            foreach (var ma in sortMehrfach)
                Console.WriteLine($"{ma.Abteilung} - {ma.Name}, {ma.Vorname}");

            Console.WriteLine();

            // -------- Mixed sorting: department desc → name desc → first name asc --------
            var sortGemischt = mitarbeiterliste
                .OrderByDescending(ma => ma.Abteilung.ToString())
                .ThenByDescending(ma => ma.Name)
                .ThenBy(ma => ma.Vorname);

            foreach (var ma in sortGemischt)
                Console.WriteLine($"{ma.Abteilung} - {ma.Name}, {ma.Vorname}");

            Console.WriteLine();

            // -------- Combination: August birthdays, sorted by day descending --------
            var august = mitarbeiterliste
                .Where(ma => ma.Geburtstag.Month == 8)
                .OrderByDescending(ma => ma.Geburtstag.Day);

            foreach (var ma in august)
                Console.WriteLine($"{ma.Name}, {ma.Vorname} - {ma.Geburtstag:dd.MM.yyyy}");
        }

        public static void RunLinqRandom()
        {
            Console.Title = "C# Erweiterte Techniken - Übung LINQ";

            Random random = new Random();
            int elementCount = 40;

            // generate primary collection with 40 random numbers (1–100 inclusive)
            List<int> primaryNumbers = new List<int>(elementCount);
            for (int i = 0; i < elementCount; i++)
                primaryNumbers.Add(random.Next(1, 101));

            Console.WriteLine("Es wurden folgende Zufallszahlen erzeugt:");
            Print(primaryNumbers);
            Console.WriteLine();

            // 1. ascending order
            Console.WriteLine("1. aufsteigende Reihenfolge:");
            Print(primaryNumbers.OrderBy(n => n));

            // 2. descending order
            Console.WriteLine("2. absteigende Reihenfolge:");
            Print(primaryNumbers.OrderByDescending(n => n));

            // 3. filter: numbers < 20
            Console.WriteLine("3. kleiner 20:");
            Print(primaryNumbers.Where(n => n < 20));

            // 4. filter: numbers > 80
            Console.WriteLine("4. größer 80:");
            Print(primaryNumbers.Where(n => n > 80));

            // 5. filter + sort: < 50 descending
            Console.WriteLine("5. kleiner 50, absteigend:");
            Print(primaryNumbers
                .Where(n => n < 50)
                .OrderByDescending(n => n));

            // 6. unique values sorted ascending
            // sorting first ensures ordered distinct output
            Console.WriteLine("6. eindeutige aufsteigend:");
            Print(primaryNumbers
                .OrderBy(n => n)
                .Distinct());

            // 7. aggregate: minimum and maximum
            Console.WriteLine($"7. kleinste = {primaryNumbers.Min()}, größte = {primaryNumbers.Max()}");

            // 8. aggregate: count of exact value 50
            Console.WriteLine($"8. 50 ist {primaryNumbers.Count(n => n == 50)}x enthalten");

            // 9. aggregate: total sum
            Console.WriteLine($"9. Summe aller Zahlen ist {primaryNumbers.Sum()}");
            Console.WriteLine();

            // generate second independent random collection
            List<int> secondaryNumbers = new List<int>(elementCount);
            for (int i = 0; i < elementCount; i++)
                secondaryNumbers.Add(random.Next(1, 101));

            // 10. intersection: elements contained in both lists (unique by definition)
            Console.WriteLine("10. beide Listen, eindeutig:");
            Print(primaryNumbers.Intersect(secondaryNumbers));

            // 11. union → sort ascending → take first 20 smallest unique values
            Console.WriteLine("11. ersten 20 aus beiden Listen, eindeutig, aufsteigend:");
            Print(primaryNumbers
                .Union(secondaryNumbers)
                .OrderBy(n => n)
                .Take(20));
        }

        // prints numbers aligned in width 4 (formatted output as in example)
        private static void Print(IEnumerable<int> numbers)
        {
            foreach (int number in numbers)
                Console.Write($"{number,4}");

            Console.WriteLine();
        }


        public static void RunFileSystemModule()
        {
            // -------------------------------------------------
            // 1. Safe operations (do NOT modify Demo.txt)
            // -------------------------------------------------

            // Path string parsing only (no real file required)
            PathOperations.Execute();

            //// Drive information (reads system drives only)
            DriveOperations.Execute();

            //// Directory listing (reads folders, does not modify)
            DirectoryOperations.Execute();

            //// DirectoryInfo metadata (reads folder info only)
            DirectoryInfoOperations.Execute();


            // -------------------------------------------------
            // 2. File structure modifications (affect Demo.txt location)
            // -------------------------------------------------

            // File class operations (copy, delete, move)
            FileOperations.Execute();

            // FileInfo class operations (object-based copy, move, delete)
            FileInfoOperations.Execute();


            // -------------------------------------------------
            // 3. Byte-level modification of Demo.txt
            // -------------------------------------------------

            // FileStream read/write and pointer positioning
            FileStreamOperations.Execute();


            // -------------------------------------------------
            // 4. Independent text file operations (dummy.txt)
            // -------------------------------------------------

            // Overwrite dummy.txt with initial data
            TextFileOperations.Write("Ich bin ein Test", 3.141, true);

            //// Append additional line
            TextFileOperations.Append("Ich wurde angefügt");

            //// Read and display dummy.txt
            TextFileOperations.Read();
        }

      
        public static void RunGenreModule()
        {
            // Combine Action and Comedy using bitwise OR
            Genre actionkomoedie = Genre.Action | Genre.Comedy;

            // Output combined genres (requires [Flags] attribute)
            Console.WriteLine(actionkomoedie);
        }

    }
}
