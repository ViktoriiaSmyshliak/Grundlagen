using System;
using System.Collections; // required for ArrayList and Hashtable

public static class CollectionClasses
{
    // ARRAYLIST tasks
    public static void ArrayListTasks()
    {
        // create ArrayList
        ArrayList liste = new ArrayList();

        // ArrayList can store elements of ANY type (no type safety)
        liste.Add("Hallo Welt!");
        liste.Add(100);
        liste.Add(3.14);

        // read 3rd element and cast to double
        double pi = (double)liste[2];
        Console.WriteLine(pi);

        // initial capacity of an ArrayList is 0
        Console.WriteLine($"Capacity: {liste.Capacity}");

        // when capacity is exceeded, it is automatically increased
        liste.Add(true);
        liste.Add('X');

        // output count and capacity
        Console.WriteLine($"Count: {liste.Count}");
        Console.WriteLine($"Capacity: {liste.Capacity}");

        // recreate ArrayList with new elements
        liste = new ArrayList { 34, 105, 6 };

        // create int array and add it to the ArrayList
        int[] zahlenArray = { 17, 8, 12 };
        liste.Add(zahlenArray);

        // output all elements
        foreach (object item in liste)
        {
            Console.WriteLine(item);
        }

        // insert elements at specific positions
        liste.Insert(3, "A");
        liste.InsertRange(4, new object[] { "B", "C", "D" });

        // remove element by value
        liste.Remove("B");

        // remove 4th element (index 3)
        liste.RemoveAt(3);

        // find index of "C"
        Console.WriteLine(liste.IndexOf("C"));

        // remove "C" and "D"
        liste.Remove("C");
        liste.Remove("D");

        // check if element 105 exists
        Console.WriteLine(liste.Contains(105));

        // sort elements (only works if elements are comparable)
        liste.Sort();
        foreach (object item in liste)
        {
            Console.WriteLine(item);
        }

        // reverse order
        liste.Reverse();
        foreach (object item in liste)
        {
            Console.WriteLine(item);
        }

        // set capacity to 20
        liste.Capacity = 20;

        // shrink capacity to current count
        liste.Capacity = liste.Count;

        // remove all elements
        liste.Clear();

        // create new ArrayList with initial capacity 10
        liste = new ArrayList(10);
    }

    // HASHTABLE tasks
    public static void HashtableTasks()
    {
        // Hashtable stores key–value pairs
        // keys must be UNIQUE, values can be duplicated

        Hashtable farben = new Hashtable();

        // add console colors with color names as keys
        farben.Add("rot", ConsoleColor.Red);
        farben.Add("gruen", ConsoleColor.Green);
        farben.Add("blau", ConsoleColor.Blue);

        // output all keys
        foreach (object key in farben.Keys)
        {
            Console.WriteLine(key);
        }

        // output all color names in their respective color
        foreach (DictionaryEntry entry in farben)
        {
            Console.ForegroundColor = (ConsoleColor)entry.Value;
            Console.WriteLine(entry.Key);
        }

        // set console foreground color to "gruen"
        Console.ForegroundColor = (ConsoleColor)farben["gruen"];
        Console.WriteLine("Text in green");

        // reset color
        Console.ResetColor();

        // create Hashtable with animals
        Hashtable tiere = new Hashtable
        {
            { "Vogel", "Amsel" },
            { "Hund", "Dackel" },
            { "Insekt", "Muecke" }
        };

        // output count
        Console.WriteLine(tiere.Count);

        // check for key
        Console.WriteLine(tiere.ContainsKey("Hund"));

        // check for value
        Console.WriteLine(tiere.ContainsValue("Dogge"));

        // remove "Muecke"
        tiere.Remove("Insekt");

        // remove all elements
        tiere.Clear();
    }
}
