public class Team
{
    public string Name;
    public List<Driver> Drivers = new();
    
    public Team(string name)
    {
        Name = name;
    }

    public void ContractDriver(Driver driver)
    {
        Drivers.Add(driver);
    }
}