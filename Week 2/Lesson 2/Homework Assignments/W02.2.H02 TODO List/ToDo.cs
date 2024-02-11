using System.Collections.Generic;

public class ToDo
{
    private List<Task> TaskList;

    public ToDo()
    {
        TaskList = new List<Task>();
    }

    public void AddTask(string Name)
    {
        Task task = new Task(Name);
        TaskList.Add(task);
    }

    public Task GetTask(string Name)
    {
        foreach (Task task in TaskList)
        {
            if (task.Name == Name)
            {
                return task;
            }
        }

        return null;
    }

    public string Report()
    {
        string report = "";
        foreach (Task task in TaskList)
        {
            if (task != null)
            {
                report += $"{task.Info()}\n";
            }
        }
        return report;
    }
    
    public static void Main(string[] args)
    {
        ToDo toDo = new ToDo();
        
        // Add tasks
        toDo.AddTask("T1");
        toDo.AddTask("T2");
        toDo.AddTask("T3");
        toDo.AddTask("T4");
        
        // Mark tasks as done
        toDo.GetTask("T2").Done();
        toDo.GetTask("T4").Done();
        
        // Print report
        System.Console.WriteLine(toDo.Report());
    }
}