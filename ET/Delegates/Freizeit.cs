public static class Freizeit
{
    // Executes callback method and returns result
    public static int Beschaeftigen(
        FreizeitCallback callback,
        string text,
        int number)
    {
        return callback(text, number);
    }
}
