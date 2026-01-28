using Grundlagen.OOP.Interfaces;

namespace Grundlagen.OOP.Models
{
    // Basisklasse für alle Gebaeude
    public abstract class Gebaeude : IPrintable, IPutzen
{
    public int GesamtnutzflaecheQm { get; protected set; }

    protected Gebaeude(int gesamtnutzflaecheQm)
    {
        GesamtnutzflaecheQm = gesamtnutzflaecheQm;
    }

    // Eine virtuelle Methode muss nicht in jeder abgeleiteten Klasse überschrieben werden.
    public virtual void Print()
    {
        Console.WriteLine($"Typ: {GetType().Name}");
        Console.WriteLine($"Gesamtnutzflaeche: {GesamtnutzflaecheQm} qm");
    }

       public void IsPutzen()
        {
                Console.WriteLine($"Typ: {GetType().Name} wurde geputzt.");
        }
    }

}
