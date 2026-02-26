using System;
using System.IO;

public static class DriveOperations
{
    public static void Execute()
    {
        foreach (DriveInfo drive in DriveInfo.GetDrives())
        {
            Console.WriteLine(drive.Name);
            Console.WriteLine(drive.DriveType);

            if (drive.IsReady)
            {
                Console.WriteLine(drive.VolumeLabel);
                Console.WriteLine(drive.DriveFormat);
                Console.WriteLine(drive.TotalSize);
                Console.WriteLine(drive.TotalFreeSpace);
                Console.WriteLine(drive.AvailableFreeSpace);
            }
            else
            {
                Console.WriteLine("Drive not ready.");
            }
        }
    }
}