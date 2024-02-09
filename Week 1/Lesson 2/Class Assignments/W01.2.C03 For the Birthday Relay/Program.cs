Console.WriteLine("What is the person's name?");
string name = Console.ReadLine() ?? "";

int max_count = 4;

for (int i = 0; i < max_count; i++)
{
    if (i != 2)
    {
        Console.WriteLine("Happy birthday to you!");
    }
    else
    {
        Console.WriteLine($"Happy birthday dear {name}!");
    }
}

