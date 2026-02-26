using System;
using System.IO;

public static class PathOperations
{
    public static void Execute()
    {
        string dummyFile = "X:/Ordner/Unterordner/Datei.ext";

        // Extract path components
        Console.WriteLine(Path.GetDirectoryName(dummyFile));
        Console.WriteLine(Path.GetExtension(dummyFile));
        Console.WriteLine(Path.GetFileName(dummyFile));
        Console.WriteLine(Path.GetFileNameWithoutExtension(dummyFile));

        // Create temp file
        string tempFile = Path.GetTempFileName();
        FileInfo fi = new FileInfo(tempFile);

        Console.WriteLine($"{fi.FullName} - {fi.Length} bytes");

        fi.Delete();
    }
}