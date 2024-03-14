class Lycanthrope : Fighter, ITransform
{
    public bool CanTransform => true;
    public bool IsTransformed { get; private set; }

    public override int MaxHitPoints
    {
        get => IsTransformed ? base.MaxHitPoints * 2 : base.MaxHitPoints;
        protected set => base.MaxHitPoints = value;
    }

    public override int AttackPower => IsTransformed ? base.AttackPower * 2 : base.AttackPower;

    public Lycanthrope(string name) : base(name)
    {
    }

    public void Transform()
    {
        if (World.IsDayTime)
            return;
        IsTransformed = true;
        CurrentHitPoints = MaxHitPoints;
    }

    public void Revert()
    {
        if (!World.IsDayTime)
            return;
        IsTransformed = false;
    }
}