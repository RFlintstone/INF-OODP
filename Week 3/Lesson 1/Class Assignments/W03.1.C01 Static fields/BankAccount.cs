public class BankAccount
{
    public static double InterestRatePercentage;
    public double Balance;

    public void Deposit(double amount)
    {
        Balance += amount;
    }

    public void ApplyInterest()
    {
        double interest = Balance * (InterestRatePercentage / 100);
        Balance += interest;
    }
}