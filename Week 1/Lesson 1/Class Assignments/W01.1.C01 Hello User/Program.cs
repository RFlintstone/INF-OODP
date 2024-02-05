using System;

namespace W01._1.C01_Hello_User
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter your last name");
            String lastName = Console.ReadLine();
            Console.WriteLine("What's the initial of your first name?");
            String initial = Console.ReadLine();

            if (initial.Length == 1)
            {
                Convert.ToChar(initial);
            }
            
            Console.WriteLine($"Welcome to the course, {initial} {lastName}. We will watch your career with great interest."); 
        }
    }
}