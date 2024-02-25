public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    // Constructor that takes two parameters
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    // Constructor that takes one parameter
    public Person(string name): this(name, 0)
    {
        // Can be left empty
    }
}