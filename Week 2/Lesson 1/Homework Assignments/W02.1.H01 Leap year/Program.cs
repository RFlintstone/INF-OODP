using static System.Console;

internal class Program
{
    public static void Main(string[] args)
    {
        int input = int.Parse(ReadLine() ?? string.Empty);
        PrintIsLeapYear(input);
    }

    public static bool IsDivisibleBy(int value_one, int value_two)
    {
        return value_one % value_two == 0;
    }

    public static bool IsLeapYear(int year)
    {
        bool leapYear = false;

        if (IsDivisibleBy(year, 4) && !IsDivisibleBy(year, 100))
        {
            leapYear = true;
        }
        else if (IsDivisibleBy(year, 400))
        {
            leapYear = true;
        }

        return leapYear;
    }

    public static void PrintIsLeapYear(int year)
    {
        if (IsLeapYear(year))
        {
            WriteLine($"{year} is a leap year.");
        }
        else
        {
            WriteLine($"{year} is not a leap year.");
        }
    }
}