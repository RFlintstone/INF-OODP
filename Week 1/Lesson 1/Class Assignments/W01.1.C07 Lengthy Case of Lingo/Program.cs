using System;

namespace W01._1.C07_Lengthy_Case_of_Lingo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            String answer = "Length";
            String obscured_answer = answer.Substring(0, 2) + new string('.', 3) + answer.Substring(5);
            Console.WriteLine("You have one chance to guess this six-letter word:");
            Console.WriteLine(obscured_answer);
            String input = Console.ReadLine();

            // If we somehow didn't provide a 6 letter word as answer. We do want to setup the game correctly.
            if (answer.Length != 6)
            {
                Console.WriteLine("Replace the answer with a 6 letter word.");
                return;
            }
            
            // Check if we put in the correct answer
            if (input == answer)
            {
                Console.WriteLine("Correct!");
                return;
            }
            
            // If we dont have the correct case but do have the correct answer
            if (input != answer && input.ToLower() == answer.ToLower())
            {
                Console.WriteLine("Kind of correct; the case was just wrong");
                return;
            }

            // If we don't have the correct answer at all
            if (input != answer && input.Length == answer.Length)
            {
                Console.WriteLine("Incorrect!");
                return;
            }
            
            // If we also don't have the correct answer and it's not the correct length
            if (input != answer && input.Length != answer.Length)
            {
                Console.WriteLine("Incorrect! That is not even a six-letter word!");
            }
        }
    }
}