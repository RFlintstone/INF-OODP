public class Season
{
    int Year;
    private List<Race> Races;
    private List<Team> Teams;

    public Season(int year, List<Race> races, List<Team> teams)
    {
        Year = year;
        Races = races;
        Teams = teams;
    }

    public void RunSeason()
    {
        foreach (var race in Races)
        {
            race.RunRace(Teams);
        }
    }

    public void SeasonResults()
    {
        var drivers = new List<Driver>();
        foreach (var team in Teams)
        {
            drivers.AddRange(team.Drivers);
        }

        drivers = drivers.OrderByDescending(d => d.Points).ToList();

        foreach (var driver in drivers)
        {
            Console.WriteLine($"{driver.Name}: {driver.Points} points");
        }
    }
}