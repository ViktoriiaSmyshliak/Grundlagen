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
    }
}
