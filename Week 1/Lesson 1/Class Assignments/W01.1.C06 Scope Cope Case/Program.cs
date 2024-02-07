using System;

namespace W01._1.C06_Scope_Cope_Case
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Give some text");
            string text = Console.ReadLine();

            Console.WriteLine("What do you want to do with this text?");
            Console.WriteLine("U: make all uppercase");
            Console.WriteLine("L: make all lowercase");
            Console.WriteLine("Any other key: do not change");
            string choice = Console.ReadLine();

            string newText;
            if (choice.ToUpper() == "U")
            {
                newText = text.ToUpper();
            }
            else if (choice.ToUpper() == "L")
            {
                newText = text.ToLower();
            }
            else
            {
                newText = text;
            }
            
            Console.WriteLine(newText);
        }
    }
}