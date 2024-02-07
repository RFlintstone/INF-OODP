// V Your code goes below V

List<string> colors = new List<string>() { "red", "blue", "green", "yellow" };
int fortuneNumber;

string color;
do
{
    Console.WriteLine("Pick a color (red/blue/green/yellow):");
    color = Console.ReadLine() ?? "";
} while (!colors.Contains(color));

int number;
do
{
    Console.WriteLine("Pick a number (1-8):");
    number = Convert.ToInt16(Console.ReadLine() ?? "");
} while (number < 1 || number > 8);

fortuneNumber = ((color.Length + number) % 4)+1;

// ^ Your code goes above ^
//No need to look below here for this assignment. But you are welcome to!
PrintFortune(fortuneNumber);

static void PrintFortune(int fortuneNumber)
{
    string fortune = fortuneNumber switch
    {
        1 => "You will be loved and be happy!",
        2 => "You will be loved and be rich!",
        3 => "You will be loved and be famous!",
        4 => "You will be loved, and you'll be happy, rich and famous!",
        _ => "Unknown. :( But you will still be loved, no matter what."
    };
    Console.WriteLine(fortune);
}