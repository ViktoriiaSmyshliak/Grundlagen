using System;
using System.IO;

public static class DirectoryOperations
{
    public static void Execute()
    {
        // Get execution directory
        string exePath = Directory.GetCurrentDirectory();

        // Print all files in execution directory
        foreach (string file in Directory.GetFiles(exePath))
            Console.WriteLine(file);

        // Print all txt files inside Ordner and subdirectories
        foreach (string file in Directory.EnumerateFiles(
                     FilePaths.BasePath,
                     "*.txt",
                     SearchOption.AllDirectories))
        {
            Console.WriteLine(file);
        }
    }
}