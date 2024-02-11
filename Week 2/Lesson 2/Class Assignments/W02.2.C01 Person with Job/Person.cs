public class Person
{
    public string Name;
    public Job DayJob;

    public Person(string name, Job dayJob)
    {
        Name = name;
        DayJob = dayJob;
    }

    public string Info()
    {
        string info;
        if (DayJob?.Name is null)
        {
            info = $"{Name} is in between jobs";
        }
        else
        {
            info = $"{Name} works as a {DayJob.Name}";
        }

        return info;
    }
}