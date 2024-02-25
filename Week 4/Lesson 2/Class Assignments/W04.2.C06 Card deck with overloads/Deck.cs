using System;
using System.Collections.Generic;
using System.Linq;

public class Deck
{
    public readonly List<Card> Cards = new List<Card>();
    public readonly bool AreJokersIncluded;

    public Deck(bool _)
    {
        FillDeck();

        // Add jokers to the deck
        Cards.Add(new Card("Joker", "Red"));
        Cards.Add(new Card("Joker", "Black"));
    }

    public Deck()
    {
        FillDeck();
    }

    public void FillDeck()
    {
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
    }

    public void Shuffle()
    {
        var random = new Random();
        var shuffledCards = Cards.OrderBy(_ => random.Next()).ToList();
        Cards.Clear();
        Cards.AddRange(shuffledCards);
    }

    public Card? Draw()
    {
        // Draw a card from the deck, if there are no cards left, return null
        if (Cards.Count == 0) return null;

        var drawnCard = Cards.Last();
        Cards.Remove(drawnCard);

        return drawnCard;
    }

    public List<Card?> Draw(int drawCount)
    {
        List<Card?> drawnCards = new();
        for (int i = 0; i < drawCount; i++)
        {
            if (Cards.Count == 0) drawnCards.Add(null);
            else {
                var drawnCard = Cards.Last();
                drawnCards.Add(drawnCard);
                Cards.Remove(drawnCard);
            }
        }

        return drawnCards;
    }
}