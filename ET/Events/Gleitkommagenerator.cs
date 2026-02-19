public class Gleitkommagenerator : Zufallszahlengenerator
{
    private static Random zufallsgenerator = new Random();

    public Gleitkommagenerator(string name) : base(name) { }


    // new instead of override because return type differs (int vs double)
    public new double Erzeugen()
    {
        double zahl = zufallsgenerator.NextDouble(); // [0,1)

        if (zahl > 0.5)
            OnGroesser50(new ZufallszahlEventArgs(zahl));

        double rounded = Math.Round(zahl, 2);

        if (rounded % 0.2 == 0)
            OnGerade(new ZufallszahlEventArgs(zahl));

        return zahl;
    }
}
