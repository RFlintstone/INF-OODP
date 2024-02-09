Console.WriteLine("What is the amount to pay?");
int toBePaid = Convert.ToInt16(Console.ReadLine());

int currentlyPaid = 0;
while (currentlyPaid < toBePaid)
{
    Console.WriteLine();
    Console.WriteLine($"{toBePaid-currentlyPaid} left to pay\nPay how much?");
    Console.WriteLine("1: 5\n2: 10\n3: 20\n4: 50");

    string wantToPay = Console.ReadLine() ?? "";
    switch (wantToPay)
    {
        case "1":
            currentlyPaid += 5;
            break;
        case "2":
            currentlyPaid += 10;
            break;
        case "3":
            currentlyPaid += 20;
            break;
        case "4":
            currentlyPaid += 50;
            break;
    }
    
    if (currentlyPaid > toBePaid)
    {
        Console.WriteLine($"You paid {currentlyPaid-toBePaid} too much. Give a tip? y/n");
        string input = Console.ReadLine() ?? "n";
        
        if (!input.Equals("y"))
        {
            currentlyPaid = toBePaid;
        }
    }
}

Console.WriteLine($"You have paid {currentlyPaid}");