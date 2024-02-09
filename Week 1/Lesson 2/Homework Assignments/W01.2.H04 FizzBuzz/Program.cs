using System;

class Program
{
    private static int StartNr { get; set; }
    private static int EndNr { get; set; }

    public static void Main()
    {
        Console.WriteLine("Set Start Number:");
        int numberOne = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Set End Number:");
        int numberTwo = Convert.ToInt32(Console.ReadLine());

        SetStartNr(numberOne);
        SetEndNr(numberTwo);
        PrintRange();
    }

    private static void PrintRange()
    {
        for (int i = StartNr; i <= EndNr; i++)
        {
            if (i % 15 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (i % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (i % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(i);
            }
        }
    }

    public static void SetStartNr(int nr)
    {
        StartNr = nr;
    }

    public static void SetEndNr(int nr)
    {
        EndNr = nr;
    }
}