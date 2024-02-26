class Program
{
    public static void Main()
    {
        // List<Person> people = new List<Person>();
        List<Person> people = new();
        
        // Create new Person and Student objects
        Person john = new("John Doe");
        Student jane = new("Jane Doe");
        
        //Write your code here
        people.Add(john);
        people.Add(jane);
        
        foreach (var person in people)
        {
            Console.WriteLine(person.Introduce());
            if (person is Student student)
            {
                Console.WriteLine(student.Status());
            }
        }
    }
}