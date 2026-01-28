namespace Grundlagen.Grundlagen
{
    public static class Variablen
    {
     public static void Run1()
        {
            // length 1 identifiers
            int z;
            int _;

            // length 2 identifiers
            int z1;
            int z_;
            int _z;
            int _1;

            // length 3 identifiers
            int z1_;
            int z_1;
            int _z1;
            int _1z;

            // identifier using a reserved keyword (escaped with @)
            int @int;

            // same identifier name in different scopes
            int abc = 10;
            {
                //int abc = 20;
                Console.WriteLine(abc); // inner scope variable
            }

            // assign the default value of int (0)
            z = default;

            // output a variable to the console
            Console.WriteLine(abc);
        }
     public static void Run2()
    {
        // C# syntax (most memory-efficient types)

        byte csharpByte = 123;          // 0..255
        short csharpShort = 12345;      // fits into Int16
        int csharpInt = -123456;        // requires Int32
        float csharpFloat = 123.456f;   // single precision
        char csharpChar = 'A';          // Unicode character
        string csharpString = "65";     // string literal
        bool csharpBool = true;         // boolean value


        // .NET syntax (System types)

        System.Byte dotNetByte = 123;
        System.Int16 dotNetShort = 12345;
        System.Int32 dotNetInt = -123456;
        System.Single dotNetFloat = 123.456f;
        System.Char dotNetChar = 'A';
        System.String dotNetString = "65";
        System.Boolean dotNetBool = true;


        // Assign the same literals to object variables
        //boxing

        object obj1 = 123;
        object obj2 = 12345;
        object obj3 = -123456;
        object obj4 = 123.456f;
        object obj5 = 'A';
        object obj6 = "65";
        object obj7 = true;
    }
     
     public static void Run3()
        {
            // float literal requires the 'f' suffix
            float fl = 1.234f;

            // integer division: both operands are int
            Console.WriteLine(1 / 3); // result: 0

            // force floating-point division
            double result = 1.0 / 3.0;

            // formatted output with different precision
            Console.WriteLine(result.ToString("F8"));
            Console.WriteLine(result.ToString("F16"));
            Console.WriteLine(result.ToString("F28"));
        }
    public static void Run4()
    {
        // initial char variable
        char ch = 'A';

        // implicit conversion: char -> double
        // uses the Unicode value of the character ('A' = 65)
        double d = ch;

        // explicit numeric conversions from double
        // possible data loss due to truncation
        byte by = (byte)d;
        short sh = (short)d;
        int i = (int)d;
        char ch2 = (char)d;

        // conversion from double to string
        // string representation of the number
        string s = d.ToString();

        // conversion from double to bool
        // zero = false, non-zero = true
        bool b = Convert.ToBoolean(d);

        // string to byte conversion
        // requires valid numeric string, otherwise throws exception
        by = byte.Parse(s);
    }
    
        public static void Run5()
    {
        // explicit double declaration
        double pi = 3.14;

        // implicit typing: type is inferred as int
        var v = 100;

        // assign double to int variable requires explicit cast
        v = (int)pi;

        // implicit typing with different numeric types

        var s = (short)100;   // inferred as short
        var i = 100;          // inferred as int
        var l = 100L;         // inferred as long
        var f = 100f;         // inferred as float
        var d = 100.0;        // inferred as double
    }
     }
}
