using System;

public static class LiteralsAndOperators
{
    public static void Run()
    {
        // literals with digit separators

        int mio = 1_000_000;                  // one million
        double pi = 3.141_592_653;             // pi with 9 decimal places
        short hex = 0x0F_00;                   // hexadecimal F00
        byte b255 = 0b1111_1111;               // binary 255 with nibble grouping


        int i = -3;

        // unary minus changes the sign
        Console.WriteLine($"{-i}");            // "3"

        // addition
        Console.WriteLine($"{i + 103}");       // "100"

        // subtraction
        Console.WriteLine($"{i - 7}");          // "-10"

        // multiplication
        Console.WriteLine($"{i * -5}");         // "15"

        // division (force floating-point division)
        Console.WriteLine($"{i / 2.0}");        // "-1,5"

        // remainder (modulo)
        Console.WriteLine($"{i % 2}");          // "-1"

        // pre-increment: increment first, then use the value
        Console.WriteLine($"{++i}");            // "-2"

        // reset value for correct demonstration
        i = -3;

        // post-increment: use the value first, then increment
        Console.WriteLine($"{i++}");            // "-3" → comment requires "-2" after operation
                                               // value of i is now -2

        // pre-decrement: decrement first, then use the value
        Console.WriteLine($"{--i}");            // "-3" → from -2 to -3

        // reset value again
        i = -3;

        // post-decrement: use the value first, then decrement
        Console.WriteLine($"{i--}");            // "-3" → value becomes -4 afterwards

        // unchanged literal output
        Console.WriteLine($"{-3}");             // "-3"

        // operator precedence: * and / before + and -
        Console.WriteLine($"{1 + 2 * 3 - 4 / 5}"); // "1"
    }

    public static void LogicalOperatorsDemo()
    {
        bool wahr = true;
    bool falsch = false;

    // disjunction (OR) – all variants that result in True
    Console.WriteLine($"{wahr || wahr}");     // True
    Console.WriteLine($"{wahr || falsch}");   // True
    Console.WriteLine($"{falsch || wahr}");   // True

    // antivalence (XOR) – results in True
    Console.WriteLine($"{wahr ^ falsch}");    // True
    Console.WriteLine($"{falsch ^ wahr}");    // True


    // force evaluation of both sides using bitwise operators
    int i = 100;

    Console.WriteLine($"{falsch & i++ == 101}");
    Console.WriteLine(i); // 101

    Console.WriteLine($"{wahr | i++ == 101}");
    Console.WriteLine(i); // 102


    // assignment operators – increment i by 1 in all possible ways

    i = 0;

    i = i + 1;   // addition
    i += 1;      // compound assignment
    i++;         // post-increment
    ++i;         // pre-increment
    }
}
