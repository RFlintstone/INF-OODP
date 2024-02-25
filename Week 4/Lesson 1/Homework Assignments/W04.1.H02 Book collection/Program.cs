using System;
using Newtonsoft.Json;
using static System.Console;

class Program
{
    public static void Main(string[] args)
    {
        string input;
        do
        {
            Book.PrintAllBooks();
            WriteLine();
            PrintMenu();
            input = ReadLine() ?? "";
            if (input == "+")
            {
                AddBook();
                WriteLine();
            }
            else if (input == "-")
            {
                RemoveBook();
                WriteLine();
            } 
            // Check if we can parse the input to an integer. If it can it is a number.
            else if (int.TryParse(input, out int index))
            {
                var books = Book.LoadJson();
                if (index > 0 && index <= books.Count)
                {
                    WriteLine(books[index - 1]);
                }
                else
                {
                    WriteLine("Book does not exist");
                }
            }
            else
            {
                WriteLine("Invalid choice");
            }
        } while (input != "q");
    }

    private static void PrintMenu()
    {
        WriteLine("What would you like to do?");
        WriteLine("+: add a new book");
        WriteLine("-: remove a book");
        WriteLine("A number: see information on this book");
        WriteLine("q: quit");
    }

    private static void AddBook()
    {
        WriteLine("Enter the title of the new book:");
        string title = ReadLine();
        WriteLine("Enter the author of the new book:");
        string author = ReadLine();
        WriteLine("Enter the publication year of the new book:");
        if (int.TryParse(ReadLine(), out int publicationYear))
        {
            new Book(title, author, publicationYear).AddToJson();
        }
        else
        {
            WriteLine("Year is not in a valid format.");
        }
    }

    private static void RemoveBook()
    {
        try
        {
            WriteLine("Enter the number of the book to remove:");
            int index = int.Parse(ReadLine() ?? "");
            var books = Book.LoadJson();
        
            if (index > 0 && index <= books.Count)
            {
                var bookSelect = books[index - 1];
                bookSelect.RemoveFromJson();
            }
            else
            {
                WriteLine("Book does not exist");
            }
        }
        catch (FormatException)
        {
            WriteLine("Not an index.");
            // throw;
        }
    }
}