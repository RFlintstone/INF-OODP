using System;

class Program
{
    static void Main(string[] args)
    {
        int score = 0;

        Console.WriteLine("Answer the following MCQs");

        // First MCQ
        Console.WriteLine("Which of the following is NOT a valid type in C#?");
        Console.WriteLine("A: bool");
        Console.WriteLine("B: int");
        Console.WriteLine("C: var");
        Console.WriteLine("D: string");

        string answer1 = Console.ReadLine().ToLower();

        if (answer1 == "c")
        {
            Console.WriteLine("Correct!");
            score++;
        }
        else
        {
            Console.WriteLine("Incorrect!");
        }

        // Second MCQ
        Console.WriteLine("\nWhat happens if you execute the following line in C#?");
        Console.WriteLine("int x = 1.23;");
        Console.WriteLine("A: x will be 1.23");
        Console.WriteLine("B: x will be 1");
        Console.WriteLine("C: x will be 1.0");
        Console.WriteLine("D: you will get a compiler error");

        string answer2 = Console.ReadLine().ToLower();

        if (answer2 == "d")
        {
            Console.WriteLine("Correct!");
            score++;
        }
        else
        {
            Console.WriteLine("Incorrect!");
        }

        // Third MCQ
        Console.WriteLine("\nConsider the following line:");
        Console.WriteLine("double d = 1.23;");
        Console.WriteLine("What are TWO ways to convert variable d to an int?");
        Console.Write("Your first answer: ");
        string answer3a = Console.ReadLine().ToLower();

        Console.Write("Your second answer: ");
        string answer3b = Console.ReadLine().ToLower();

        if (answer3a == "a" && answer3b == "d")
        {
            Console.WriteLine("Correct!");
            score++;
        }
        else
        {
            Console.WriteLine("Incorrect!");
        }

        Console.WriteLine($"\nYour score: {score} out of 3.");
        if (score == 3)
        {
            Console.WriteLine("Well done!");
        }
    }
}
