using System;

internal class Person
{
    private string FirstName;
    private string LastName;

    public Person(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    public string Introduce() => $"I am {FirstName} {LastName}";
}