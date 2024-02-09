class Program
{
    static void Main()
    {
        var pack = new List<string>()
        {
            "laptop",
            "lunch",
            "notebook",
            "pen",
        };

        // Solved it with .ToArray():
        Console.WriteLine($"The first item in the pack is a " + pack.ToArray()[0]);
        Console.WriteLine($"The last item in the pack is a " + pack.ToArray()[pack.Count-1]);
        
        // Although this is also possible:
        // Console.WriteLine($"The first item in the pack is a " + pack[0]);
        // Console.WriteLine($"The last item in the pack is a " + pack[pack.Count-1]);
    }
}