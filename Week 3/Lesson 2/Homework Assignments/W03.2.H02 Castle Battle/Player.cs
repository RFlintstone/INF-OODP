public class Player
{
    public const string Name = "Simon Belmont";
    public int MaxHP { get; set; }
    public int CurrentHP { get; set; }
    public int Strength { get; set; }
    public static int Experience;
    public static int LastExperience;
    private int level;

    public Player(int hp, int strength)
    {
        MaxHP = hp;
        CurrentHP = MaxHP;
        Strength = strength;
        Experience = LastExperience;
    }

    public void Attack(Monster monster)
    {
        monster.TakeDamage(Strength);
        if (!monster.IsAlive())
        {
            Experience += Monster.Experience;
            GetLevel();
        }
    }

    public void TakeDamage(int damage)
    {
        int actualDamage = damage - (Strength / 4);
        CurrentHP -= actualDamage;
    }

    public int GetLevel()
    {
        int currentLevel = level;
        int newLevel = 1;
        for (int i = 0; i < World.ExperienceChart.Count; i++)
        {
            if (Experience >= World.ExperienceChart[i])
            {
                newLevel = i + 2;
            }
        }

        if (newLevel > currentLevel)
        {
            MaxHP = World.PlayerBaseHP + 10 * (newLevel - 1);
            Strength = World.PlayerBaseStrength + 3 * (newLevel - 1);
            level = newLevel;
        }

        return level;
    }

    public bool IsAlive()
    {
        bool isAlive = CurrentHP > 0;
        if (!isAlive)
        {
            LastExperience = Experience;
        }
        return isAlive;
    }
}