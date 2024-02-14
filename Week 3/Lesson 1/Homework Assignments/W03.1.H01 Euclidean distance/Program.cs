using System;

internal class Program
{
    public static void Main(string[] args)
    {
        var p1 = new Point(1, 2);
        var p2 = new Point(3, 4);
        var distance = Point.EuclideanDistance(p1, p2);
        Console.WriteLine(distance);
    }
}