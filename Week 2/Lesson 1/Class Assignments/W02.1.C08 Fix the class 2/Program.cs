public class PlayingCard
{
    public string Suit;
    public string Rank;

    PlayingCard(string suit, string rank)
    {
        Suit = suit;
        Rank = rank;
    }

    public string Description() => $"The {Rank} of {Suit}";
}