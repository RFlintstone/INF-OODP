class Witch : Fighter, ITransform
{
    public override int MaxHitPoints => 80;

    public int MaxMagicPoints => 100;
    private int _currentMagicPoints;

    public int CurrentMagicPoints
    {
        get => _currentMagicPoints;
        private set => _currentMagicPoints = Math.Clamp(value, 0, MaxMagicPoints);
    }

    // Attack power is decreased while transformed into a raven.
    // Attack power is increased by the familiar, if any.
    public override int AttackPower => (IsTransformed ? 1 : 5) + (MyFamiliar?.Attack ?? 0);

    public Familiar MyFamiliar { get; set; }

    public bool IsTransformed { get; private set; } = false;

    public Witch(string name, Familiar familiar) : base(name)
    {
        MyFamiliar = familiar;
        CurrentMagicPoints = MaxMagicPoints;
    }

    public void Transform()
    {
        if (CurrentMagicPoints < 10)
            return; // Not enough MP to transform into a raven

        CurrentMagicPoints -= 10;
        IsTransformed = true;
    }

    public void Revert() => IsTransformed = false; // Reverting costs no MP

    public void Enchant(List<ITransform> targets)
    {
        int totalMPCost = 0;
        foreach (var target in targets)
        {
            totalMPCost += 10;
        }

        if (CurrentMagicPoints < totalMPCost)
            return;

        CurrentMagicPoints -= totalMPCost;
        foreach (var target in targets)
        {
            target.Transform();
        }
    }

    public void Disenchant(List<ITransform> targets)
    {
        int totalMPCost = 0;
        foreach (var target in targets)
        {
            totalMPCost += 10;
        }

        if (CurrentMagicPoints < totalMPCost)
            return;

        CurrentMagicPoints -= totalMPCost;
        foreach (var target in targets)
        {
            target.Revert();
        }
    }

    public void RecoverMagicPoints(int amount)
    {
        if (amount < 0)
            throw new ArgumentException(
                $"Invalid amount: {amount}. Magic recovered must be non-negative.");
        CurrentMagicPoints += amount;
    }
}