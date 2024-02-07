// First ask the user for each cardinal direction (north, east, south and west) if these are valid directions (Y/N) to go to. Then print a compass with the valid directions.
//
// Then ask the user for a bearing (angle), which is a number in degrees, so from 0 to 360 (exclusive). If the user gives a lower or higher number, normalize it so that it's within the range of 0 and 360. So for example, if the user gives 500, you should make it 140 (as 500 - 360 = 140).
//
// With this (corrected) number, determine the direction: north, east, south or west:
//
// between 315 (exclusive) and 45 (inclusive) degrees: north
// between 45 (exclusive) and 135 (inclusive) degrees: east
// between 135 (exclusive) and 225 (inclusive) degrees: south
// between 225 (exclusive) and 315 (inclusive) degrees: west
// Then print either You are going north" (if the direction is valid) or You can't go north (if it isn't).

using System;
using System.Collections.Generic;
using System.Linq;

namespace W01._1.H06_Bearing_Squaring
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            List<string> directionList = AskDirections();
            int bearing = AskBearing();
            BearingToDirection(bearing, directionList);
        }

        static List<string> AskDirections()
        {
            Console.WriteLine("For each direction, input Y/N if it is valid.");
            List<String> directions = new List<string>() {"North", "East", "South", "West"};
            List<String> directionAnswers = new List<string>();

            foreach (var direction in directions)
            {
                Console.WriteLine($"{direction}? Y/N");
                string input = Console.ReadLine();
                if (input.ToLower() == "y")
                {
                    directionAnswers.Add(direction.ToLower());
                }
            }

            return directionAnswers;
        }

        static int AskBearing()
        {
            Console.WriteLine("Give a bearing (a number) for the direction in which you are going.");
            int input = Convert.ToInt16(Console.ReadLine());
            return input;
        }

        static void BearingToDirection(int bearing, List<string> directions)
        {
            int north = 0;
            int east = 1;
            int south = 2;
            int west = 3;

            int bearingNormalized;
            if (bearing < 0)
            {
                bearingNormalized = (bearing % 360) + 360;
            }
            else
            {
                bearingNormalized = bearing % 360;
            }

            string bearingDirection = "Not set";

            if (bearingNormalized <= 45 || bearingNormalized > 315)
            {
                bearingDirection = "north";
            }
            else if (bearingNormalized >= 45 && bearingNormalized <= 135)
            {
                bearingDirection = "east";
            }
            else if (bearingNormalized > 135 && bearingNormalized <= 225)
            {
                bearingDirection = "south";
            }
            else
            {
                bearingDirection = "west";
            }

            string northStringCompass = "     ";
            string westStringCompass = "    ";
            string eastStringCompass = "    ";
            string southStringCompass = "     ";

            if (directions.Contains("north"))
            {
                northStringCompass = "    N\n    |";
            }

            if (directions.Contains("west"))
            {
                westStringCompass = "W---";
            }

            if (directions.Contains("east"))
            {
                eastStringCompass = "---E";
            }

            if (directions.Contains("south"))
            {
                southStringCompass = "|\n    S\n";
            }
            
            string img = $"{northStringCompass}\n{westStringCompass}|{eastStringCompass}\n    {southStringCompass}";
            
            bool directionFound = false;
            foreach (var direction in directions)
            {
                if (bearingDirection.ToLower() == direction.ToLower())
                {
                    directionFound = true;
                    break;
                }
            }

            string message = "Not set";
            if (!directionFound)
            { 
                message = $"You can't go {bearingDirection}";
            }
            else
            {
                message = $"You are going {bearingDirection}";
            }

            string output = $"{img}\n{message}";
            Console.WriteLine(output);

            // Console.WriteLine(bearingNormalized);
            // Console.WriteLine(bearingDirection);
            // Console.WriteLine(string.Join(",", directions.ToArray()));
        }
    }
}