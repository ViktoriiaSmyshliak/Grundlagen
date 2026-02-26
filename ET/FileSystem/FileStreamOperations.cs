using System;
using System.IO;

public static class FileStreamOperations
{
    public static void Execute()
    {
        using FileStream fs = new FileStream(
            FilePaths.DemoFile,
            FileMode.Open,
            FileAccess.ReadWrite);

        byte[] data = new byte[40];

        // Read 20 bytes into array starting at index 10
        int readBytes = fs.Read(data, 10, 20);
        Console.WriteLine(readBytes);

        foreach (byte b in data)
            Console.Write((char)b);

        // Modify positions 4-6
        data[4] = (byte)'X';
        data[5] = (byte)'Y';
        data[6] = (byte)'Z';

        fs.Write(data, 4, 3);

        // Relative 4 bytes from beginning
        fs.Seek(4, SeekOrigin.Begin);
        fs.Write(data, 4, 3);

        // Relative 8 bytes before end
        fs.Seek(-8, SeekOrigin.End);
        fs.Write(data, 4, 3);

        // Relative 10 bytes from current position
        fs.Seek(10, SeekOrigin.Current);
        fs.Write(data, 4, 3);

        // Absolute position at byte index 1
        fs.Position = 1;
        fs.Write(data, 4, 3);

        // Flush buffered data without closing stream
        fs.Flush();
    }
}