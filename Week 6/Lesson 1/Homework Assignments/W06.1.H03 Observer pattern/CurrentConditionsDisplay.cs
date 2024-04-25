public class CurrentConditionsDisplay : IObserver, IDisplay
{
    private IObservable _observable;
    private double _temperature = 0.0;
    private double _humidity = 0.0;

    public CurrentConditionsDisplay(IObservable observable)
    {
        _observable = observable;
    }

    public void Display()
    {
        Console.WriteLine($"Current conditions: {_temperature}F degrees and {_humidity}% humidity");
    }
    
    public void Update()
    {
    }
}