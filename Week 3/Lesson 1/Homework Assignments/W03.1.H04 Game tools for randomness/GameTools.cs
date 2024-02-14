using System;
using System.Collections.Generic;

public static class GameTools
{
    public static bool ReturnCount { get; set; } = true;

    public static List<string> CoinFlip(int value)
    {
        var results = new List<string>();
        var random = new Random();
        for (var i = 0; i < value; i++)
        {
            var result = random.Next(0, 2);
            if (result == 0)
            {
                results.Add("Heads");
            }
            else
            {
                results.Add("Tails");
            }
        }

        // Find how many heads and tails were flipped
        // Else, just return the results
        if (ReturnCount)
        {
            var heads = results.FindAll(x => x == "Heads").Count;
            var tails = results.FindAll(x => x == "Tails").Count;
            Console.WriteLine($"Heads: {heads}\nTails: {tails}");
        }
        else
        {
            foreach (var result in results)
            {
                Console.WriteLine(result);
            }
        }

        return results;
    }

    public static string DiceRoll(int sides, int rolls)
    {
        // Store the results of each roll
        var results = new List<int>();

        // Ensure the number of sides is valid
        if (sides < 3)
        {
            return "Invalid number of die sides";
        }

        // Roll the die the specified number of times and store the results
        var random = new Random();
        for (int i = 0; i < rolls; i++)
        {
            var result = random.Next(1, sides + 1);
            results.Add(result);
        }

        // Find how many times each number was rolled if ReturnCount is true
        // Else, just return the results
        if (ReturnCount)
        {
            for (int i = 1; i <= sides; i++)
            {
                var count = results.FindAll(x => x == i).Count;
                Console.WriteLine($"{i} was rolled {count} times");
            }
        }
        else
        {
            for (int i = 0; i < results.Count; i++)
            {
                Console.WriteLine($"Roll {i+1}: {results[i]}");
            }
        }

        return "Done";
    }
}