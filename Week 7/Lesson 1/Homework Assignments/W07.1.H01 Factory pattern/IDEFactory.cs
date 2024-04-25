public class IDEFactory : IFactory<IDE>
{
    public IDE CreateLightTheme()
    {
        var ide = new IDE("White", "Black", "Light blue");
        return ide;
    }

    public IDE CreateDarkTheme()
    {
        var ide = new IDE("Black", "White", "Light yellow");
        return ide;
    }
}