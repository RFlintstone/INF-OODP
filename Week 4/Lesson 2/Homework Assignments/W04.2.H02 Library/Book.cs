public class Book
{
    public int ID { get; private set; }
    public string Title { get; private set; }

    public Book(int id, string title = "Title unknown")
    {
        ID = id;
        Title = title;
    }

    public string Info()
    {
        return $"ID = {ID}, Title = {Title}";
    }
}