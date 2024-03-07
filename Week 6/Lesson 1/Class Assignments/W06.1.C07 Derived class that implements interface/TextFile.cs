public interface IPrintable
{
    void Print();
}

public class TextFile : IPrintable
{
    public string FileName { get; set; }
    public string Content { get; set; }

    public TextFile(string fileName, string content)
    {
        if (!string.IsNullOrEmpty(fileName)) FileName = $"{fileName}.txt";
        Content = content;
    }

    public void Print()
    {
        Console.WriteLine(Content);
    }
}