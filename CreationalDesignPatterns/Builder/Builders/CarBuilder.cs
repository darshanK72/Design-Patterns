using System;
using System.Collections.Generic;

public class CarBuilder : ICarBuilder
{
    private Car _car;

    public CarBuilder()
    {
        Reset();
    }

    public void Reset()
    {
        _car = new Car();
    }

    public void SetEngine(string engine)
    {
        _car.Engine = engine;
    }

    public void SetWheels(int wheels)
    {
        _car.Wheels = wheels;
    }

    public void SetGPS(bool hasGPS)
    {
        _car.HasGPS = hasGPS;
    }

    public Car GetResult()
    {
        return _car;
    }
}
