using static System.Formats.Asn1.AsnWriter;

public class Program
{
    public static void Main()
    {
        //Retrieving employees from a database or a file
        List<object> employees = new()
        {
            new Employee(1, "Miles Dyson", "Developer"),
            new Employee(2, "Coleman Reese", "Lawyer"),
            new Manager(3, "Bill Lumbergh", "Manager", 5),
            new Manager(4, "Michael Scott", "Manager", 10),
            new Dog("Owney the mascot dog") //Not an employee
        };
        ListDirectReports(employees);
    }

    public static void ListDirectReports(List<object> employees)
    {
        /*Your code goes here.
          Loop through the objects and use 'as' to cast them to a Manager.
          Then if not null, print (depending on the Manager's fields):
          "Manager Bill Lumbergh has 5 direct reports."
        */
        foreach (var employee in employees)
        {
            // Not allowed to use 'is' according to the assignment
            var isManager = employee as Manager;
            var isEmployee = employee as Employee;

            if (isManager != null)
            {
                Console.WriteLine($"Manager {isManager.Name} has {isManager.DirectReportsCount} direct reports.");
            }
            else if (isEmployee != null)
            {
                Console.WriteLine($"Employee {isEmployee.Name} is a {isEmployee.Position}.");
            }
            else
            {
                Console.WriteLine($"This is not an employee.");
            }
        }
    }
}