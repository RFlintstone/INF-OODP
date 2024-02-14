using System;

internal class Program
{
    public static void Main(string[] args)
    {
        // CoinFlip with ReturnCount set to true (ReturnCount is true by default)
        GameTools.CoinFlip(5);
        Console.WriteLine();
        
        // CoinFlip with ReturnCount set to false
        GameTools.ReturnCount = false;
        GameTools.CoinFlip(5);
        
        // DiceRoll with 6 sides and ReturnCount set to true
        GameTools.ReturnCount = true;
        GameTools.DiceRoll(6, 5);
        
        // DiceRoll with 6 sides and ReturnCount set to false
        GameTools.ReturnCount = false;
        GameTools.DiceRoll(20, 10);
    }
}