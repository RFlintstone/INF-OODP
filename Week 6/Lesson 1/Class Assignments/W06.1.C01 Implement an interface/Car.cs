﻿class Car : ICommute
{
    public int Mileage { get; private set; }
    public Car() => Mileage = 0;

    public void Move(int distance) => Console.WriteLine($"Drove {distance} kms\nMileage: {Mileage += distance} kms");
}