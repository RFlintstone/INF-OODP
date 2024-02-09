using System;
using static System.Console;

namespace W02._1.C01_Void
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            PrintFullName("John", "Doe");
        }

        public static void PrintFullName(string firstName, string lastName)
        {
            WriteLine($"{firstName} {lastName}");
        }
    }
}