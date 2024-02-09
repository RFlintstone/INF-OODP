using System.Collections.Generic;
using System.Linq;

public class Library
{
    public List<Book> Books { get; set; }
    public int MaxSize { get; set; }

    public Library(int maxSize)
    {
        MaxSize = maxSize;
        Books = new List<Book>(MaxSize);
    }

    public bool AddBook(int id, string title)
    {
        if (Books.Count < MaxSize)
        {
            Books.Add(new Book(id, title));
            return true;
        }

        return false;
    }

    public Book FindBookByID(int id)
    {
        for (int i = 0; i < Books.Count; i++)
        {
            if (Books.ToArray()[i].ID == id)
            {
                return Books.ToArray()[i];
            }
        }

        return null;
    }

    public void EditBookTitle(int id, string newTitle)
    {
        for (int i = 0; i < Books.Count; i++)
        {
            if (Books.ToArray()[i].ID == id)
            {
                Books.ToArray()[i].Title = newTitle;
                break;
            }
        }
    }

    public void RemoveBookByTitle(string title)
    {
        for (int i = 0; i < Books.Count; i++)
        {
            if (Books.ToArray()[i].Title == title)
            {
                Books.Remove(Books.ToArray()[i]);
            }
        }
    }
}