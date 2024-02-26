public class Clothes : Product
{
    public string Size { get; set; }
    public string Material { get; set; }
    
    public Clothes(string name, double price, int stock, string size, string material) : base(name, price, stock)
    {
        Size = size;
        Material = material;
    }
    
    // According to the UML diagram, this method should be overriden without the parameter but that is not possible
    // So I set the parameter to 1 as default to fulfill the signature of the method
    public override void Sell(int units = 1)
    {
        if (Stock < units) 
        {
            Console.WriteLine($"{Name} is out of stock");
            Console.WriteLine(WashingInstructions());
            return;
        }
        Stock -= units;
        Console.WriteLine($"{units} units of {Name} has been sold");
        Console.WriteLine(WashingInstructions());
    }

    private string WashingInstructions()
    {
        switch (Material)
        {
            case "Cotton":
                return "Gentle";
            case "Wool":
                return "Hand";
            case "Linen":
                return "Washing machine";
            default:
                return "Unknown";
        }
    }
    
    public override string ToString() => $"Name: {Name}; price: {Price}; stock: {Stock}; size: {Size}; material: {Material}";
}