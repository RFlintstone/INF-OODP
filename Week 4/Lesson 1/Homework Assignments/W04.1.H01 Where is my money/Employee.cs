class Employee
{
    public int Id;
    public static int nextId = 1;
    public int SalaryEarned;
    public int Salary;
    public int DistanceFromCompany;

    public Employee(int salary, int distance)
    {
        Id = nextId++;
        SalaryEarned = 0;
        Salary = salary;
        DistanceFromCompany = distance;
    }
}