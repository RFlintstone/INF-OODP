using System;
using System.Collections.Generic;

namespace W01._2.H06_Game_Board
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Ask the user for the size of the board, keep asking if the input is lower than 2
            int size;
            do
            {
                Console.WriteLine("What is the size of the board?");
                size = int.Parse(Console.ReadLine() ?? "2");
            } while (size < 2);

            // Create the board
            List<string> board = new List<string>();
            for (int i = 0; i < size; i++)
            {
                char startChar = (size - i - 1) % 2 == 0 ? 'B' : 'W';
                string row = "";
                for (int j = 0; j < size; j++)
                {
                    if (j % 2 == 0)
                    {
                        row += startChar;
                    }
                    else
                    {
                        if (startChar == 'W')
                        {
                            row += 'B';
                        }
                        else
                        {
                            row += 'W';
                        }
                    }
                }

                board.Add(row);
            }

            // Print the board
            foreach (string line in board)
            {
                Console.WriteLine(line);
            }
        }
    }
}