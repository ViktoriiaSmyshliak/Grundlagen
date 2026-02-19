// ================= CONDEMO<T, R> ==================
// Demonstrates:
// - generic class with constraints
// - generic method with its own type parameter
// - usage of new() constraint

// generic class with constraint:
// T must be Basisklasse or derived → allows access to .Wert
public class ConDemo<T> where T : Basisklasse
{
    // method uses property from base class (core idea of constraint)
    public void ShowWert(T obj)
    {
        Console.WriteLine(obj.Wert);
    }
}
