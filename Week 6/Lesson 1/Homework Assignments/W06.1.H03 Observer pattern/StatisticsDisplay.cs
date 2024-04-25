public class StatisticsDisplay : IObserver, IDisplay
{
    private IObservable _observable;
    private double _minTemperature = double.MaxValue;
    private double _maxTemperature = double.MinValue;
    private double _totalTemperature = 0.0;
    private int _numUpdates = 0;

    public StatisticsDisplay(IObservable observable)
    {
        _observable = observable;
        observable.RegisterObserver(this);
    }

    public void Display()
    {
        double avgTemperature = _totalTemperature / _numUpdates;
        Console.WriteLine($"Avg/Min/Max temperature = {avgTemperature}/{_minTemperature}/{_maxTemperature}");
    }

    public void Update()
    {
        if (_observable is WeatherData weatherData)
        {
            double currentTemperature = weatherData.Temperature;
            _totalTemperature += currentTemperature;
            _numUpdates++;

            if (currentTemperature < _minTemperature)
            {
                _minTemperature = currentTemperature;
            }

            if (currentTemperature > _maxTemperature)
            {
                _maxTemperature = currentTemperature;
            }

            Display();
        }
    }
}