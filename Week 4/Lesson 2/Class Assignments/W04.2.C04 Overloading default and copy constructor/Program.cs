class Program
{
    public static void Main(String[] args)
    {
        Point p1 = new Point(1, 1);
        Point p2 = new Point(2, 2);
        Console.WriteLine(Point.EuclideanDistance(p1, p2));
    }
}