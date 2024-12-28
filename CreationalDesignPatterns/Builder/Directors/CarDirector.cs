public class CarDirector
{
    private readonly ICarBuilder _builder;

    public CarDirector(ICarBuilder builder)
    {
        _builder = builder;
    }

    public void ConstructSportsCar()
    {
        _builder.Reset();
        _builder.SetEngine("V8 Engine");
        _builder.SetWheels(4);
        _builder.SetGPS(true);
    }

    public void ConstructCityCar()
    {
        _builder.Reset();
        _builder.SetEngine("Electric Engine");
        _builder.SetWheels(4);
        _builder.SetGPS(false);
    }
}
