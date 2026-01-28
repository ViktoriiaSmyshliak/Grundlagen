using System;

public static class ValueAndReferenceTypes
{
    // value types example
    public static void ValueTypes()
    {
        // value types store the value directly
        int a = 5;

        // assignment copies the value
        int b = a;

        Console.WriteLine(a); // 5
        Console.WriteLine(b); // 5

        // changing b does not affect a
        b = 99;

        Console.WriteLine(a); // 5
        Console.WriteLine(b); // 99

        // key points for theory:
        // - a and b are value types
        // - assignment copies the value
        // - variables are independent
    }

    // reference types example
    public static void ReferenceTypes()
    {
        // reference types store a reference to an object
        int[] x = { 5 };

        // assignment copies the reference, not the value
        int[] y = x;

        Console.WriteLine(x[0]); // 5
        Console.WriteLine(y[0]); // 5

        // changing the object via y affects x
        y[0] = 99;

        Console.WriteLine(x[0]); // 99
        Console.WriteLine(y[0]); // 99

        // key points for theory:
        // - x and y are reference types
        // - assignment copies the reference
        // - both variables point to the same object
    }

    // comparison of values and references
    public static void Compare()
    {
        int a = 5;
        int b = a;

        int[] x = { 5 };
        int[] y = x;
        int[] z = { 99 };

        // value comparison
        Console.WriteLine(a == b); // True

        // reference value comparison
        Console.WriteLine(x[0] == z[0]); // False

        // reference comparison
        Console.WriteLine(object.ReferenceEquals(x, y)); // True
        Console.WriteLine(object.ReferenceEquals(x, z)); // False

        // key points for theory:
        // - value types: value comparison
        // - reference types: value comparison and reference comparison differ
        // - same values do not mean same reference
    }
}
