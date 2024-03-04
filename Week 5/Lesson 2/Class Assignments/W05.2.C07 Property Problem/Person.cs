class Person
{
    public Person(string name, int age)
    {
        Name = name;
        _age = age;
    }

    public string Name { get; set; }
    
    private int _age;
    public int Age
    {
        get => _age is >= 0 and <= 130 ? _age : 0;
        set => _age = value is >= 0 and <= 130 ? value : 0;
    }

    public string Info { get => $"{Name} is {Age} years old"; }
}