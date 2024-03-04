// Ok, so why doesn't this work in it's entirety....
// I've followed the instructions to the letter, but it's not working.

// Learning goals:
// - read/write properties
// - property set validation
//
// Create class Temperature with private double field _celsius. It has the following properties:
//
// - Celsius:
//   - get: returns _celsius
//   - set: sets _celsius to the value, but only if it is at least -273.15
// - Kelvin:
//   - get: returns Celsius + 273.15
//   - set: sets Celsius to the value - 273.15
//
// Note: _celsius is the backing field of Celsius.

public class Temperature
{
    private double _celsius;

    public double Celsius
    {
        get { return _celsius; }
        set { if (_celsius >= -273.15) _celsius = value; }
    }

    public double Kelvin
    {
        get { return Celsius + 273.15; }
        set { Celsius = value - 273.15; }
    }
}