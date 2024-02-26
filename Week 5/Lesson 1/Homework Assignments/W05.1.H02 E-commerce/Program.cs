class Program
{
    public static void Main(String[] args)
    {
        Product[] products = new Product[3];
        products[0] = new Clothes("T-shirt", 19.99, 100, "M", "Cotton");
        products[1] = new Electronics("Smartphone", 699.99, 50, "Samsung", "Galaxy S20");
        products[2] = new Computer("Laptop", 999.99, 30, "Lenovo", "ThinkPad X1 Carbon");
        
        foreach (Product product in products)
        {
            Console.WriteLine(product);
            product.Sell();
            Console.WriteLine(product);
        }
    }
}