class Program
{
    public static void Main(String[] args)
    {
        var person = new Person("John", 25);
        var person2 = new Person("Jane", 140);

        Console.WriteLine(person.Info); // John is 25 years old
        Console.WriteLine(person2.Info); // Jane is 0 years old
    }
}