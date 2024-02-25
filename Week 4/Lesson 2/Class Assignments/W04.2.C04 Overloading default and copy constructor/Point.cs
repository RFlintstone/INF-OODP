using System;

public class Point
{
    double x;
    double y;

    public Point()
    {
        this.x = 0;
        this.y = 0;
    }
    
    public Point(double x, double y)
    {
        this.x = x;
        this.y = y;
    }
    
    public Point(Point p)
    {
        this.x = p.x;
        this.y = p.y;
    }
    
    public static double EuclideanDistance(Point p1, Point p2)
    {
        return Math.Sqrt(Math.Pow(p2.x - p1.x, 2) + Math.Pow(p2.y - p1.y, 2));
    }
}