public class Electronics : Product
{
    public string Brand { get; set; }
    public string Model { get; set; }
    private static int _minimumStock = 10;

    public Electronics(string name, double price, int stock, string brand, string model) : base(name, price, stock)
    {
        Brand = brand;
        Model = model;
    }

    static Electronics()
    {
        // According to the assignment I don't need to fill this constructor(?)
    }
    
    public override void Sell(int units = 1)
    {
        if (Stock < units)
        {
            Console.WriteLine($"{Name} is out of stock");
        }
        else if (units > 0)
        {
            Stock -= units;
            Console.WriteLine($"{units} units of {Name} has been sold");
        }
        Restock();
    }
    
    private void Restock()
    {
        if (Stock < _minimumStock)
        {
            Stock = _minimumStock;
        }
    }
    
    public override string ToString() => $"Name: {Name} ({Brand} {Model}); price: {Price}; stock: {Stock}";
}