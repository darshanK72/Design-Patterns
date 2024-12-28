public class Car
{
    public string Engine { get; set; }
    public int Wheels { get; set; }
    public bool HasGPS { get; set; }

    public override string ToString()
    {
        return $"Car [Engine: {Engine}, Wheels: {Wheels}, GPS: {HasGPS}]";
    }
}
