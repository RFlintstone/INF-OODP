Random random = new Random(1);

int amountOfDice = 10;

for (int i = 0; i < amountOfDice; i++)
{
    Console.WriteLine(random.Next(1, 6));
}