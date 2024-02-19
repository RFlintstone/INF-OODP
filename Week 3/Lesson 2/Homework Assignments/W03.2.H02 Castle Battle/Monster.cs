public class Monster
{
    public readonly string Name;
    public int CurrentHP { get; set; }
    public int Strength { get; set; }
    public static int Experience { get; set; }

    public Monster(string name, int hp, int strength, int experience)
    {
        Name = name;
        CurrentHP = hp;
        Strength = strength;
        Experience = experience;
    }

    public void Attack(Player player)
    {
        player.TakeDamage(Strength);
    }

    public void TakeDamage(int damage)
    {
        CurrentHP = Math.Max(0, CurrentHP - damage);
    }

    public bool IsAlive()
    {
        return CurrentHP > 0;
    }
}