using System;

public static class ArrayFields
{
    // creates and works with one-dimensional arrays
    public static void OneDimensionalArrays()
    {
        // int array with exactly 3 elements
        int[] daten = new int[3];

        // double array with 5 elements, all multiples of 0.2
        double[] zahlen = { 0.2, 0.4, 0.6, 0.8, 1.0 };

        // output first element of daten
        Console.WriteLine(daten[0]);

        // output last element of zahlen
        Console.WriteLine(zahlen[zahlen.Length - 1]);
    }

    // creates and works with multidimensional arrays
    public static void MultiDimensionalArrays()
    {
        // three-dimensional short array (5x5x5)
        // all elements are initialized with 0 by default
        short[,,] würfel = new short[5, 5, 5];

        // two-dimensional table with predefined values
        int[,] tabelle =
        {
            { 1,   2,   3,   4,   5 },
            { 10,  20,  30,  40,  50 },
            { 100, 200, 300, 400, 500 }
        };

        // output the element with value 40
        Console.WriteLine(tabelle[1, 3]);
    }

    // demonstrates array properties
    public static void ArrayProperties()
    {
        int[,] tabelle =
        {
            { 1,   2,   3,   4,   5 },
            { 10,  20,  30,  40,  50 },
            { 100, 200, 300, 400, 500 }
        };

        // total number of elements in the array
        Console.WriteLine($"Gesamtanzahl aller Elemente: {tabelle.Length}");

        // number of elements in the first dimension
        Console.WriteLine($"Anzahl der Elemente in der ersten Dimension: {tabelle.GetLength(0)}");

        // number of dimensions of the array
        Console.WriteLine($"Anzahl der Dimensionen: {tabelle.Rank}");
    }
}
