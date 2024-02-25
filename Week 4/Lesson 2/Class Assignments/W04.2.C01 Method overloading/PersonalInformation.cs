using static System.Console;

public static class PersonalInformation
{
    // PrintName method overloads
    public static void PrintName(string name) => WriteLine(name);
    public static void PrintName(string firstName, string lastName) => WriteLine($"{firstName} {lastName}");
    public static void PrintName(char initial, string name) => WriteLine($"{initial}. {name}");

    // IncreaseSalary method overloads
    public static int IncreaseSalary(int salary) => salary + 100;
    public static double IncreaseSalary(int salary, double percentage) => salary * (1 + percentage);
}