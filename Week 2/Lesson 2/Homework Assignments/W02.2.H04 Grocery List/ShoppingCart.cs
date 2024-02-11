using System.Collections.Generic;
using System.Text;

public class ShoppingCart
{
    public List<GroupedShopItem> Groceries;

    public ShoppingCart()
    {
        Groceries = new List<GroupedShopItem>();
    }

    public void AddItem(ShopItem item)
    {
        GroupedShopItem itemInCart = FindItem(item);
        if (itemInCart is null)
        {
            Groceries.Add(new GroupedShopItem(item));
        }
        else
        {
            itemInCart.Quantity++;
        }
    }

    public GroupedShopItem FindItem(ShopItem item)
    {
        foreach (var groupedShopItem in Groceries)
        {
            if (groupedShopItem.Item.ID == item.ID)
            {
                return groupedShopItem;
            }
        }

        return null;
    }

    public string Contents()
    {
        StringBuilder contents = new StringBuilder();
        foreach (var groupedShopItem in Groceries)
        {
            contents.AppendLine($"{groupedShopItem.Item.Name} x {groupedShopItem.Quantity}");
        }

        contents.AppendLine($"\n{TotalPrice():0.00}");
        return contents.ToString();
    }

    public double TotalPrice()
    {
        double total = 0;
        foreach (var groupedShopItem in Groceries)
        {
            total += groupedShopItem.Item.Price * groupedShopItem.Quantity;
        }

        return total;
    }
}