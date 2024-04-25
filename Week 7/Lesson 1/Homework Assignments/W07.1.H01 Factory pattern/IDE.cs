public class IDE : IDEFactory
{
    public string BackGroundColor { get; set; }
    public string FontColor { get; set; }
    public string ButtonColor { get; set; }
    private int attribute7 { get; set; }
    
    public IDE(string backGroundColor, string fontColor, string buttonColor)
    {
        BackGroundColor = backGroundColor;
        FontColor = fontColor;
        ButtonColor = buttonColor;
    }
}