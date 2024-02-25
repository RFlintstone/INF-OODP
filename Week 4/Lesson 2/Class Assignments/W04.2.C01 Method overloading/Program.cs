using static System.Console;

class Program
{
    static void Main(string[] args)
    {
        // Call the PrintName method with one argument
        PersonalInformation.PrintName("John");
        // Call the PrintName method with two arguments
        PersonalInformation.PrintName("John", "Doe");
        // Call the PrintName method with two arguments
        PersonalInformation.PrintName('J', "Doe");
        // Call the IncreaseSalary method with one argument
        WriteLine(PersonalInformation.IncreaseSalary(1000));
        // Call the IncreaseSalary method with two arguments
        WriteLine(PersonalInformation.IncreaseSalary(1000, 0.10));
    }
}