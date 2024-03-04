public class SavingsAccount : BankAccount
{
    private bool _locked = true;

    public SavingsAccount(double balance, double interestRate) : base(balance, interestRate)
    {
        InterestRate = interestRate;
    }

    public override double Withdraw(double amount)
    {
        if (_locked) return 0;
        return base.Withdraw(amount);
    }

    public override void NextYear()
    {
        base.YearsPassed++;
        if (YearsPassed >= 5) _locked = false;

        if (YearsPassed < 5) { base.ApplyInterest();}
    }
}