using System.Collections.Generic;

class Program
{
    public static void Main()
    {
        /*Create a List of Pets here:
         *- a Dog named Nugent
         *- a Cat named Steve
         *- a Goldfish named Brutus
         */

        // Create a List of Pets
        List<Pet> pets = new List<Pet>
        {
            new Pet("Dog", "Nugent"),
            new Pet("Cat", "Steve"),
            new Pet("Goldfish", "Brutus")
        };
        
        // Print the list of pets
        foreach (var pet in pets)
        {
            System.Console.WriteLine($"I have a {pet.WhatAmI} named {pet.Name}");
        }
    }
}