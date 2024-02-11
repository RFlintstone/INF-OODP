using System;


internal class Program
{
    public static void Main(string[] args)
    {
        ShoppingCart cart = new ShoppingCart();
        cart.AddItem(new ShopItem("1", "Milk", 1.5));
        cart.AddItem(new ShopItem("2", "Bread", 1));
        cart.AddItem(new ShopItem("3", "Butter", 2));
        cart.AddItem(new ShopItem("4", "Eggs", 3));
        cart.AddItem(new ShopItem("5", "Cheese", 2.5));
        cart.AddItem(new ShopItem("5", "Cheese", 2.5));
        string contents = cart.Contents();
        double total = cart.TotalPrice();

        Console.WriteLine(contents);
        // Console.WriteLine("Total: " + total);
    }
}