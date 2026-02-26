using System;
using System.IO;

public static class FileInfoOperations
{
    public static void Execute()
    {
        FileInfo fi = new FileInfo(FilePaths.DemoFile);

        // Copy file using FileInfo and overwrite
        fi.CopyTo(FilePaths.FiCopyFile, true);

        // Delete copied file
        FileInfo fiCopy = new FileInfo(FilePaths.FiCopyFile);
        if (fiCopy.Exists)
            fiCopy.Delete();

        // Move original file if target not exists
        if (!File.Exists(FilePaths.CopyFile))
            fi.MoveTo(FilePaths.CopyFile);
        else
            Console.WriteLine("Target file already exists.");

        Console.WriteLine(fi.CreationTime);
    }
}