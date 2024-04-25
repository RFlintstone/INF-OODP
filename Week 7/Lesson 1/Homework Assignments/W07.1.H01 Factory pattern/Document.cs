public class Document : DocumentFactory
{
    public string BackGroundColor { get; set; }
    public string FontColor { get; set; }
    
    public Document(string backGroundColor, string fontColor)
    {
        BackGroundColor = backGroundColor;
        FontColor = fontColor;
    }
}