using static System.Console;

// Codegrade doesn't like namespaces
internal class Program
{
    public static void Main(string[] args)
    {
        WriteLine(Pow2(5));
    }

    public static int Pow2(int value)
    {
        return value * value;
    }
}