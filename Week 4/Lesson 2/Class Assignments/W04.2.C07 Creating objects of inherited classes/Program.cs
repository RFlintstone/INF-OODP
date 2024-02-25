class Program
{
    public static void Main()
    {
        // Create a new Person and a new Student
        var person = new Person("John Doe");
        var student = new Student("Jane Doe");
        
        // Introduce the Person and the Student
        Console.WriteLine(person.Introduce());
        Console.WriteLine(student.Introduce());
        
        // Student status
        Console.WriteLine(student.Status());
        
        // Graduate the Student
        student.Graduate();
        
        // Student status
        Console.WriteLine(student.Status());
    }
}