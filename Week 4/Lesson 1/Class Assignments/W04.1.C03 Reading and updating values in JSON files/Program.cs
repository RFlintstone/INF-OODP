class Program
{
    static void Main(string[] args)
    {
        // Calculator
        double result = Calculator.Add(5, 10);
        Console.WriteLine(result);
        result = Calculator.Subtract(5, 10);
        Console.WriteLine(result);
        result = Calculator.Multiply(5, 10);
        Console.WriteLine(result);
        result = Calculator.Divide(5, 10);
        Console.WriteLine(result);
        result = Calculator.Modulo(5, 10);
        Console.WriteLine(result);
        Calculator.StoreInMemory(5);
        result = Calculator.RestoreFromMemory();
        Console.WriteLine(result);
    }
}