using System.Runtime.InteropServices;
using Newtonsoft.Json;

class Program
{
    public static void Main(string[] args)
    {
        // Print the books
        Console.WriteLine("Before adding a new book:");
        foreach (var book in Book.LoadJson())
        {
            Console.WriteLine(book);
        }

        // Add and save a new book, if the input is '+'
        string input = Console.ReadLine();
        if (input.Length > 0 && input == "+")
        {
            string title = Console.ReadLine();
            string author = Console.ReadLine();
            int publicationYear;
            if (!int.TryParse(Console.ReadLine(), out publicationYear))
            {
                Console.WriteLine("Invalid input for publication year. Please enter a valid integer.");
                return;
            }

            new Book(title, author, publicationYear).SaveJson();
        }
        
        // Remove an existing book, if the input is '-'
        if (input.Length > 0 && input == "-")
        {
            do
            {
                string title = Console.ReadLine();
                string author = Console.ReadLine();
                int publicationYear;
                if (!int.TryParse(Console.ReadLine(), out publicationYear))
                {
                    Console.WriteLine("Invalid input for publication year. Please enter a valid integer.");
                    return;
                }

                var books = Book.LoadJson();
                var book = new Book(title, author, publicationYear);
                books.Remove(book);
                book.SaveJson();
            } while (Console.ReadLine() != "q");
        }

        // Print the books
        Console.WriteLine("\nBefore adding a new book:");
        foreach (var book in Book.LoadJson())
        {
            Console.WriteLine(book);
        }
    }

    /// <summary>
    /// Load the books from the JSON file
    /// </summary>
    /// <returns>List of Books</returns>
    // private static List<Book> LoadJson()
    // {
    //     var json = File.ReadAllText(Book.path);
    //     var books = JsonConvert.DeserializeObject<List<Book>>(json);
    //     return books ?? new List<Book>();
    // }

    /// <summary>
    /// Save the books to the JSON file
    /// </summary>
    /// <param name="books">List to save to JSON</param>
    // private static void SaveJson(List<Book> books)
    // {
    //     Formatting format;
    //     if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows)) format = Formatting.Indented;
    //     else format = Formatting.None;
    //     var json = JsonConvert.SerializeObject(books, format);
    //     File.WriteAllText(Book.path, json);
    // }
}