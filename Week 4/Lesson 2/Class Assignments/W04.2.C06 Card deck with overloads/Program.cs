using System;
using static System.Console;

internal class Program
{
    public static void Main(string[] args)
    {
        var deck = new Deck();
        deck.Shuffle();
        var drawnCard = deck.Draw();
        WriteLine($"You drew the {drawnCard.Rank} of {drawnCard.Suit}");

        WriteLine();

        var drawnCards = deck.Draw(100);
        foreach (var card in drawnCards)
        {
            if (card != null)
            {
                WriteLine($"You drew the {card.Rank} of {card.Suit}");
            }
            else
            {
                WriteLine("There are no cards left in the deck");
            }
        }
    }
}