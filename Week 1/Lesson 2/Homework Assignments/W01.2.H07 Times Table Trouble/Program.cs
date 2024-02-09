using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace W01._2.H07_Times_Table_Trouble
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int size = AskForSize();
            Console.WriteLine($"Times table for {size}:\n");
            List<string> table = CreateTable(size);
            foreach (string line in table)
            {
                Console.WriteLine(line);
            }
        }

        // Method to to ask the user for the size of the multiplication table
        public static int AskForSize()
        {
            // Ask the user for a number from 2 to 9 (inclusive). If the given number is lower, make it the lower bound (2); if the number is higher, make it the upper bound (9)
            Console.WriteLine("What number would you like to see the times table for?");
            int number = Convert.ToInt16(Console.ReadLine());
            number = Math.Max(2, Math.Min(number, 9));
            return number;
        }

        // Method to create the multiplication table
        public static List<string> CreateTable(int size)
        {
            List<string> table = new List<string>();

            // Header row
            var header = new StringBuilder();
            header.Append("  |"); // Space for row numbers
            header.AppendLine(string.Join("", Enumerable.Range(1, size).Select(i => $"{i,4}")));
            header.Append("----"); // Separator for row numbers
            header.Append(new string('-', size * 4));

            table.Add(header.ToString());

            // Calculate the multiplication table
            for (int i = 1; i <= size; i++)
            {
                var rowString = new StringBuilder();
                rowString.Append($"{i} |"); // Row number
                for (int j = 1; j <= size; j++)
                {
                    rowString.Append($"{i * j,4}");
                }

                table.Add(rowString.ToString());
            }

            return table;
        }
    }
}