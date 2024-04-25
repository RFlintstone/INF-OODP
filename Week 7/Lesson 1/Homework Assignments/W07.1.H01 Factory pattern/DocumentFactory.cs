public class DocumentFactory : IFactory<Document>
{
    public Document CreateLightTheme()
    {
        var theme = new Document("White", "Black");
        return theme;
    }

    public Document CreateDarkTheme()
    {
        var theme = new Document("Black", "White");
        return theme;
    }
}