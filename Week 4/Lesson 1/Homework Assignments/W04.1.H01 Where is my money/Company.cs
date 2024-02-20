/// <summary>
/// Represents a company with a list of employees and related properties.
/// </summary>
class Company
{
    /// <summary>
    /// List of employees in the company.
    /// </summary>
    public List<Employee> Employees;

    /// <summary>
    /// Distance from the company that is considered distant.
    /// </summary>
    public int WhatIsConsideredDistant;

    /// <summary>
    /// The budget for extra travel allowance.
    /// </summary>
    public int ExtraTravelAllowanceBudget;

    /// <summary>
    /// The maximum extra travel allowance that can be given to an employee.
    /// </summary>
    public int MaxExtraTravelAllowance;

    /// <summary>
    /// The location of the log file.
    /// </summary>
    public string LogLocation;

    /// <summary>
    /// Initializes a new instance of the Company class.
    /// </summary>
    public Company()
    {
        Employees = new List<Employee>();
        WhatIsConsideredDistant = 25;
        ExtraTravelAllowanceBudget = 300;
        MaxExtraTravelAllowance = 100;
        LogLocation = "./Log.txt";
    }

    /// <summary>
    /// Adds an employee to the company's list of employees.
    /// </summary>
    /// <param name="employee">The employee to be added.</param>
    public void Hire(Employee employee) => Employees.Add(employee);

    /// <summary>
    /// Pays the monthly salary to all employees, including travel allowance.
    /// </summary>
    public void PayMonthlySalary()
    {
        int howManyDistantEmployees = HowManyDistantEmployees();
        foreach (var employee in Employees)
        {
            int payout = employee.Salary + CalculateTravelAllowance(employee, howManyDistantEmployees);
            employee.SalaryEarned += payout;
        }
    }

    /// <summary>
    /// Calculates the travel allowance for an employee.
    /// </summary>
    /// <param name="employee">The employee for whom the travel allowance is calculated.</param>
    /// <param name="howManyDistantEmployees">The number of employees who live at a distance considered distant.</param>
    /// <returns>The calculated travel allowance.</returns>
    private int CalculateTravelAllowance(Employee employee, int howManyDistantEmployees)
    {
        //----------------------------------------------------------|
        // I'm still working on this method. It's not finished yet. |
        //----------------------------------------------------------|
        
        // For employees that live really far (25+ km), there is a budget for extra reimbursement.
        // This extra reimbursement is divided among the distant employees, with a maximum with 100 euros per employee.
        // Whatever is left over from this budget is divided among the rest of the employees.
        var howManyCloseEmployees = Employees.Count - howManyDistantEmployees;
        
        // Give extra travel allowance to distant employees, but don't exceed the budget or return the method.
        if(employee.DistanceFromCompany >= WhatIsConsideredDistant)
        {
            if (ExtraTravelAllowanceBudget > 0)
            {
                int extraTravelAllowance = Math.Min(MaxExtraTravelAllowance, ExtraTravelAllowanceBudget);
                ExtraTravelAllowanceBudget -= extraTravelAllowance;
                return extraTravelAllowance;
            }
            else
            {
                LogException("Extra travel allowance budget exceeded.");
                return 0;
            }
        }
        
        // If there is budget left, give the rest to the close employees.
        if (ExtraTravelAllowanceBudget > 0)
        {
            int extraTravelAllowance = ExtraTravelAllowanceBudget / howManyCloseEmployees;
            ExtraTravelAllowanceBudget -= extraTravelAllowance;
            return extraTravelAllowance;
        }
        else
        {
            LogException("Extra travel allowance budget exceeded.");
            return 0;
        }
    }

    /// <summary>
    /// Counts the number of employees who live at a distance considered distant.
    /// </summary>
    /// <returns>The number of employees who live at a distance considered distant.</returns>
    private int HowManyDistantEmployees()
    {
        int howMany = 0;
        foreach (var employee in Employees)
        {
            if (employee.DistanceFromCompany >= WhatIsConsideredDistant) howMany++;
        }

        return howMany;
    }

    /// <summary>
    /// Logs an exception message to a file.
    /// </summary>
    /// <param name="message">The message to be logged.</param>
    private void LogException(string message)
    {
        try
        {
            File.AppendAllText(LogLocation, DateTime.Now + "\n" + message + "\n");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}