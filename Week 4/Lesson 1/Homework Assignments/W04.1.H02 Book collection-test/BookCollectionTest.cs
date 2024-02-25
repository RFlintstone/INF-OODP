namespace BookCollection.Tests;
using BookCollection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

[TestClass]
public class BookCollectionTest
{
    private List<Book> books = new List<Book>();

    /*
        This methods runs before every test. Optionally use this to make sure every test starts with an empty state.
    */
    [TestInitialize]
    public void RemoveAllBooks()
    {
        // Remove all books
        books.Clear();
    }

    [TestMethod]
    public void Add_Book()
    {
        // Assert.IsTrue: assert that the count of books equals zero
        Assert.IsTrue(books.Count == 0);
        
        // Add a book
        var book = new Book("The Hobbit", "J.R.R. Tolkien", 1937);
        books.Add(new Book("The Hobbit", "J.R.R. Tolkien", 1937));
        
        // Assert.IsTrue: assert that the count of books equals one
        Assert.IsTrue(books.Count == 1);
    }

    [TestMethod]
    public void Remove_Book()
    {
        // Add a book
        Book book = new Book("Humpty Dumpty", "James William Elliott", 1870);
        books.Add(book);
        // Remove the book
        books.Remove(book);
        // Assert.IsTrue: assert that the count of books equals zero
        Assert.IsTrue(books.Count == 0);
    }

    [TestMethod]
    public void Remove_AllBooks()
    {
        // Remove all books
        books.Clear();
        // Assert.IsTrue: assert that the count of books equals zero
        Assert.IsTrue(books.Count == 0);
    }

    [TestMethod]
    public void Get_Books()
    {
        // Add three books
        books.Add(new Book("The Hobbit", "J.R.R. Tolkien", 1937));
        books.Add(new Book("Humpty Dumpty", "James William Elliott", 1870));
        books.Add(new Book("The Cat in the Hat", "Dr. Seuss", 1957));
        
        // Assert.IsTrue: assert that the count of books equals three    
        Assert.IsTrue(books.Count == 3);
    }

    [TestMethod]
    public void Get_Book()
    {
        books.Clear();
        
        // Add three books
        books.Add(new Book("Moby Dick", "Herman Melville", 1851));
        books.Add(new Book("Pride and Prejudice", "Jane Austen", 1813));
        books.Add(new Book("War and Peace", "Leo Tolstoy", 1869));

        // Assert.AreEqual: assert (twice) that the title of an added book matches the expected title)
        Assert.AreEqual("Moby Dick", books[0].Title);
        Assert.AreEqual("Pride and Prejudice", books[1].Title);
    }

    [TestMethod]
    public void Set_Books()
    {
        // Create a list with three books
        books.Clear();
        books.Add(new Book("Moby Dick", "Herman Melville", 1851));
        books.Add(new Book("Pride and Prejudice", "Jane Austen", 1813));
        books.Add(new Book("War and Peace", "Leo Tolstoy", 1869));        // Set the books

        // Assert.IsTrue: assert that the count of books equals three    
        Assert.IsTrue(books.Count == 3);
        
        // Assert.AreEqual: assert (twice) that the title of an added book matches the expected title)
        Assert.AreEqual("Moby Dick", books[0].Title);
        Assert.AreEqual("Pride and Prejudice", books[1].Title);
    }
}