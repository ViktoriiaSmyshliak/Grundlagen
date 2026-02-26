public class ExpressionBodies
{
    private int zahl;

    // expression-bodied constructor
    public ExpressionBodies(int zahl) => this.zahl = zahl;

    // read-only expression-bodied property (returns square)
    public int Quadrat => zahl * zahl;

    // property with expression-bodied accessors
    // getter returns field value
    // setter stores squared assigned value
    public int ZahlQuadrat
    {
        get => zahl;
        set => zahl = value * value;
    }

    // expression-bodied method (returns sum of field and parameter)
    public int Summe(int wert) => zahl + wert;
}