using System.Runtime.InteropServices;
using Newtonsoft.Json;
using static System.Console;

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
    
    public static void PrintAllBooks()
    {
        var books = LoadJson();
        for (int i = 0; i < books.Count; i++)
        {
            WriteLine($"{i + 1}. {books[i]}");
        }
    }

    public static string DetectOs()
    {
        return RuntimeInformation.IsOSPlatform(OSPlatform.Windows)
            ? path = "./../../../books.json"
            : path = "books.json";
    }

    public static Formatting DetectFormat()
    {
        return RuntimeInformation.IsOSPlatform(OSPlatform.Windows) ? Formatting.Indented : Formatting.None;
    }

    public static List<Book> LoadJson()
    {
        try
        {
            var json = File.ReadAllText(DetectOs());
            var books = JsonConvert.DeserializeObject<List<Book>>(json);
            return books ?? new List<Book>();
        }
        catch (JsonReaderException)
        {
            Console.WriteLine("\nError: Could not load books from JSON file.");
            ClearJson();
            PrintAllBooks();
            // Console.WriteLine(e);
            // throw;
        } catch (FileNotFoundException)
        {
            Console.WriteLine("\nError: Could not find JSON file.");
            ClearJson();
            PrintAllBooks();
            // Console.WriteLine(e);
            // throw;
        }

        return new List<Book>();
    }

    public void AddToJson()
    {
        try
        {
            // Load existing list of books
            var books = LoadJson();

            // Prevent duplicate books

            // If no duplicate, extend existing list of books with this book
            books.Add(this);

            // Save the list of books to the JSON file
            var json = JsonConvert.SerializeObject(books, DetectFormat());
            File.WriteAllText(DetectOs(), json);
        }
        catch (JsonReaderException e)
        {
            Console.WriteLine("\nError: Could not add book to JSON file.");
            Console.WriteLine(e);
            throw;
        }
    }

    public void RemoveFromJson()
    {
        try
        {
            // Load existing list of books
            var books = LoadJson();

            // Find the book
            var bookToRemove = books.Find(b =>
                b.Title == this.Title && b.Author == this.Author && b.PublicationYear == this.PublicationYear);

            // If the book is not found, return
            if (bookToRemove == null) return;

            // Remove the book
            books.Remove(bookToRemove);

            // Save the list of books to the JSON file
            var json = JsonConvert.SerializeObject(books, DetectFormat());
            File.WriteAllText(DetectOs(), json);
        }
        catch (JsonReaderException e)
        {
            Console.WriteLine("\nError: Could Remove add book to JSON file.");
            Console.WriteLine(e);
            throw;
        }
    }

    public static void ClearJson()
    {
        try
        {
            // Clear the JSON file
            File.WriteAllText(DetectOs(), string.Empty);
        }
        catch (JsonReaderException e)
        {
            Console.WriteLine("\nError: Could not clear JSON file.");
            Console.WriteLine(e);
            throw;
        }
    }
}