public class Magazine : Publication
{
    // Property Issue is read-only from outside the class
    public override string PublishedOn
    {
        get { return PublicationDate.HasValue ? PublicationDate.Value.ToString("yyyy-MM") : "not published yet"; }
        set { PublicationDate = DateTime.Parse(value); }
    }
    
    // Property Issue is read-only from outside the class
    private string Issue { get; set; }
    
    // Constructor - sets the title, publisher, publication type and audience
    public Magazine(string title, string publisher, string pubType, List<string> audience) : base(title, publisher, pubType, audience)
    {
        Title = title;
        Publisher = publisher;
        PublicationType = pubType;
        Audience = audience;
    }
}