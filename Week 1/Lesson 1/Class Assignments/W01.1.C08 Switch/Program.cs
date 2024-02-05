using System;

namespace W01._1.C08_Switch
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int x = 0;
            int y = 0;
            
            Console.WriteLine("What direction would you like to go?");
            String input = Console.ReadLine();

            String checkInput = input.ToLower();
            switch (checkInput)
            {
                case "up":
                    y += 1;
                    Console.WriteLine("Current position");
                    Console.WriteLine($"X:{x}, Y:{y}");
                    break;
                case "down":
                    y -= 1;
                    Console.WriteLine("Current position");
                    Console.WriteLine($"X:{x}, Y:{y}");
                    break;
                case "left":
                    x -= 1;
                    Console.WriteLine("Current position");
                    Console.WriteLine($"X:{x}, Y:{y}");
                    break;
                case "right":
                    x += 1;
                    Console.WriteLine("Current position");
                    Console.WriteLine($"X:{x}, Y:{y}");
                    break;
                default:
                    Console.WriteLine($"Invalid direction");
                    break;
            }
        }
    }
}