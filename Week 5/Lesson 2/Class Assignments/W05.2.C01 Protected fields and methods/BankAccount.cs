public class BankAccount
{
    private double _balance;
    protected int YearsPassed = 0;
    protected double InterestRate;

    public BankAccount(double balance, double interestRate)
    {
        _balance = balance;
        InterestRate = interestRate;
    }

    public double ReadBalance() => _balance;

    public virtual double Withdraw(double amount)
    {
        if (_balance < amount)
            return 0;
        _balance -= amount;
        return amount;
    }

    public virtual void NextYear()
    {
        ApplyInterest();
    }

    protected void ApplyInterest()
    {
        _balance += _balance * InterestRate;
    }
}