namespace Week8;

public class Parcel:DeliveryItem
{
    public string Dimensions { get;}
    public Parcel(string dimensions, string trackNumber, double weight) : base(trackNumber, weight)
    {
        Dimensions = dimensions;
    }

    public override double CalculateCost()
    {
        return 50 + (Weight * 25);
    }

    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"Dimensions:{Dimensions}.");
    }
}