class Program
{
    public static void Main(String[] args)
    {
        Employee employee = new Employee("John", 1000);
        Console.WriteLine(employee.Name);
        Console.WriteLine(employee.Salary);
    }
}