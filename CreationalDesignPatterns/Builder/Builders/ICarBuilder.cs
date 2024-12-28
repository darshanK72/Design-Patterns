public interface ICarBuilder
{
    void Reset();
    void SetEngine(string engine);
    void SetWheels(int wheels);
    void SetGPS(bool hasGPS);
    Car GetResult();
}
