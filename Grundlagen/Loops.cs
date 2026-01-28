using System;

public static class Loops
{
    // shows how loop iterations can be controlled
    public static void LoopControl()
    {
        // break    -> exits the loop immediately
        // continue -> skips the current iteration and continues with the next one
    }

    // FOR loop examples
    public static void ForLoops()
    {
        // output numbers from 1 to 10
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
        }

        // output numbers from 2 to 10 that are divisible by 2
        for (int i = 2; i <= 10; i += 2)
        {
            Console.WriteLine(i);
        }

        // fill array with values 2, 4, 6, 8, 10
        int[] zweier = new int[5];

        for (int i = 0; i < zweier.Length; i++)
        {
            zweier[i] = (i + 1) * 2;
        }

        // advanced: for-loop without body
        for (int i = 0; i < zweier.Length; zweier[i] = (i + 1) * 2, i++) ;
    }

    // FOREACH loop example
    public static void ForeachLoop()
    {
        int[] zweier = { 2, 4, 6, 8, 10 };

        // iterate over all elements of the array
        foreach (int value in zweier)
        {
            Console.WriteLine(value);
        }
    }

    // WHILE loop example
    public static void WhileLoop()
    {
        int n = 1;

        // output numbers from 1 to 10
        while (n <= 10)
        {
            Console.WriteLine(n);
            n++;
        }

        // theory note:
        // while-loop executes at least 0 times
    }

    // DO-WHILE loop example
    public static void DoWhileLoop()
    {
        int n = 9;

        // output numbers from 9 to 1
        do
        {
            // skip number 5
            if (n == 5)
            {
                n--;
                continue;
            }

            Console.WriteLine(n);
            n--;
        }
        while (n >= 1);

        // theory note:
        // do-while loop executes at least 1 time
    }
}
