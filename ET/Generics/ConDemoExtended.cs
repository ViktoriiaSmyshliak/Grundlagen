
// extended generic class:
// T → input type (must be Basisklasse)
// R → return type (must have parameterless constructor)
public class ConDemo<T, R>
    where T : Basisklasse
    where R : new()
{
    // generic method with its own type parameter M
    // M is restricted to value types (struct)
    public R Process<M>(T obj, M optional = default) where M : struct
    {
        // using constraint: we can access .Wert safely
        Console.WriteLine(obj.Wert);

        // returning new instance of R (requires new() constraint)
        return new R();
    }
}
