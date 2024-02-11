public class Song
{
    public string Title;
    public Artist Singer;

    public Song(string title)
    {
        Title = title;
        Singer = new Artist("Unknown");
    }
    
    public void SetSinger(Artist singer)
    {
        Singer = singer;
    }
    
    public string Info()
    {
        return $"{Title} is by {Singer.Name}";
    }
}