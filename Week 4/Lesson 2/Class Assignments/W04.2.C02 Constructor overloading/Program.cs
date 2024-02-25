class Program
{
    static void Main(string[] args)
    {
        // Create a new Person object
        Person person1 = new Person("John", 24);
        Person person2 = new Person("Bill");

        // Print out the name and age
        Console.WriteLine(person1.Name + " is " + person1.Age + " years old");
        Console.WriteLine(person2.Name + " is " + person2.Age + " years old");
    }
}