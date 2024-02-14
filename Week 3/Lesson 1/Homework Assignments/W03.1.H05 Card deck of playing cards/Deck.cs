using System;
using System.Collections.Generic;
using System.Linq;

public class Deck
{
    public readonly List<Card> Cards = new List<Card>();
    public readonly bool AreJokersIncluded;

    public Deck(bool areJokersIncluded)
    {
        // Set if we want to include jokers in the deck
        AreJokersIncluded = areJokersIncluded;

        // Create the suits and ranks of the cards
        string[] suits = { "Diamonds", "Clubs", "Hearts", "Spades" };
        string[] ranks = { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };

        // Create the deck of cards by combining the suits and ranks from the arrays above
        foreach (string suit in suits)
        {
            foreach (string rank in ranks)
            {
                Cards.Add(new Card(suit, rank));
            }
        }

        // If we want to include jokers, add them to the deck
        if (AreJokersIncluded)
        {
            Cards.Add(new Card("Joker", "Red"));
            Cards.Add(new Card("Joker", "Black"));
        }
    }
    
    public void Shuffle()
    {
        var random = new Random();
        var shuffledCards = Cards.OrderBy(_ => random.Next()).ToList();
        Cards.Clear();
        Cards.AddRange(shuffledCards);
    }

    public Card Draw()
    {
        // Draw a card from the deck, if there are no cards left, return null
        if (Cards.Count == 0) return null;
        
        var drawnCard = Cards.Last();
        Cards.Remove(drawnCard);
        
        return drawnCard;
    }
}