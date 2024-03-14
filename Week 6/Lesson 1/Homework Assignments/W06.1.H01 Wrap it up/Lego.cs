class Lego : Toy
{
    public bool IsBuilt { get; private set; } = false;
    public Lego(string name, int minimumAge) : base(name, minimumAge: 10, maximumAge: 99)
    {

    }

    public void Build() => IsBuilt = true;
    public void Disassemble() => IsBuilt = false;
    
    public override string ToString() => $"{Name} ({MinimumAge})";
}