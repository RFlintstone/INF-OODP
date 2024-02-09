using System;
using System.Collections.Generic;
using System.Globalization;

namespace W01._2.H08_Retaking_grades
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<string> grades = new List<string>() { "6.5", "9.5", "4", "5", "4.5", "10", "7.1" };

            for (int i = 0; i < grades.Count; i++)
            {
                if (Convert.ToDouble(grades[i]) < 5.5)
                {
                    string input;
                    do
                    {
                        Console.WriteLine($"Grade: {grades[i]}");
                        Console.WriteLine("Retake this course? y/n");
                        input = Console.ReadLine() ?? "";
                        if (!input.Equals(""))
                        {
                            input = input.ToLower();
                        }
                    } while (!input.Equals("y") && !input.Equals("n"));

                    if (input.Equals("y"))
                    {
                        grades[i] = (double.Parse(grades[i]) + 1).ToString(CultureInfo.InvariantCulture);
                    }
                }
                else
                {
                    Console.WriteLine($"Grade: {grades[i]}");
                }
            }

            grades.ForEach(grade => { Console.WriteLine(grade); });
        }
    }
}