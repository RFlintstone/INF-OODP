using System;


internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Cart 1:");
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
        
        Console.WriteLine("Cart 2:");
        ShoppingCart cart2 = new ShoppingCart();
        cart2.AddItem(new ShopItem("1", "Milk", 1.5), 2);
        cart2.AddItem(new ShopItem("2", "Bread", 1), 3);
        cart2.AddItem(new ShopItem("3", "Butter", 2), 4);
        cart2.AddItem(new ShopItem("4",3), 5);
        cart2.AddItem(new ShopItem("5",  2.5), 6);
        cart2.AddItem(new ShopItem("5", 2.5), 7);
        string contents2 = cart2.Contents();
        double total2 = cart2.TotalPrice();
        Console.WriteLine(contents2);
        // Console.WriteLine("Total: " + total2);
    }
}