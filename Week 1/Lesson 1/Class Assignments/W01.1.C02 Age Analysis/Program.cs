using System;

namespace W01._1.C02_Age_Analysis
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // age = int(input("What is your age? "))
            // print("You are " + str(age) + ". That's old enough to program!")
            //
            // print("Last year you were " + str(age-1))
            // print("Next year you will be " + str(age+1))
            // print("At double your age you will be " + str(age*2))
            // print("Next year, double your age will be " + str((age+1) * 2))
            //
            // print("Half your age is " + str(age / 2.0)) #This should be a double in C#
            // print("Half your age (rounded down) is " + str(int(age / 2)))
            // print("The last digit of your age is " + str(age % 10))
            
            Console.WriteLine("What is your age?");

            int age = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine($"You are {age}. That's old enough to program!");

            Console.WriteLine($"Last year you were {age - 1}");
            Console.WriteLine($"Next year you will be {age + 1}");
            Console.WriteLine($"At double your age you will be {age * 2}");
            Console.WriteLine($"Next year, double your age will be {(age + 1) * 2}");

            Console.WriteLine($"Half your age is {age / 2.00}");
            Console.WriteLine($"Half your age (rounded down) is {Math.Floor((double) age / 2)}");
            Console.WriteLine($"The last digit of your age is {age % 10}");
        }
    }
}