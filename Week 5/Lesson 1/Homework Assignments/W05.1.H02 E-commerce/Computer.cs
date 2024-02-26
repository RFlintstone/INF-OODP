public class Computer : Electronics
{
    public Computer(string name, double price, int stock, string brand, string model) : base(name, price, stock, brand, model)
    {
    }

    static Computer()
    {
    }

    public override void Sell(int units = 1)
    {
        while (units > 0)
        {
            if (Stock <= 0)
            {
                Console.WriteLine($"{Name} is out of stock");
                break;
            }
            else if (Stock < units)
            {
                Console.WriteLine($"{Stock} units of {Name} has been sold");
                units -= Stock;
                Stock = 0;
            }
            else
            {
                Console.WriteLine($"{units} units of {Name} has been sold");
                Stock -= units;
                units = 0;
            }
            OfferAssistance();
        }
        base.Sell(0);
    }

    private void OfferAssistance()
    {
        Console.WriteLine("Call for installation help: 1234HELPME");
    }
}