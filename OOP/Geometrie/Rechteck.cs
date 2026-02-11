public class Rechteck
{
    public double SeiteA { get; set; }
    public double SeiteB { get; set; }

    public double Flaeche
    {
        get { return SeiteA * SeiteB; }
    }

    public double Umfang
    {
        get { return 2 * (SeiteA + SeiteB); }
    }

    public double Diagonale
    {
        get { return Math.Sqrt(SeiteA * SeiteA + SeiteB * SeiteB); }
    }
}
