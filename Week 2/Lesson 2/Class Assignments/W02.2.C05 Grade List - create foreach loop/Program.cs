using System.Collections.Generic;

internal class Program
{
    public static void Main(string[] args)
    {
        List<double> grades = new List<double> { 7, 5.5, 3.2, 10, 4.5 };
        int above_average = 0;
        foreach (var grade in grades)
        {
            if (grade >= 5.5)
            {
                above_average++;
            }
        }
        
        System.Console.WriteLine($"{above_average} out of {grades.Count} students passed");
    }
}