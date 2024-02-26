public class Product
{
    public string Name { get; set; }
    public double Price { get; set; }
    public int Stock { get; set; }
    
    public Product(string name, double price, int stock)
    {
        Name = name;
        Price = price;
        Stock = stock;
    }
    
    public virtual void Sell(int units = 1)
    {
        if (Stock < units) 
        {
            Console.WriteLine($"{Name} is out of stock");
            return;
        }
        Stock -= units;
        Console.WriteLine($"{units} units of {Name} has been sold");
    }

    public override string ToString() => $"Name: {Name}; price: {Price}; stock: {Stock}";
}