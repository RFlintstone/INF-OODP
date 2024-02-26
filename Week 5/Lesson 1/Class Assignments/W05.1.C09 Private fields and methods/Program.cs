class Program
{
    public static void Main(String[] args)
    {
        // Create a bank account with a balance of 1000
        BankAccount account = new(1000);
        
        // Deposit 500
        account.Deposit(500);
        
        // Withdraw 200
        account.Withdraw(200);
        
        // Print the balance
        Console.WriteLine(account.ReadBalance()); //Expected 1300
        
        // Withdraw 2000 (not enough funds, so nothing should happen)
        account.Withdraw(2000);
        
        // Print the balance
        Console.WriteLine(account.ReadBalance()); //Expected 1300
    }
}