public class Task
{
    public string Name;
    bool IsDone;

    public Task(string Name)
    {
        this.Name = Name;
        IsDone = false;
    }

    public void Done()
    {
        IsDone = true;
    }

    public string Info()
    {
        string status = IsDone ? "Done" : "Pending";
        string message = $"Task: {Name}, Status: {status}";
        // System.Console.WriteLine(message);
        return message;
    }
}