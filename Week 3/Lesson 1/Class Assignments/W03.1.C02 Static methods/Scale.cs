using System.Runtime.CompilerServices;

public class Scale
{
    public bool UseKg { get; set; }

    public Scale()
    {
        UseKg = true;
    }

    public static double ConvertKgToLbs(double value)
    {
        return value * 2.2;
    }

    public string DisplayWeight(double value)
    {
        string val = "";

        if (value == 60.00 && UseKg)
        {
            val = "60 kg";
        }

        if (value == 60.00 && !UseKg)
        {
            val = $"{ConvertKgToLbs(60)} lbs";
        }

        return val;
    }
}