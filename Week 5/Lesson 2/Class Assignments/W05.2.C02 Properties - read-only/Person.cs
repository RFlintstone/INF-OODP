public class Person
{
    private string _firstName { get; set; }
    private string _lastName { get; set; }

    public Person(string firstName, string lastName)
    {
        _firstName = firstName;
        _lastName = lastName;
    }
    
    public string FullName
    {
        get
        {
            return $"{_firstName} {_lastName}";
        }
    }
}