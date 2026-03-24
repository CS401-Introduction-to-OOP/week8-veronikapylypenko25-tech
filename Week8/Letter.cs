namespace Week8;

public class Letter:DeliveryItem
{
    public Letter(string trackNumber, double weight) : base(trackNumber, weight)
    {
    }

    public override double CalculateCost()
    {
        return 15 + (Weight * 10);
    }
}