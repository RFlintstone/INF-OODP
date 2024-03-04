public class BankAccount
{
    private double _balance;

    public BankAccount(double balance)
    {
        _balance = balance;
    }

    public double ReadBalance() => _balance;

    public void Deposit(double amount)
    {
        if (amount > 0)
            _balance += amount;
    }

    public double Withdraw(double amount)
    {
        if (!SufficientBalance(amount))
            return 0;
        return _balance -= amount;
    }

    private bool SufficientBalance(double amount)
    {
        bool hasSufficientFunds = _balance >= amount;
        return hasSufficientFunds;
    }
}