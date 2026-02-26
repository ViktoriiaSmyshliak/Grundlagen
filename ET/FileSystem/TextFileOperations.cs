using System;
using System.IO;

public static class TextFileOperations
{
    public static void Write(params object[] data)
    {
        using StreamWriter sw = new StreamWriter("dummy.txt");

        foreach (var item in data)
            sw.WriteLine($"{DateTime.Now}: {item}");
    }

    public static void Append(params object[] data)
    {
        using StreamWriter sw = new StreamWriter("dummy.txt", true);

        foreach (var item in data)
            sw.WriteLine($"{DateTime.Now}: {item}");
    }

    public static void Read()
    {
        using StreamReader sr = new StreamReader("dummy.txt");
        Console.WriteLine(sr.ReadToEnd());
    }
}