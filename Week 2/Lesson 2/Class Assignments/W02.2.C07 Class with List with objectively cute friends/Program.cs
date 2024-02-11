using System.Collections.Generic;

class Program
{
    public static void Main()
    {
        /* Create a Person named john with the following pets:
         * - a Dog named Nugent
         * - a Cat named Steve
         * - a Goldfish named Brutus
         * Then for each Pet, print John's name, what the Pet is and their name.
         */

        Person john = new Person("John", new List<Pet>{});
        john.Pets.Add(new Pet("Dog", "Nugent"));
        john.Pets.Add(new Pet("Cat", "Steve"));
        john.Pets.Add(new Pet("Goldfish", "Brutus"));
        
        foreach (Pet pet in john.Pets)
        {
            System.Console.WriteLine($"{john.Name} has a {pet.WhatAmI} named {pet.Name}");
        }
    }
}