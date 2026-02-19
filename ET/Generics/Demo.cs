
// generic class: type T is used for property and method parameter
public class Demo<T>
{
    // stores value of generic type T
    public T Value { get; private set; }

    // method assigns parameter to property (requirement from task)
    public void SetValue(T value)
    {
        Value = value;
    }
}
