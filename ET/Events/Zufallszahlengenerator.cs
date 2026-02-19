public class Zufallszahlengenerator
{
    private static Random zufallsgenerator = new Random();

    public string Name { get; }

    public Zufallszahlengenerator(string name) => Name = name;


    public delegate void Groesser50EventHandler(object sender, ZufallszahlEventArgs e);
    public delegate void GeradeEventHandler(object sender, ZufallszahlEventArgs e);


    public event Groesser50EventHandler Groesser50;
    public event GeradeEventHandler Gerade;


    protected void OnGroesser50(ZufallszahlEventArgs e)
    {
        Groesser50?.Invoke(this, e);
    }

    protected void OnGerade(ZufallszahlEventArgs e)
    {
        Gerade?.Invoke(this, e);
    }


    public virtual int Erzeugen()
    {
        int zufallszahl = zufallsgenerator.Next(1, 101);

        if (zufallszahl > 50)
            OnGroesser50(new ZufallszahlEventArgs(zufallszahl));

        if (zufallszahl % 2 == 0)
            OnGerade(new ZufallszahlEventArgs(zufallszahl));

        return zufallszahl;
    }
}
