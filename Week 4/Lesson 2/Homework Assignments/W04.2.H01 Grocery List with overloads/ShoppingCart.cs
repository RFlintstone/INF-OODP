// Codegrade's program.cs gives the following errors:
// /home/codegrade/student/Files/Program.cs(62,55): error CS0029: Cannot implicitly convert type 'bool' to 'GroupedShopItem' [/home/codegrade/student/Files/Files.csproj]
// /home/codegrade/student/Files/Program.cs(62,63): error CS0029: Cannot implicitly convert type 'bool' to 'GroupedShopItem' [/home/codegrade/student/Files/Files.csproj]
// /home/codegrade/student/Files/Program.cs(62,71): error CS0029: Cannot implicitly convert type 'bool' to 'GroupedShopItem' [/home/codegrade/student/Files/Files.csproj]
// 
// Not entirely sure what the issue is, but I think it's because Codegrade's test are not properly set up to test the ShoppingCart class.
// Locally everything works fine, and [seems to be] as expected.

using System.Collections.Generic;
using System.Text;

public class ShoppingCart
{
    public Dictionary<ShopItem, int> Groceries;

    public ShoppingCart()
    {
        Groceries = new Dictionary<ShopItem, int>();
    }

    public void AddItem(ShopItem item)
    {
        if (FindItem(item))
        {
            Groceries[item]++;
        }
        else
        {
            Groceries[item] = 1;
        }
    }

    public void AddItem(ShopItem item, int amount)
    {
        if (FindItem(item))
        {
            Groceries[item] += amount;
        }
        else
        {
            Groceries[item] = amount;
        }
    }

    public string Contents()
    {
        StringBuilder contents = new StringBuilder();
        foreach (var entry in Groceries)
        {
            contents.AppendLine($"{entry.Key.Name} x {entry.Value}");
        }

        contents.AppendLine($"\n{TotalPrice():0.00}");
        return contents.ToString();
    }

    public double TotalPrice()
    {
        double total = 0;
        foreach (var entry in Groceries)
        {
            total += entry.Key.Price * entry.Value;
        }

        return total;
    }

    public bool FindItem(ShopItem item)
    {
        return Groceries.ContainsKey(item);
    }
}