class Program
{
    public static void Main(String[] args)
    {
        Person person = new Person("John", "Doe");
        Person person2 = new Person("Jane", "Doe");
        
        Console.WriteLine(person.FullName);
        Console.WriteLine(person2.FullName);
    }
}