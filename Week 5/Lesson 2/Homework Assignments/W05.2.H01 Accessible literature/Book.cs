public class Book : Publication
{
    // Property ISBN is read-only from outside the class
    public string ISBN { get; set; }
    
    // Property Currency is read-only from outside the class
    public string Currency { get; set; }
    
    // Property Price is read-only from outside the class
    public double Price { get; set; }
    
    // Property Author is read-only from outside the class
    public string Author { get; set; }
    public DateTime PublicationDate { get; set; }

    // Constructor - sets the ISBN, title, publisher, publication type and audience
    public Book(string isbn, string title, string publisher, string pubType, List<string> audience) : base(title, publisher, pubType, audience)
    {
        ISBN = isbn;
        Title = title;
        Publisher = publisher;
        PublicationType = pubType;
    }
    
    // Method to set the price and currency of the book
    public void SetPrice(double price, string currency)
    {
        Price = price;
        Currency = currency;
    }

    // Method to check if the book is suitable for children
    public bool IsSuitableForChild()
    {
        return Audience.Contains("Children");
    }
    
    // Method to publish the book
    public override string ToString()
    {
        return $"{Title}, {Author}, {PublishedOn}";
    }
}