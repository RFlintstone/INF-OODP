using System.IO;
using Newtonsoft.Json;

public static class Calculator
{
    public static double Add(double val1, double val2)
    {
        return val1 + val2;
    }

    public static double Subtract(double val1, double val2)
    {
        return val1 - val2;
    }

    public static double Multiply(double val1, double val2)
    {
        return val1 * val2;
    }

    public static double Divide(double val1, double val2)
    {
        return val1 / val2;
    }

    public static double Modulo(double val1, double val2)
    {
        return val1 % val2;
    }

    public static void StoreInMemory(double value)
    {
        string path = "Memory.json";
        using (StreamWriter writer = new StreamWriter(path))
        {
            writer.Write(JsonConvert.SerializeObject(value));
        }
    }

    public static double RestoreFromMemory()
    {
        string path = "Memory.json";
        using (StreamReader reader = new StreamReader(path))
        {
            string jsonString = reader.ReadToEnd();
            return JsonConvert.DeserializeObject<double>(jsonString);
        }
    }
}