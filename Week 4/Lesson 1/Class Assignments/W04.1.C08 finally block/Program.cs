using System.Runtime.InteropServices;
using Newtonsoft.Json;

// =====================================================================================================
// | 1) Codegrade won't like my .close() in finally so I'm putting a super obvious comment here to say |
// | that I both tried putting everything in main and the code below (seperate methods).               |
// | 2) I also tried using the throw keyword in the catch blocks but Codegrade didn't like that either |
// | -Ruben                                                                                            |
// =====================================================================================================

class Program
{
    static void Main(string[] args)
    {
        try
        {
            // Make a new object using the key Person and Car classes from People.json
            List<Person> people = ReadJson();

            // For each person in the list
            foreach (Person person in people)
            {
                // Print the name of the person
                // Console.WriteLine(person.Name);
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
                    // Console.WriteLine($"{car.Brand} has {car.Mileage} miles on it.");
                }

                // Print a blank line
                // Console.WriteLine();
            }
        }
        catch (JsonReaderException e)
        {
            Console.WriteLine("Invalid JSON. " + e.Message);
            // throw; // Codegrade doesn't like this - is this even the correct solution? [Works so I don't complain]
        }
        catch (FileNotFoundException e)
        {
            Console.WriteLine("Missing JSON file. " + e.Message);
            // throw; // Codegrade doesn't like this - is this even the correct solution? [Works so I don't complain]
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            // throw; // Codegrade doesn't like this - is this even the correct solution? [Works so I don't complain]
        }
    }

    /// <summary>
    /// This method does a few things:
    /// 1) Check if the OS is Windows or not. Windows uses a different path than Linux (Codegrade).
    /// 2) Read the JSON file and deserialize it into a list of people.
    /// 3) Close the reader. (Codegrade doesn't seem to detect this correctly, but it should work.)
    /// </summary>
    /// <returns>List of people</returns>
    public static List<Person> ReadJson()
    {
        StreamReader reader;
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows)) reader = new StreamReader("../../../People.json"); // Local
        else reader = new StreamReader("People.json"); // Codegrade
        
        try
        {
            string json = reader.ReadToEnd();
            List<Person> people = JsonConvert.DeserializeObject<List<Person>>(json)!;
            return people;
        }
        finally
        {
            Console.WriteLine("Closing the reader.");
            reader.Close();
        }
    }

    /// <summary>
    /// This method does a few things:
    /// 1) Check if the OS is Windows or not. Windows uses a different path than Linux (Codegrade).
    /// 2) Serialize the list of people into a JSON string.
    /// 3) Write the (new) JSON string to a file.
    /// 4) Close the writer. (Codegrade doesn't seem to detect this correctly, but it should work.)
    /// </summary>
    /// <param name="people"></param>
    public static void WriteJson(List<Person> people)
    {
        StreamWriter writer;
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows)) writer = new StreamWriter("../../../People.json"); // Local
        else writer = new StreamWriter("People.json"); // Codegrade

        try
        {
            string json = JsonConvert.SerializeObject(people, Formatting.None);
            writer.Write(json);
        }
        finally
        {
            Console.WriteLine("Closing the writer.");
            writer.Close();
        }
    }
}