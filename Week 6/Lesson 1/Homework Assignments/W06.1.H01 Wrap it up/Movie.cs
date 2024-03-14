class Movie : IAgeSuitability
{
    public string Title { get; }
    public int MinimumAge { get; }
    public int MaximumAge { get; }

    public Movie(string title, int minimumAge, int maximumAge)
    {
        Title = title;
        MinimumAge = minimumAge;
        MaximumAge = maximumAge;

        // Flip the minimum and maximum age if the minimum is greater than the maximum
        if (MinimumAge > MaximumAge) (MinimumAge, MaximumAge) = (MaximumAge, MinimumAge);
    }

    public string AgeSuitability => $"{MinimumAge}-{MaximumAge}";
    public override string ToString() => $"{Title} ({AgeSuitability})";
}