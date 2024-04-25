public class Container<T>
{
    public T Value { get; set; }

    public Container(T value = default(T))
    {
        Value = value;
    }
    
    public void ResetValue()
    {
        Value = default(T);
    }
}