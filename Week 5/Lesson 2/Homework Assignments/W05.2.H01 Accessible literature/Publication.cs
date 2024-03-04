// ! UML diagram != Codegrade's Unit Tests !
// I'm giving up.. IO Test - Full Math is not set up correctly.
// When I need to use private properties to mark them as 'correct' in doesn't find the properties.
// And, if I do change them it is not in line with the UML diagram anymore. (Properties and method signatures have been written based on the UML diagram)
// If this would work I would have finished the assignment but I just am not able to test the code properly.

public class Publication
{
    // Property Publisher is read-only from outside the class
    public string Publisher { get; set; }

    // Property Title is read-only from outside the class
    public string Title { get; init; }

    // Property PublicationType is read-only from outside the class
    public string PublicationType { get; protected init; }

    // Property Pages is read-only from outside the class
    private int _pages;

    public int Pages
    {
        get { return _pages; }
        set
        {
            if (value > 0) _pages = value;
        }
    }

    // Property PublishedOn is read-only from outside the class
    public DateTime? PublicationDate { get; set; }

    public virtual string PublishedOn
    {
        get { return PublicationDate.HasValue ? PublicationDate.Value.ToString("yyyy-MM-dd") : "not published yet"; }
        set { PublicationDate = DateTime.Parse(value); }
    }

    // Property Audience is read-only from outside the class
    protected List<string> Audience { get; set; }

    // Property IsPublished is read-only from outside the class
    protected bool IsPublished
    {
        get { return PublicationDate.HasValue; }
    }

    // Constructor - sets the title, publisher, publication type and audience
    public Publication(string title, string publisher, string pubType, List<string> audience)
    {
        Title = title;
        Publisher = publisher;
        PublicationType = pubType;
        Audience = audience;
    }

    // Method to check if the publication is suitable for a specific audience
    public bool IsSuitableForAudience(string audience)
    {
        return Audience.Contains(audience);
    }

    // Method to publish the publication
    public override string ToString()
    {
        return $"{Title}, {Pages} pages, {PublishedOn}";
    }
}