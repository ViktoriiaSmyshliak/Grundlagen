public struct Name
{
    public string Vorname;
    public string Nachname;
}

public class Person
{
    public Name Name { get; set; }

    public Person(string vorname, string nachname)
    {
        Name = new Name
        {
            Vorname = vorname,
            Nachname = nachname
        };
    }
}
