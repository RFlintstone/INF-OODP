using System;
using System.Collections.Generic;
using System.Linq;

public class Library
{
    public List<Book> Books { get; private set; }

    public Library(List<Book> books = null)
    {
        Books = books ?? new List<Book>();
    }

    public void AddBook(Book book)
    {
        Books.Add(book);
    }

    public void AddBook(int id, string title)
    {
        Books.Add(new Book(id, title));
    }

    public Book FindBook(int id)
    {
        return Books.FirstOrDefault(book => book.ID == id);
    }

    public Book FindBook(string id)
    {
        if (!int.TryParse(id, out int parsedId))
        {
            Console.WriteLine($"ID = {id}: not a valid book ID. Input string was not in a correct format.");
            return null;
        }

        return FindBook(parsedId);
    }
}