class BoardGame : Toy, IAgeSuitability
{
    public string Publisher { get; }
    public int MinimumAge { get; }
    public int MaximumAge { get; }
    public string AgeSuitability => $"{MinimumAge}-{MaximumAge}";

    public BoardGame(string name, string publisher, int minimumAge, int maximumAge) : base(name, minimumAge, maximumAge)
    {
        Publisher = publisher;
        MinimumAge = minimumAge;
        MaximumAge = maximumAge;
        
        // Flip the minimum and maximum age if the minimum is greater than the maximum
        if (MinimumAge > MaximumAge) (MinimumAge, MaximumAge) = (MaximumAge, MinimumAge);
    }
    
    public override string ToString() => $"{Name} by {Publisher} (ages {AgeSuitability})";
}