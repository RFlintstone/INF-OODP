using static System.Console;

namespace W02._1.C05_Square_Pair___Making_objects_and_calling_their_methods
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var squareOne = new Square(5);
            CalcAndLog(squareOne);

            var squareTwo = new Square(10);
            CalcAndLog(squareTwo);
        }

        private static void CalcAndLog(Square square)
        {
            var side = square.Side;
            var area = square.Area();
            var perimeter = square.Perimeter();
            WriteLine($"Side: {side}");
            WriteLine($"Area: {area}");
            WriteLine($"Perimeter: {perimeter}");
        }
    }

    internal class Square
    {
        public int Side;

        public Square(int side)
        {
            Side = side;
        }

        public int Area()
        {
            return Side * Side;
        }

        public int Perimeter()
        {
            return 4 * Side;
        }
    }
}