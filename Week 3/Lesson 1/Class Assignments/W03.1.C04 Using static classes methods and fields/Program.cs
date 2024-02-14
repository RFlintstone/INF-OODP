using System;
using static System.Console;
class Program
{
    static void Main()
    {
        WriteLine("Give the circle radius:");
        double radius = Convert.ToDouble(Console.ReadLine());
        var circle = new Circle(radius);

        //Print the rounded circle area here
        circle.Area();
        WriteLine($"Rounded circle area: {Math.Round(circle.Area())}");
    }
}