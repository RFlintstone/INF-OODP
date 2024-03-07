public class Consultant : IPayable
{
    public double HourlyRate { get; set; }
    public int HoursWorked { get; set; }
    public string Name { get; set; }

    public Consultant(string name, double hourlyRate)
    {
        Name = name;
        HourlyRate = hourlyRate;
    }

    public string Info => $"{Name}; {HourlyRate}/hour";
    public double GetPaymentAmount() => HourlyRate * HoursWorked;
}