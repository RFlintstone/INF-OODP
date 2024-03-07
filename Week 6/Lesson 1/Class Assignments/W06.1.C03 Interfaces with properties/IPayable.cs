public interface IPayable
{
    string Name { get; set; }
    string Info { get; }
    public double GetPaymentAmount();
}