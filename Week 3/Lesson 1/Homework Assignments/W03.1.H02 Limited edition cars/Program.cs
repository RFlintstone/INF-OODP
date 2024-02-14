using System;

internal class Program
{
    public static void Main(string[] args)
    {
        var factory = new CarFactory(5);
        for (var i = 0; i < 10; i++)
        {
            var car = factory.ProduceLimitedEditionCar();
            if (car != null)
            {
                Console.WriteLine($"Car {car.ChassisNumber} produced");
            }
            else
            {
                Console.WriteLine("Production limit reached");
            }
        }
    }
}