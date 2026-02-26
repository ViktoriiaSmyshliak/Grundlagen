using System.IO;

public static class FilePaths
{
    private const string DemoFileName = "Demo.txt";
    private const string CopyFileName = "Kopie.txt";
    private const string FiCopyFileName = "fiKopie.txt";

    // Absolute path to "Ordner"
    public static string BasePath =>
        Path.GetFullPath(Path.Combine("..", "..", "..", "Ordner"));

    public static string DemoFile =>
        Path.Combine(BasePath, DemoFileName);

    public static string SubFolder =>
        Path.Combine(BasePath, "Unterordner");

    public static string SubDemoFile =>
        Path.Combine(SubFolder, DemoFileName);

    public static string CopyFile =>
        Path.Combine(SubFolder, CopyFileName);

    public static string FiCopyFile =>
        Path.Combine(SubFolder, FiCopyFileName);
}