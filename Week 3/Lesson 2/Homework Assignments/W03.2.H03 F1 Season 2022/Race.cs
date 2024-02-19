public class Race
{
    public string Name { get; set; }
    public List<Driver> Drivers { get; set; }
    private static readonly int[] Points = { 25, 18, 15, 12, 10, 8, 6, 4, 2, 1 };

    public Race(string name)
    {
        Name = name;
        Drivers = new List<Driver>();
    }

    public void RunRace(List<Team> teams)
    {
        // Add all drivers to the race
        foreach (var team in teams)
        {
            Drivers.AddRange(team.Drivers);
        }

        // Shuffle the drivers list to simulate a random race outcome
        var random = new Random();
        Drivers = Drivers.OrderBy(x => random.Next()).ToList();

        // Assign points to the first 10 drivers
        for (int i = 0; i < Math.Min(10, Drivers.Count); i++)
        {
            Drivers[i].Points += Points[i];
        }
        
        // Print outcome of race
        // Ex: Max Verstappen of Red Bull Racing has won the Mexico Grand Prix!
        // After everything is printed, print a newline
        Console.WriteLine($"{Drivers[0].Name} of {teams.First(t => t.Drivers.Contains(Drivers[0])).Name} has won the {Name} Grand Prix!");
    }
}