using System;
using static System.Console;

namespace W02._1.C03_Expression_bodied_methods
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string fName = ReadLine();
            string lName = ReadLine();
            Name(fName, lName);
            DisplayName(fName, lName);
        }

        public static string Name(string firstName, string lastName) => $"{firstName} {lastName}";

        public static void DisplayName(string firstName, string lastName) => WriteLine(Name(firstName, lastName));
    }
}