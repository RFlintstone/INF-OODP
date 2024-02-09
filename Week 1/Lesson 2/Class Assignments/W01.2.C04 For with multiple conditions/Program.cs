string pinNr = "1234";
int maxAttempts = 3;
int attemptsLeft = maxAttempts;

for (int i = 0; i < maxAttempts + 1; i++)
{
    string input = "";
    if (i < maxAttempts)
    {
        Console.WriteLine($"Enter your PIN \n{attemptsLeft} attempts left");
        input = Console.ReadLine() ?? "";
    }


    if (input.Equals(pinNr))
    {
        Console.WriteLine("Correct!");
        break;
    }

    attemptsLeft -= 1;
}

if (attemptsLeft.Equals(-1))
{
    Console.WriteLine("Your pass is confiscated.");
}