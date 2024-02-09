int money = 4;
int rideCosts = 1;

Console.WriteLine($"Money left: {money}");

while (money >= rideCosts)
{
    try
    {
        Console.WriteLine("Look around (1) or go in a ride (2)?");
        string toDo = Console.ReadLine();

        if (toDo == "1")
        {
            Console.WriteLine("Yay!");
        }

        if (toDo == "2")
        {
            money -= rideCosts;
            Console.WriteLine("Wheee!");
        }

        if (money > 0)
        {
            Console.WriteLine($"Money left: {money}");
        }
    }
    catch (Exception e)
    {
        Console.WriteLine(e);
        throw;
    }
}

Console.WriteLine("Time to go home");