using System;

internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Give the circle radius:");
        double radius = Convert.ToDouble(Console.ReadLine());
        var circle = new Circle(radius);

        //Print the rounded circle area here
    }
}