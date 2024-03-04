using Newtonsoft.Json;

class Program
{
    public static void Main()
    {
        // Read values of Car object fields
        List<Car> cars = ReadCarsJson();

        // For each car in the list
        foreach (Car car in cars)
        {
            // Drive each car 5 times
            for (int i = 0; i < 5; i++)
            {
                car.Drive();
            }

            // Print values of Car object fields
            Console.WriteLine(car.Brand);
            Console.WriteLine(car.Mileage);
        }
        
        // Write updated cars to JSON
        WriteCarsJson(cars);
    }

    public static List<Car> ReadCarsJson()
    {
        StreamReader reader = new StreamReader("../../../Cars.json"); // Local
        // StreamReader reader = new StreamReader("Cars.json"); // Codegrade
        string json = reader.ReadToEnd();
        List<Car> cars = JsonConvert.DeserializeObject<List<Car>>(json)!;
        reader.Close();
        Console.WriteLine($"Number of cars: {cars.Count}");
        return cars;
    }

    public static void WriteCarsJson(List<Car> cars)
    {
        StreamWriter writer = new StreamWriter("../../../Cars.json"); // Local
        // StreamWriter writer = new StreamWriter("Cars.json"); // Codegrade
        string json = JsonConvert.SerializeObject(cars);
        writer.Write(json);
        writer.Close();
    }
}