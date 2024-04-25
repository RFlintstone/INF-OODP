public class Square : Shape
{
    private double Length { get; }

    public Square(double length)
    {
        Length = length;
    }

    public override double Area => Length * Length;

    public override double Perimeter => 4 * Length;

    public override string Info() => $"Square with sides of {Length}";
}