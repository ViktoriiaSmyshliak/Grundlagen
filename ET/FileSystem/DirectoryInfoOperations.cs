using System;
using System.IO;

public static class DirectoryInfoOperations
{
    public static void Execute()
    {
        DirectoryInfo di =
            new DirectoryInfo(FilePaths.SubFolder);

        // Print parent directory name
        Console.WriteLine(di.Parent?.Name);

        // Print root directory
        Console.WriteLine(di.Root.FullName);
    }
}