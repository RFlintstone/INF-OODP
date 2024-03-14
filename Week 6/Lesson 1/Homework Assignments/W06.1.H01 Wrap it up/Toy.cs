class Toy : IAgeSuitability
{
    public string Name { get; }
    public int MinimumAge { get; }
    public int MaximumAge { get; }
    public string AgeSuitability => $"{MinimumAge}-{MaximumAge}";


    public Toy(string name, int minimumAge, int maximumAge)
    {
        Name = name;
        MinimumAge = minimumAge;
        MaximumAge = maximumAge;

        // Flip the minimum and maximum age if the minimum is greater than the maximum
        if (MinimumAge > MaximumAge) (MinimumAge, MaximumAge) = (MaximumAge, MinimumAge);
    }
    
    public override string ToString() => $"{Name} ({AgeSuitability})";
}