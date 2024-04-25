class Program
{
    public static void Main(String[] args)
    {
        List<Bill> bills = new()
        {
            new ElectricityBill(50.0, "John Smith"),
            new ElectricityBill(75.0, "Jane Doe"),
            new GasBill(100.0, "Bob Johnson", false),
            new GasBill(125.0, "John Doe", true)
        };

        int total = 0;
        foreach (Bill bill in bills)
        {
            Console.WriteLine(bill.GetDescription());
            total += (int)bill.Amount;
        }
        Console.WriteLine($"Total amount: {total}");
    }
}