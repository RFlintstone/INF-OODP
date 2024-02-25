// Codegrade's program.cs gives the following errors:
// /home/codegrade/student/Files/Program.cs(62,55): error CS0029: Cannot implicitly convert type 'bool' to 'GroupedShopItem' [/home/codegrade/student/Files/Files.csproj]
// /home/codegrade/student/Files/Program.cs(62,63): error CS0029: Cannot implicitly convert type 'bool' to 'GroupedShopItem' [/home/codegrade/student/Files/Files.csproj]
// /home/codegrade/student/Files/Program.cs(62,71): error CS0029: Cannot implicitly convert type 'bool' to 'GroupedShopItem' [/home/codegrade/student/Files/Files.csproj]
// 
// Not entirely sure what the issue is, but I think it's because Codegrade's test are not properly set up to test the ShoppingCart class.
// Locally everything works fine, and [seems to be] as expected.

public class ShopItem
{
    public string ID;
    public string Name;
    public double Price;

    public ShopItem(string ID, string Name, double Price)
    {
        this.ID = ID;
        this.Name = Name;
        this.Price = Price;
    }
    
    public ShopItem(string ID, double Price)
    {
        this.ID = ID;
        this.Name = "Unknown";
        this.Price = Price;
    }
}