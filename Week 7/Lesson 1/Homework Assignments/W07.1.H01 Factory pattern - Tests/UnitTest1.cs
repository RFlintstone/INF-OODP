namespace W07._1.H01_Factory_pattern___Tests;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void CreateLightTheme_Document()
    {
        // Create a new DocumentFactory object and and create a document with a light theme
        DocumentFactory documentFactory = new DocumentFactory();
        Document theme = documentFactory.CreateLightTheme();
        
        // Assert that both the document BackGroundColor and FontColor contain the expected values for this theme.
        Assert.AreEqual("White", theme.BackGroundColor);
        Assert.AreEqual("Black", theme.FontColor);
    }

    [TestMethod]
    public void CreateDarkTheme_Document()
    {
        // Create a new DocumentFactory object and and create a document with a dark theme
        DocumentFactory documentFactory = new DocumentFactory();
        Document theme = documentFactory.CreateDarkTheme();
        
        // Assert that both the document BackGroundColor and FontColor contain the expected values for this theme.
        Assert.AreEqual("Black", theme.BackGroundColor);
        Assert.AreEqual("White", theme.FontColor);
    }

    [TestMethod]
    public void CreateLightTheme_IDE()
    {
        // Create a new IDEFactory object and and create an ide with a light theme
        IDEFactory ideFactory = new IDEFactory();
        IDE theme = ideFactory.CreateLightTheme();
        
        // Assert that both the document BackGroundColor, FontColor and ButtonColor contain the expected values for this theme.
        Assert.AreEqual("White", theme.BackGroundColor);
        Assert.AreEqual("Black", theme.FontColor);
        Assert.AreEqual("Light blue", theme.ButtonColor);
    }

    [TestMethod]
    public void CreateDarkTheme_IDE()
    {
        // Create a new IDEFactory object and and create an ide with a dark theme
        IDEFactory ideFactory = new IDEFactory();
        IDE theme = ideFactory.CreateDarkTheme();
        
        // Assert that both the document BackGroundColor, FontColor and ButtonColor contain the expected values for this theme.
        Assert.AreEqual("Black", theme.BackGroundColor);
        Assert.AreEqual("White", theme.FontColor);
        Assert.AreEqual("Light yellow", theme.ButtonColor);
    }
}