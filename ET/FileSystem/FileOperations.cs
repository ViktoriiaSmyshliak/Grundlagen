using System;
using System.IO;

public static class FileOperations
{
    public static void Execute()
    {
        // Copy Demo.txt into Unterordner (overwrite if exists)
        File.Copy(FilePaths.DemoFile, FilePaths.SubDemoFile, true);

        // Copy and rename to Kopie.txt (overwrite if exists)
        File.Copy(FilePaths.DemoFile, FilePaths.CopyFile, true);

        // Delete Demo.txt inside Unterordner if present
        if (File.Exists(FilePaths.SubDemoFile))
            File.Delete(FilePaths.SubDemoFile);

        // Move Demo.txt if Kopie.txt does not exist
        if (!File.Exists(FilePaths.CopyFile))
            File.Move(FilePaths.DemoFile, FilePaths.CopyFile);
        else
            Console.WriteLine("Kopie.txt already exists.");

        // Output creation time of Demo.txt
        if (File.Exists(FilePaths.DemoFile))
            Console.WriteLine(File.GetCreationTime(FilePaths.DemoFile));
    }
}