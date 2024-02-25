using System.Runtime.InteropServices;
using Newtonsoft.Json;

public class Book
{
    public static string path { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public int PublicationYear { get; set; }

    public Book(string title, string author, int publicationYear)
    {
        this.Title = title;
        this.Author = author;
        this.PublicationYear = publicationYear;
    }

    public override string ToString() => $"{Title} by {Author} ({PublicationYear})";

    public static List<Book> LoadJson()
    {
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows)) path = "./../../../books.json";
        else path = "books.json";

        var json = File.ReadAllText(path);
        var books = JsonConvert.DeserializeObject<List<Book>>(json);
        
        return books ?? new List<Book>();
    }

    public void SaveJson()
    {
        // Load existing list of books
        var books = LoadJson();

        // Prevent duplicate books

        // If no duplicate, extend existing list of books with this book
        books.Add(this);

        // Detect how to format the JSON file
        Formatting format;
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows)) format = Formatting.Indented;
        else format = Formatting.None;

        // Save the list of books to the JSON file
        var json = JsonConvert.SerializeObject(books, format);
        File.WriteAllText(path, json);
    }
}