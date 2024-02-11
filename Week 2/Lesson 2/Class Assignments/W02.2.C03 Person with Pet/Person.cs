using System;

class Person
{
    public string Name;
    public Animal Pet;

    public Person(string name, Animal pet)
    {
        Name = name;
        Pet = pet;
    }
    public string Info()
    {
        var info = "";
        
        if (Pet is null)
            info = $"{Name} has no pet";
        if (Pet != null)
            info = $"{Name} has a pet that makes the sound {Pet.MakeSound()}";
        
        return info;
    }
}