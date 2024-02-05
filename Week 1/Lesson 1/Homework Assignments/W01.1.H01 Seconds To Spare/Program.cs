using System;

namespace W01._1.H01_Seconds_To_Spare
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("How many seconds?");
            int input = Convert.ToInt32(Console.ReadLine());

            int secondsInHour = 3600;
            int secondsInMinute = 60;
            
            int hours = input / secondsInHour; 
            int secondsRemaining = input % secondsInHour;

            int minutes = secondsRemaining / secondsInMinute;
            int secondsLeft = secondsRemaining % secondsInMinute;  
            
            Console.WriteLine($"Hours: {hours}");
            Console.WriteLine($"Minutes: {minutes}"); 
            Console.WriteLine($"Seconds left: {secondsLeft}");
        }
    }
}