public class Circle : Shape
{
    private double Radius { get; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double Area => Math.PI * Radius * Radius;

    public override double Perimeter => 2 * Math.PI * Radius;

    public override string Info() => $"Circle with a radius of {Radius}";
}