using System;

namespace W01._1.C05_Water_State_Watching
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("What is the temperature of the water? (Celsius)");
            Double temp = Convert.ToDouble(Console.ReadLine());

            switch (temp)
            {
                case var t when t <= 0:
                    Console.WriteLine($"At {t} degrees Celsius, the water will be solid\n");
                    break;
                case var t when t > 0 && t < 100:
                    Console.WriteLine($"At {t} degrees Celsius, the water will be liquid\n");
                    break;
                case var t when t >= 100:
                    Console.WriteLine($"At {t} degrees Celsius, the water will be gas\n");
                    break;
                default:
                    Console.WriteLine($"{temp} is not valid");
                    break;
            }
        }
    }
}