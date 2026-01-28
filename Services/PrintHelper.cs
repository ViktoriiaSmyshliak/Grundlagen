using Grundlagen.OOP.Interfaces;

namespace Grundlagen.Services
{
   public static class PrintHelper
{
    public static void PrintAll(IEnumerable<IPrintable> items)
    {
        foreach (var item in items)
            {
                item.Print();
                Console.WriteLine("-------------");
            }
    }
}

}
