using System;

namespace W01._1.C03_Celsius_to_Fahrenheit
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("What is the temperature in Celsius?");
            double celsius = Convert.ToDouble(Console.ReadLine());
            double fahrenheit = celsius * 1.8 + 32;
            Console.WriteLine($"{celsius} C = {fahrenheit} F");
            Console.WriteLine($"Truncated that is {Math.Floor(fahrenheit)} F");

        }
    }
}