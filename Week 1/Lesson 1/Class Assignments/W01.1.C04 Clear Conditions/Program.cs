using System;

namespace W01._1.C04_Clear_Conditions
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            int age1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("What is the age of the student next to you?");
            int age2 = Convert.ToInt16(Console.ReadLine());

            int result = age1.CompareTo(age2);

            if (result == 0) 
            {
                Console.WriteLine("Your ages are equal");
            }
            else if (result > 0)  
            {
                Console.WriteLine("You are older");   
            }
            else
            {
                Console.WriteLine("You are younger");
            }
        }
    }
}