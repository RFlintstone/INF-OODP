public class Square : IDrawable, IResizable
{
    public int Size { get; private set; }
    public Square(int size) => Size = size;

    public void Draw()
    {
        for (int i = 0; i < Size; i++)
        {
            for (int j = 0; j < Size; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
    
    public void Resize(double scale) => Size = (int)(Size * scale);
    
}