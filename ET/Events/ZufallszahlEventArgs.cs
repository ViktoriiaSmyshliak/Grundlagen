// Event data container (extendable without breaking handlers)
public class ZufallszahlEventArgs : EventArgs
{
    public int? Zahl { get; }
    public double? Gleitkommazahl { get; }

    public ZufallszahlEventArgs(int zahl)
    {
        Zahl = zahl;
    }

    public ZufallszahlEventArgs(double gleitkommazahl)
    {
        Gleitkommazahl = gleitkommazahl;
    }
}
