using Newtonsoft.Json;

class Program
{
    static void Main(string[] args)
    {
        // Make a new object using the key Person and Car classes from People.json
        List<Person> people = ReadJson();
        
        // For each person in the list
        foreach (Person person in people)
        {
            // Print the name of the person
            Console.WriteLine(person.Name);
            // For each car in the list of cars owned by the person
            foreach (Car car in person.OwnedCars)
            {
                // Drive each car 5 times
                for (int i = 0; i < 5; i++)
                {
                    car.Drive();
                }

                // Write new mileage to the JSON file
                WriteJson(people);
                
                // Print the brand and mileage of the car
                Console.WriteLine($"{car.Brand} has {car.Mileage} miles on it.");
            }
            
            // Print a blank line
            Console.WriteLine();
        }
    }

    public static List<Person> ReadJson()
    {
        StreamReader reader = new StreamReader("../../../People.json"); // Local
        // StreamReader reader = new StreamReader("People.json"); // Codegrade
        string json = reader.ReadToEnd();
        List<Person> people = JsonConvert.DeserializeObject<List<Person>>(json)!;
        reader.Close();
        Console.WriteLine($"Number of cars: {people.Count}");
        return people;
    }
    
    public static void WriteJson(List<Person> people)
    {
        StreamWriter writer = new StreamWriter("../../../People.json"); // Local
        // StreamWriter writer = new StreamWriter("People.json"); // Codegrade
        string json = JsonConvert.SerializeObject(people, Formatting.Indented);
        writer.Write(json);
        writer.Close();
    }
}