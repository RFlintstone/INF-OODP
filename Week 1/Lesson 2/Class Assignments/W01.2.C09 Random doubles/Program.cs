Random random = new Random();

int attack = 50;
double critChance = 0.33;
int bossHP = 1000;

while (bossHP > 0)
{
    Console.WriteLine($"Boss HP: {bossHP}");

    int damage;
    double checkCrit = random.NextDouble();
    if (checkCrit <= critChance)
    {
        damage = attack * 2;
    }
    else
    {
        damage = attack;
    }

    bossHP -= damage;
    Console.WriteLine($"Damage: {damage}");
    Console.WriteLine();
}

Console.WriteLine("Boss defeated");