using System;

internal class Program
{
    public static void Main(string[] args)
    {
        var deck = new Deck(true);
        deck.Shuffle();
        var card = deck.Draw();
        Console.WriteLine(card.GetName());
    }
}