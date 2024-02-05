using System;

namespace W01._1.C09_Switch_expression_statement
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter an age:");
            int age = Convert.ToInt16(Console.ReadLine());
            
            string age_category = age switch
            {
                var a when a >= 0 && a <= 12 => $"Age {age}: a child",
                var a when a >= 13 && a <= 19 => $"Age {age}: a teenager",
                var a when a >= 20 && a <= 150 => $"Age {age}: an adult",
                _ => $"Age {age}: invalid"
            };
            
            Console.WriteLine(age_category);
        }
    }
}