public class Kreis
{
    public double Durchmesser { get; set; }

    public double Radius
    {
        get { return Durchmesser / 2; }
    }

    public double Flaeche
    {
        get { return Math.PI * Radius * Radius; }
    }

    public double Umfang
    {
        get { return Math.PI * Durchmesser; }
    }
}
