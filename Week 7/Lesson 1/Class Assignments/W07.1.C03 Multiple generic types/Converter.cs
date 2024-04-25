public static class Converter
{
    public static T2 ConvertVariables<T1, T2>(T1 t1)
    {
        if (t1 is null) throw new ArgumentNullException(nameof(t1)); // Check for null
        return (T2)Convert.ChangeType(t1, typeof(T2)); // Convert the value to the desired type
    }
}