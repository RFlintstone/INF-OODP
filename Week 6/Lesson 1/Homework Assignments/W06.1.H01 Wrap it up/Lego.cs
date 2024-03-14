class Lego : Toy
{
    public bool IsBuilt { get; private set; } = false;
    public new int MinimumAge { get; private set; }
    public new int MaximumAge { get; private set; }
    public new string AgeSuitability => $"{MinimumAge}+";

    public Lego(string name, int minimumAge) : base(name, minimumAge: 8, maximumAge: -1)
    {
        MinimumAge = minimumAge;
        MaximumAge = base.MaximumAge; // Technically not needed, but it's good to be explicit
    }

    public void Build() => IsBuilt = true;
    public void Disassemble() => IsBuilt = false;

    public override string ToString() => $"{Name} (ages {MinimumAge}+)";
}