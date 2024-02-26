class Cuboid : Rectangle
{
    public int Height;
    
    public Cuboid(int length, int width, int height) : base(length, width)
    {
        Height = height;
    }
    
    public int Volume() => Length * Width * Height;
    
    public override int Area() => (2*(Length*Width)) + (2*(Length*Height)) + (2*(Width*Height));

    public override int Perimeter() => (4 * (Length + Width + Height));
    
    public override string Info() => $"{base.Info()}; Height: {Height}";
}